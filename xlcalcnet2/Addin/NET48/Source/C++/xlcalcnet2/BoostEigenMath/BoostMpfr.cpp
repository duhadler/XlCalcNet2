

#include <boost/math/tools/user.hpp>  // various settings were changed
#include <boost/math/tools/config.hpp> // define BOOST_MATH_NO_THREAD_LOCAL_WITH_NON_TRIVIAL_TYPES // -> commented out

#include "BoostMpfr.h"


#include "stdint.h"
#include <complex>
#include <vector>
#include <iostream>
#include <limits>


#define mp_const_dist_pdf 1
#define mp_const_dist_cdf_P 2
#define mp_const_dist_cdf_Q 3
#define mp_const_dist_Hazard 4
#define mp_const_dist_CHF 5
#define mp_const_dist_Pinv 6
#define mp_const_dist_Qinv 7
#define mp_const_dist_Mean 8
#define mp_const_dist_Median 9
#define mp_const_dist_Mode 10
#define mp_const_dist_Variance 11
#define mp_const_dist_Stdev 12
#define mp_const_dist_Skewness 13
#define mp_const_dist_Kurtosis 14
#define mp_const_dist_KurtosisExcess 15
#define mp_const_dist_support_left 16
#define mp_const_dist_support_right 17
#define mp_const_dist_range_left 18
#define mp_const_dist_range_right 19


#define MP_DIST_RETURN \
    mpfr_float result = 0; \
    std::pair<mpfr_float, mpfr_float> dist_pair; \
    mpfr_float xqp1 = mpfr_float((mpfr_ptr)xqp); \
    switch (Target){ \
        case mp_const_dist_pdf: { result =  pdf(dist, xqp1); break;} \
        case mp_const_dist_cdf_P: { result =  cdf(dist, xqp1); break;} \
        case mp_const_dist_cdf_Q:  { result =   cdf(complement(dist, xqp1)); break;} \
        case mp_const_dist_Hazard: {result =  hazard(dist, xqp1); break;} \
        case mp_const_dist_CHF: {result =  chf(dist, xqp1); break;} \
        case mp_const_dist_Pinv: {result =  quantile(dist, xqp1); break;} \
        case mp_const_dist_Qinv: {result =  quantile(complement(dist, xqp1)); break;} \
        case mp_const_dist_Mean: {result =  mean(dist); break;} \
        case mp_const_dist_Median: {result =  median(dist); break;} \
        case mp_const_dist_Mode: {result =  mode(dist); break;} \
        case mp_const_dist_Variance: {result =  variance(dist); break;} \
        case mp_const_dist_Stdev: {result =  standard_deviation(dist); break;} \
        case mp_const_dist_Skewness: {result =  skewness(dist); break;} \
        case mp_const_dist_Kurtosis: {result =  kurtosis(dist); break;} \
        case mp_const_dist_KurtosisExcess: {result =  kurtosis_excess(dist); break;} \
        case mp_const_dist_support_left: {dist_pair = support(dist); result =  dist_pair.first; break;} \
        case mp_const_dist_support_right: {dist_pair = support(dist); result =  dist_pair.second; break;} \
        case mp_const_dist_range_left: {dist_pair = range(dist); result =  dist_pair.first; break;} \
        case mp_const_dist_range_right: {dist_pair = range(dist); result =  dist_pair.second; break;} \
        default: {result =  std::numeric_limits<double>::quiet_NaN(); break;} \
    }; \
	mpfr_set((mpfr_ptr)res, result.backend().data(), GMP_RNDN);





#include <boost/math/tools/minima.hpp>
#include <boost/math/tools/roots.hpp>
#include <boost/math/tools/agm.hpp>

#include <tuple> // for std::tuple and std::make_tuple.
#include <boost/math/constants/constants.hpp>
#include <boost/multiprecision/mpfr.hpp>
#include <boost/math/special_functions.hpp>
#include <boost/math/special_functions/logaddexp.hpp>

#include <boost/math/distributions.hpp>


#include <boost/math/quadrature/trapezoidal.hpp>
#include <boost/math/quadrature/gauss.hpp>
#include <boost/math/quadrature/gauss_kronrod.hpp>
#include <boost/math/quadrature/tanh_sinh.hpp>
#include <boost/math/quadrature/exp_sinh.hpp>
#include <boost/math/quadrature/sinh_sinh.hpp>
#include <boost/math/quadrature/ooura_fourier_integrals.hpp>

#include <boost/numeric/odeint.hpp>
#include "boost/numeric/odeint/external/eigen/eigen.hpp"
#include <Eigen/Dense>

#include <mp_BoostEigenConstants.h>


using namespace std;
using namespace boost::math;
using namespace boost::multiprecision;
using namespace boost::math::tools;
using boost::multiprecision::mpfr_float;

using boost::math::quadrature::trapezoidal;
using boost::math::quadrature::gauss;
using boost::math::quadrature::gauss_kronrod;
using boost::math::quadrature::tanh_sinh;
using boost::math::quadrature::sinh_sinh;
using boost::math::quadrature::exp_sinh;
using boost::math::quadrature::ooura_fourier_cos;
using boost::math::quadrature::ooura_fourier_sin;


using namespace Eigen;
typedef Matrix<mpfr_float, Dynamic, 1> state_type_vec;
typedef state_type_vec* mpVectorPtr;






//*********************** Boost Odeint **********************************

using namespace boost::numeric::odeint;

MpfrStatePtr LibMpfr_StateInit_Func_N(int N, int digits)
{
    mpfr_float::default_precision(digits);  // in decimal digits
    mpVectorPtr x = new(state_type_vec);
    (*x).resize(N);
    (*x).setZero();
    return x;
}


void LibMpfr_StateClear(MpfrStatePtr x)
{
    delete ((mpVectorPtr)x);
}


void LibMpfr_StateGetCoeff(MpfrPtr res, long row, MpfrStatePtr source, int digits)
{
    mpfr_float::default_precision(digits);  // in decimal digits
    mpfr_set((mpfr_ptr)res, (*(mpVectorPtr) source).coeff(row).backend().data(), GMP_RNDN);
}



void LibMpfr_StateSetCoeff(MpfrStatePtr result, MpfrPtr source, long row, int digits)
{
    mpfr_float::default_precision(digits);  // in decimal digits
    (*(mpVectorPtr) result)(row) = mpfr_float((mpfr_ptr)source);
}

void LibMpfr_StateGetSize(long *result, MpfrStatePtr x)
{
    *result = (long)(*(mpVectorPtr)x).size();
}





struct Boost_LibMpfr_Write
{
	Boost_LibMpfr_Write(MpfrAnyFuncPtr2 f1)
	{
		func1 = f1;
	}

	void operator()(const state_type_vec &x, const mpfr_float t)
	{
	    mpfr_float fx = t;
		func1(&x, &(fx.backend().data()));
	}
	MpfrAnyFuncPtr2 func1;
};


struct Boost_LibMpfr_Func_Vec
{
	Boost_LibMpfr_Func_Vec(MpfrAnyFuncPtr3 f1)
	{
		func1 = f1;
	}

	void operator()(const state_type_vec &x, state_type_vec &dxdt, mpfr_float t) const
	{
	    mpfr_float fx = t;
		func1(&x, &dxdt, &(fx.backend().data()));
	}
	MpfrAnyFuncPtr3 func1;
};




/* Constant steppers */

void LibMpfr_Const_RungeKutta4(MpfrAnyFuncPtr3 f1, MpfrAnyFuncPtr2 f2, MpfrStatePtr x, MpfrPtr start_time_, MpfrPtr end_time_, MpfrPtr dt_, int digits)
{
    mpfr_float::default_precision(digits);  // in decimal digits
    mpfr_float start_time = mpfr_float((mpfr_ptr)start_time_);
    mpfr_float end_time = mpfr_float((mpfr_ptr)end_time_);
    mpfr_float dt = mpfr_float((mpfr_ptr)dt_);
	integrate_const(runge_kutta4<state_type_vec, mpfr_float>(), Boost_LibMpfr_Func_Vec(f1),
		*(state_type_vec*)x, start_time, end_time, dt, Boost_LibMpfr_Write(f2));
}



void LibMpfr_Const_RungeKuttaCashKarp54(MpfrAnyFuncPtr3 f1, MpfrAnyFuncPtr2 f2, MpfrStatePtr x, MpfrPtr start_time_, MpfrPtr end_time_, MpfrPtr dt_, int digits)
{
    mpfr_float::default_precision(digits);  // in decimal digits
    mpfr_float start_time = mpfr_float((mpfr_ptr)start_time_);
    mpfr_float end_time = mpfr_float((mpfr_ptr)end_time_);
    mpfr_float dt = mpfr_float((mpfr_ptr)dt_);
	integrate_const(runge_kutta_cash_karp54<state_type_vec, mpfr_float>(), Boost_LibMpfr_Func_Vec(f1),
		*(state_type_vec*)x, start_time, end_time, dt, Boost_LibMpfr_Write(f2));
}



void LibMpfr_Const_RungeKuttaDopri5(MpfrAnyFuncPtr3 f1, MpfrAnyFuncPtr2 f2, MpfrStatePtr x, MpfrPtr start_time_, MpfrPtr end_time_, MpfrPtr dt_, int digits)
{
    mpfr_float::default_precision(digits);  // in decimal digits
    mpfr_float start_time = mpfr_float((mpfr_ptr)start_time_);
    mpfr_float end_time = mpfr_float((mpfr_ptr)end_time_);
    mpfr_float dt = mpfr_float((mpfr_ptr)dt_);
	integrate_const(runge_kutta_dopri5<state_type_vec, mpfr_float>(), Boost_LibMpfr_Func_Vec(f1),
		*(state_type_vec*)x, start_time, end_time, dt, Boost_LibMpfr_Write(f2));
}



void LibMpfr_Const_RungeKuttaFehlberg78(MpfrAnyFuncPtr3 f1, MpfrAnyFuncPtr2 f2, MpfrStatePtr x, MpfrPtr start_time_, MpfrPtr end_time_, MpfrPtr dt_, int digits)
{
    mpfr_float::default_precision(digits);  // in decimal digits
    mpfr_float start_time = mpfr_float((mpfr_ptr)start_time_);
    mpfr_float end_time = mpfr_float((mpfr_ptr)end_time_);
    mpfr_float dt = mpfr_float((mpfr_ptr)dt_);
	integrate_const(runge_kutta_fehlberg78<state_type_vec, mpfr_float>(), Boost_LibMpfr_Func_Vec(f1),
		*(state_type_vec*)x, start_time, end_time, dt, Boost_LibMpfr_Write(f2));
}



void LibMpfr_Const_AdamsBashforthMoulton(MpfrAnyFuncPtr3 f1, MpfrAnyFuncPtr2 f2, MpfrStatePtr x, MpfrPtr start_time_, MpfrPtr end_time_, MpfrPtr dt_, int digits)
{
    mpfr_float::default_precision(digits);  // in decimal digits
    mpfr_float start_time = mpfr_float((mpfr_ptr)start_time_);
    mpfr_float end_time = mpfr_float((mpfr_ptr)end_time_);
    mpfr_float dt = mpfr_float((mpfr_ptr)dt_);
	integrate_const(adams_bashforth_moulton<5, state_type_vec, mpfr_float>(), Boost_LibMpfr_Func_Vec(f1),
		*(state_type_vec*)x, start_time, end_time, dt, Boost_LibMpfr_Write(f2));
}



/* Adaptive steppers */

void LibMpfr_Adaptive_RungeKuttaDopri5(MpfrAnyFuncPtr3 f1, MpfrAnyFuncPtr2 f2, MpfrStatePtr x, MpfrPtr start_time_, MpfrPtr end_time_, MpfrPtr dt_, MpfrPtr eps_abs_, MpfrPtr eps_rel_, int digits)
{
    mpfr_float::default_precision(digits);  // in decimal digits
    mpfr_float start_time = mpfr_float((mpfr_ptr)start_time_);
    mpfr_float end_time = mpfr_float((mpfr_ptr)end_time_);
    mpfr_float dt = mpfr_float((mpfr_ptr)dt_);
    mpfr_float eps_abs = mpfr_float((mpfr_ptr)eps_abs_);
    mpfr_float eps_rel = mpfr_float((mpfr_ptr)eps_rel_);

    integrate_adaptive( make_controlled( eps_abs , eps_rel , runge_kutta_dopri5<state_type_vec, mpfr_float>() ),
        Boost_LibMpfr_Func_Vec(f1), *(state_type_vec*)x, start_time , end_time , dt , Boost_LibMpfr_Write(f2));
}


void LibMpfr_Adaptive_RungeKuttaCashKarp54(MpfrAnyFuncPtr3 f1, MpfrAnyFuncPtr2 f2, MpfrStatePtr x, MpfrPtr start_time_, MpfrPtr end_time_, MpfrPtr dt_, MpfrPtr eps_abs_, MpfrPtr eps_rel_, int digits)
{
    mpfr_float::default_precision(digits);  // in decimal digits
    mpfr_float start_time = mpfr_float((mpfr_ptr)start_time_);
    mpfr_float end_time = mpfr_float((mpfr_ptr)end_time_);
    mpfr_float dt = mpfr_float((mpfr_ptr)dt_);
    mpfr_float eps_abs = mpfr_float((mpfr_ptr)eps_abs_);
    mpfr_float eps_rel = mpfr_float((mpfr_ptr)eps_rel_);

    integrate_adaptive( make_controlled( eps_abs , eps_rel , runge_kutta_cash_karp54<state_type_vec, mpfr_float>() ),
        Boost_LibMpfr_Func_Vec(f1), *(state_type_vec*)x, start_time , end_time , dt , Boost_LibMpfr_Write(f2));
}


void LibMpfr_Adaptive_RungeKuttaFehlberg78(MpfrAnyFuncPtr3 f1, MpfrAnyFuncPtr2 f2, MpfrStatePtr x, MpfrPtr start_time_, MpfrPtr end_time_, MpfrPtr dt_, MpfrPtr eps_abs_, MpfrPtr eps_rel_, int digits)
{
    mpfr_float::default_precision(digits);  // in decimal digits
    mpfr_float start_time = mpfr_float((mpfr_ptr)start_time_);
    mpfr_float end_time = mpfr_float((mpfr_ptr)end_time_);
    mpfr_float dt = mpfr_float((mpfr_ptr)dt_);
    mpfr_float eps_abs = mpfr_float((mpfr_ptr)eps_abs_);
    mpfr_float eps_rel = mpfr_float((mpfr_ptr)eps_rel_);

    integrate_adaptive( make_controlled( eps_abs , eps_rel , runge_kutta_fehlberg78<state_type_vec, mpfr_float>() ),
        Boost_LibMpfr_Func_Vec(f1), *(state_type_vec*)x, start_time , end_time , dt , Boost_LibMpfr_Write(f2));
}


void LibMpfr_Adaptive_BulirschStoer(MpfrAnyFuncPtr3 f1, MpfrAnyFuncPtr2 f2, MpfrStatePtr x, MpfrPtr start_time_, MpfrPtr end_time_, MpfrPtr dt_, MpfrPtr eps_abs_, MpfrPtr eps_rel_, int digits)
{
    mpfr_float::default_precision(digits);  // in decimal digits
    mpfr_float start_time = mpfr_float((mpfr_ptr)start_time_);
    mpfr_float end_time = mpfr_float((mpfr_ptr)end_time_);
    mpfr_float dt = mpfr_float((mpfr_ptr)dt_);
    mpfr_float eps_abs = mpfr_float((mpfr_ptr)eps_abs_);
    mpfr_float eps_rel = mpfr_float((mpfr_ptr)eps_rel_);

	bulirsch_stoer< state_type_vec, mpfr_float > stepper( eps_abs , eps_rel , 0.0 , 0.0 );
    integrate_adaptive( stepper, Boost_LibMpfr_Func_Vec(f1),
        *(state_type_vec*)x, start_time, end_time, dt, Boost_LibMpfr_Write(f2));
}

/* Dense Output steppers */


void LibMpfr_DenseOutput_Dopri5(MpfrAnyFuncPtr3 f1, MpfrAnyFuncPtr2 f2, MpfrStatePtr x, MpfrPtr start_time_, MpfrPtr end_time_, MpfrPtr dt_, MpfrPtr eps_abs_, MpfrPtr eps_rel_, int digits)
{
    mpfr_float::default_precision(digits);  // in decimal digits
    mpfr_float start_time = mpfr_float((mpfr_ptr)start_time_);
    mpfr_float end_time = mpfr_float((mpfr_ptr)end_time_);
    mpfr_float dt = mpfr_float((mpfr_ptr)dt_);
    mpfr_float eps_abs = mpfr_float((mpfr_ptr)eps_abs_);
    mpfr_float eps_rel = mpfr_float((mpfr_ptr)eps_rel_);

    typedef runge_kutta_dopri5< state_type_vec, mpfr_float > dopri5_type;
    typedef controlled_runge_kutta< dopri5_type > controlled_dopri5_type;
    typedef dense_output_runge_kutta< controlled_dopri5_type > dense_output_dopri5_type;
    dense_output_dopri5_type dopri5 = make_dense_output( eps_abs , eps_rel , dopri5_type() );
    integrate_adaptive( dopri5, Boost_LibMpfr_Func_Vec(f1),
        *(state_type_vec*)x, start_time, end_time, dt, Boost_LibMpfr_Write(f2));
}


void LibMpfr_DenseOutput_BulirschStoer(MpfrAnyFuncPtr3 f1, MpfrAnyFuncPtr2 f2, MpfrStatePtr x, MpfrPtr start_time_, MpfrPtr end_time_, MpfrPtr dt_, MpfrPtr eps_abs_, MpfrPtr eps_rel_, int digits)
{
    mpfr_float::default_precision(digits);  // in decimal digits
    mpfr_float start_time = mpfr_float((mpfr_ptr)start_time_);
    mpfr_float end_time = mpfr_float((mpfr_ptr)end_time_);
    mpfr_float dt = mpfr_float((mpfr_ptr)dt_);
    mpfr_float eps_abs = mpfr_float((mpfr_ptr)eps_abs_);
    mpfr_float eps_rel = mpfr_float((mpfr_ptr)eps_rel_);

	bulirsch_stoer_dense_out< state_type_vec, mpfr_float > stepper( eps_abs , eps_rel , 0.0 , 0.0 );
    integrate_adaptive( stepper, Boost_LibMpfr_Func_Vec(f1),
        *(state_type_vec*)x, start_time, end_time, dt, Boost_LibMpfr_Write(f2));
}






//*********************** Boost Numerical Calculus, Mpfr **********************************



struct MpfrFunctor1
{
  MpfrFunctor1(MpfrFuncPtr f1):func1(f1) {}
  mpfr_float operator()(mpfr_float x)
  {
    mpfr_float fx;
	func1( &(x.backend().data()), &(fx.backend().data()));
    return fx;
  }
private:
	MpfrFuncPtr func1;
};


struct MpfrFunctor2
{
  MpfrFunctor2(MpfrFuncPtr f1, MpfrFuncPtr f2):func1(f1), func2(f2) {}
  std::pair<mpfr_float, mpfr_float> operator()(mpfr_float x)
  {
    mpfr_float fx, dx;
	func1( &(x.backend().data()), &(fx.backend().data()));
	func2( &(x.backend().data()), &(dx.backend().data()));
    return std::make_pair(fx, dx);
  }
private:
	MpfrFuncPtr func1, func2;
};


struct MpfrFunctor3
{
  MpfrFunctor3(MpfrFuncPtr f1, MpfrFuncPtr f2, MpfrFuncPtr f3):func1(f1), func2(f2), func3(f3) {}
  std::tuple<mpfr_float, mpfr_float, mpfr_float> operator()(mpfr_float x)
  {
    mpfr_float fx, dx, d2x;
	func1( &(x.backend().data()), &(fx.backend().data()));
	func2( &(x.backend().data()), &(dx.backend().data()));
	func3( &(x.backend().data()), &(d2x.backend().data()));
    return std::make_tuple(fx, dx, d2x);
  }
private:
	MpfrFuncPtr func1, func2, func3;
};





void LibMpfr_BracketRoot(MpfrPtr res1, MpfrPtr res2, int* iter, MpfrFuncPtr f1, MpfrPtr guess_, MpfrPtr factor_, bool is_rising, int get_digits, unsigned int maxit)
{
    mpfr_float::default_precision(get_digits);  // in decimal digits
    mpfr_float guess = mpfr_float((mpfr_ptr)guess_);
    mpfr_float factor = mpfr_float((mpfr_ptr)factor_);
	uintmax_t it = maxit;
	eps_tolerance<mpfr_float> tol(get_digits*333/100);  // in decimal digits
	std::pair<mpfr_float, mpfr_float> r = bracket_and_solve_root(MpfrFunctor1(f1), guess, factor, is_rising, tol, it);
	mpfr_float error = (r.second - r.first) / 2;
	mpfr_float result = r.first + error;
	mpfr_set((mpfr_ptr)res1, result.backend().data(), GMP_RNDN);
	mpfr_set((mpfr_ptr)res2, error.backend().data(), GMP_RNDN);
    *iter = (int) it;
}



void LibMpfr_NewtonRaphson(MpfrPtr res,  int* iter, MpfrFuncPtr f1, MpfrFuncPtr f2, MpfrPtr guess_, MpfrPtr xmin_, MpfrPtr xmax_, int get_digits, unsigned int maxit)
{
    mpfr_float::default_precision(get_digits);  // in decimal digits
    mpfr_float guess = mpfr_float((mpfr_ptr)guess_);
    mpfr_float xmin = mpfr_float((mpfr_ptr)xmin_);
    mpfr_float xmax = mpfr_float((mpfr_ptr)xmax_);
    uintmax_t it = maxit;
    mpfr_float result = newton_raphson_iterate(MpfrFunctor2(f1, f2), guess, xmin, xmax, get_digits*333/100, it);
	mpfr_set((mpfr_ptr)res, result.backend().data(), GMP_RNDN);
    *iter = (int) it;
}



void LibMpfr_Halley(MpfrPtr res, int* iter, MpfrFuncPtr f1, MpfrFuncPtr f2, MpfrFuncPtr f3, MpfrPtr guess_, MpfrPtr xmin_, MpfrPtr xmax_, int get_digits, unsigned int maxit)
{
    mpfr_float::default_precision(get_digits);  // in decimal digits
    mpfr_float guess = mpfr_float((mpfr_ptr)guess_);
    mpfr_float xmin = mpfr_float((mpfr_ptr)xmin_);
    mpfr_float xmax = mpfr_float((mpfr_ptr)xmax_);
    uintmax_t it = maxit;
    mpfr_float result = halley_iterate(MpfrFunctor3(f1, f2, f3), guess, xmin, xmax, get_digits*333/100, it);
	mpfr_set((mpfr_ptr)res, result.backend().data(), GMP_RNDN);
    *iter = (int) it;
}



void LibMpfr_Schroder(MpfrPtr res, int* iter, MpfrFuncPtr f1, MpfrFuncPtr f2, MpfrFuncPtr f3, MpfrPtr guess_, MpfrPtr xmin_, MpfrPtr xmax_, int get_digits, unsigned int maxit)
{
    mpfr_float::default_precision(get_digits);  // in decimal digits
    mpfr_float guess = mpfr_float((mpfr_ptr)guess_);
    mpfr_float xmin = mpfr_float((mpfr_ptr)xmin_);
    mpfr_float xmax = mpfr_float((mpfr_ptr)xmax_);
    uintmax_t it = maxit;
    mpfr_float result = schroder_iterate(MpfrFunctor3(f1, f2, f3), guess, xmin, xmax, get_digits*333/100, it);
	mpfr_set((mpfr_ptr)res, result.backend().data(), GMP_RNDN);
    *iter = (int) it;
}


void LibMpfr_Brent_Minimum(MpfrPtr res, MpfrPtr resFx, int* iter, MpfrFuncPtr f1, MpfrPtr bracket_min_, MpfrPtr bracket_max_, int get_digits, unsigned int maxit)
{
    mpfr_float::default_precision(2*get_digits);  // in decimal digits
    mpfr_float bracket_min = mpfr_float((mpfr_ptr)bracket_min_);
    mpfr_float bracket_max = mpfr_float((mpfr_ptr)bracket_max_);
    uintmax_t it = maxit;
    std::pair<mpfr_float, mpfr_float> r = brent_find_minima(MpfrFunctor1(f1), bracket_min, bracket_max, 2*get_digits * 333/100, it);
	mpfr_set((mpfr_ptr)res, r.first.backend().data(), GMP_RNDN);
	mpfr_set((mpfr_ptr)resFx, r.second.backend().data(), GMP_RNDN);
    *iter = (int) it;
}





void LibMpfr_Trapezoidal(MpfrPtr res1, MpfrPtr res2, MpfrPtr res3, MpfrFuncPtr f1, MpfrPtr a_, MpfrPtr b_, int get_digits)
{
    mpfr_float::default_precision(get_digits);  // in decimal digits
    mpfr_float a = mpfr_float((mpfr_ptr)a_);
    mpfr_float b = mpfr_float((mpfr_ptr)b_);
    mpfr_float tol = sqrt(std::numeric_limits<mpfr_float>::epsilon());
    mpfr_float error;
    mpfr_float L1;
    size_t max_refinements = 24;
    auto f = [&f1](mpfr_float x) {
        mpfr_float fx;
        f1( &(x.backend().data()), &(fx.backend().data()));
        return fx;
        };
    mpfr_float result = trapezoidal(f, a, b, tol, max_refinements, &error, &L1);
    mpfr_float T1 =  L1/fabs(result);
	mpfr_set((mpfr_ptr)res1, result.backend().data(), GMP_RNDN);
	mpfr_set((mpfr_ptr)res2, error.backend().data(), GMP_RNDN);
	mpfr_set((mpfr_ptr)res3, T1.backend().data(), GMP_RNDN);
}



// 7, 15, 20, 25 and 30

void LibMpfr_GaussLegendre(MpfrPtr res1, MpfrPtr res3, MpfrFuncPtr f1, MpfrPtr a_, MpfrPtr b_, int get_digits)
{
    mpfr_float::default_precision(get_digits);  // in decimal digits
    mpfr_float a = mpfr_float((mpfr_ptr)a_);
    mpfr_float b = mpfr_float((mpfr_ptr)b_);
    mpfr_float L1;
    auto f = [&f1](mpfr_float x) {
        mpfr_float fx;
        f1( &(x.backend().data()), &(fx.backend().data()));
        return fx;
        };
    mpfr_float result = gauss<mpfr_float, 7>::integrate(f, a, b, &L1);
    mpfr_float T1 =  L1/fabs(result);
	mpfr_set((mpfr_ptr)res1, result.backend().data(), GMP_RNDN);
	mpfr_set((mpfr_ptr)res3, T1.backend().data(), GMP_RNDN);
}



//15, 31, 41, 51 and 61

void LibMpfr_GaussKronrod(MpfrPtr res1, MpfrPtr res2, MpfrPtr res3, MpfrFuncPtr f1, MpfrPtr a_, MpfrPtr b_, int get_digits)
{
    mpfr_float::default_precision(get_digits);  // in decimal digits
    mpfr_float a = mpfr_float((mpfr_ptr)a_);
    mpfr_float b = mpfr_float((mpfr_ptr)b_);
    mpfr_float tol = sqrt(std::numeric_limits<mpfr_float>::epsilon());
    mpfr_float error;
    mpfr_float L1;
    unsigned max_depth = 15;
    auto f = [&f1](mpfr_float x) {
        mpfr_float fx;
        f1( &(x.backend().data()), &(fx.backend().data()));
        return fx;
        };
    mpfr_float result = gauss_kronrod<mpfr_float, 15>::integrate(f, a, b, max_depth, tol, &error, &L1);
    mpfr_float T1 =  L1/fabs(result);
	mpfr_set((mpfr_ptr)res1, result.backend().data(), GMP_RNDN);
	mpfr_set((mpfr_ptr)res2, error.backend().data(), GMP_RNDN);
	mpfr_set((mpfr_ptr)res3, T1.backend().data(), GMP_RNDN);
}



void LibMpfr_TanhSinh(MpfrPtr res1, MpfrPtr res2, MpfrPtr res3, int* levels_, MpfrFuncPtr f1, MpfrPtr a_, MpfrPtr b_, int get_digits)
{
    mpfr_float::default_precision(get_digits);  // in decimal digits
    mpfr_float a = mpfr_float((mpfr_ptr)a_);
    mpfr_float b = mpfr_float((mpfr_ptr)b_);
    tanh_sinh<mpfr_float> integrator;
    auto f = [&f1](mpfr_float x) {
        mpfr_float fx;
        f1( &(x.backend().data()), &(fx.backend().data()));
        return fx;
        };
    mpfr_float termination = sqrt(std::numeric_limits<mpfr_float>::epsilon());
    mpfr_float  error;
    mpfr_float  L1;
    std::size_t levels = 0;
    mpfr_float result = integrator.integrate(f, a, b, termination, &error, &L1, &levels);
    mpfr_float T1 =  L1/fabs(result);
	mpfr_set((mpfr_ptr)res1, result.backend().data(), GMP_RNDN);
	mpfr_set((mpfr_ptr)res2, error.backend().data(), GMP_RNDN);
	mpfr_set((mpfr_ptr)res3, T1.backend().data(), GMP_RNDN);
    *levels_ = (int) levels;
}




void LibMpfr_SinhSinh(MpfrPtr res1, MpfrPtr res2, MpfrPtr res3, int* levels_, MpfrFuncPtr f1, int get_digits)
{
    mpfr_float::default_precision(get_digits);  // in decimal digits
    sinh_sinh<mpfr_float> integrator;
    auto f = [&f1](mpfr_float x) {
        mpfr_float fx;
        f1( &(x.backend().data()), &(fx.backend().data()));
        return fx;
        };
    mpfr_float termination = sqrt(std::numeric_limits<mpfr_float>::epsilon());
    mpfr_float  error;
    mpfr_float  L1;
    std::size_t levels = 0;
    mpfr_float result = integrator.integrate(f, termination, &error, &L1, &levels);
    mpfr_float T1 =  L1/fabs(result);
	mpfr_set((mpfr_ptr)res1, result.backend().data(), GMP_RNDN);
	mpfr_set((mpfr_ptr)res2, error.backend().data(), GMP_RNDN);
	mpfr_set((mpfr_ptr)res3, T1.backend().data(), GMP_RNDN);
    *levels_ = (int) levels;
}



void LibMpfr_ExpSinh(MpfrPtr res1, MpfrPtr res2, MpfrPtr res3, int* levels_, MpfrFuncPtr f1, int get_digits)
{
    mpfr_float::default_precision(get_digits);  // in decimal digits
    exp_sinh<mpfr_float> integrator;
    auto f = [&f1](mpfr_float x) {
        mpfr_float fx;
        f1( &(x.backend().data()), &(fx.backend().data()));
        return fx;
        };
    mpfr_float termination = sqrt(std::numeric_limits<mpfr_float>::epsilon());
    mpfr_float  error;
    mpfr_float  L1;
    std::size_t levels = 0;
    mpfr_float result = integrator.integrate(f, termination, &error, &L1, &levels);
    mpfr_float T1 =  L1/fabs(result);
	mpfr_set((mpfr_ptr)res1, result.backend().data(), GMP_RNDN);
	mpfr_set((mpfr_ptr)res2, error.backend().data(), GMP_RNDN);
	mpfr_set((mpfr_ptr)res3, T1.backend().data(), GMP_RNDN);
    *levels_ = (int) levels;
}



void LibMpfr_Ooura_Cos(MpfrPtr res1, MpfrPtr res2, MpfrFuncPtr f1, int get_digits)
{
    mpfr_float::default_precision(get_digits);  // in decimal digits
    mpfr_float omega = 1;
    mpfr_float tol = 2 * sqrt(std::numeric_limits<mpfr_float>::epsilon());
	auto integrator = ooura_fourier_cos<mpfr_float>(tol, 8); // Loops or gets worse for more than 8.
    auto f = [&f1](mpfr_float x) {
        mpfr_float fx;
        f1( &(x.backend().data()), &(fx.backend().data()));
        return fx;
        };
	std::pair<mpfr_float, mpfr_float> r = integrator.integrate(f, omega);
	mpfr_set((mpfr_ptr)res1, r.first.backend().data(), GMP_RNDN);
	mpfr_set((mpfr_ptr)res2, r.second.backend().data(), GMP_RNDN);
}



void LibMpfr_Ooura_Sin(MpfrPtr res1, MpfrPtr res2, MpfrFuncPtr f1, int get_digits)
{
    mpfr_float::default_precision(get_digits);  // in decimal digits
    mpfr_float omega = 1;
    mpfr_float tol = 2 * sqrt(std::numeric_limits<mpfr_float>::epsilon());
	auto integrator = ooura_fourier_sin<mpfr_float>(tol, 8); // Loops or gets worse for more than 8.
    auto f = [&f1](mpfr_float x) {
        mpfr_float fx;
        f1( &(x.backend().data()), &(fx.backend().data()));
        return fx;
        };
	std::pair<mpfr_float, mpfr_float> r = integrator.integrate(f, omega);
	mpfr_set((mpfr_ptr)res1, r.first.backend().data(), GMP_RNDN);
	mpfr_set((mpfr_ptr)res2, r.second.backend().data(), GMP_RNDN);
}




//***********************  Boost Distributions, Mpfr  **********************************


void LibMpfr_ArcsineDist(long Target, MpfrPtr res, MpfrPtr xqp, MpfrPtr a, MpfrPtr b, int dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
    mpfr_float a1 = mpfr_float((mpfr_ptr)a);
    mpfr_float b1 = mpfr_float((mpfr_ptr)b);
    arcsine_distribution<mpfr_float> dist(a1, b1); MP_DIST_RETURN
}



void LibMpfr_BernoulliDist(long Target, MpfrPtr res, MpfrPtr xqp, MpfrPtr p, int dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
    mpfr_float p1 = mpfr_float((mpfr_ptr)p);
    bernoulli_distribution<mpfr_float> dist(p1); MP_DIST_RETURN
}



void LibMpfr_BetaDist(long Target, MpfrPtr res, MpfrPtr xqp, MpfrPtr a, MpfrPtr b, int dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
    mpfr_float a1 = mpfr_float((mpfr_ptr)a);
    mpfr_float b1 = mpfr_float((mpfr_ptr)b);
    beta_distribution<mpfr_float> dist(a1, b1); MP_DIST_RETURN
}



void LibMpfr_BinomialDist(long Target, MpfrPtr res, MpfrPtr xqp, MpfrPtr n, MpfrPtr p, int dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
    mpfr_float n1 = mpfr_float((mpfr_ptr)n);
    mpfr_float p1 = mpfr_float((mpfr_ptr)p);
    binomial_distribution<mpfr_float> dist(n1, p1); MP_DIST_RETURN
}



void LibMpfr_CauchyDist(long Target, MpfrPtr res, MpfrPtr xqp, MpfrPtr location, MpfrPtr scale, int dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
    mpfr_float location1 = mpfr_float((mpfr_ptr)location);
    mpfr_float scale1 = mpfr_float((mpfr_ptr)scale);
    cauchy_distribution<mpfr_float> dist(location1, scale1); MP_DIST_RETURN
}



void LibMpfr_Chi2Dist(long Target, MpfrPtr res, MpfrPtr xqp, MpfrPtr nu, int dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
    mpfr_float nu1 = mpfr_float((mpfr_ptr)nu);
    chi_squared_distribution<mpfr_float> dist(nu1); MP_DIST_RETURN
}



void LibMpfr_ExponentialDist(long Target, MpfrPtr res, MpfrPtr xqp, MpfrPtr lambda, int dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
    mpfr_float lambda1 = mpfr_float((mpfr_ptr)lambda);
    exponential_distribution<mpfr_float> dist(lambda1); MP_DIST_RETURN
}



void LibMpfr_ExtremeValueDist(long Target, MpfrPtr res, MpfrPtr xqp, MpfrPtr location, MpfrPtr scale, int dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
    mpfr_float location1 = mpfr_float((mpfr_ptr)location);
    mpfr_float scale1 = mpfr_float((mpfr_ptr)scale);
    extreme_value_distribution<mpfr_float> dist(location1, scale1); MP_DIST_RETURN
}



void LibMpfr_FisherFDist(long Target, MpfrPtr res, MpfrPtr xqp, MpfrPtr mu, MpfrPtr nu, int dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
    mpfr_float mu1 = mpfr_float((mpfr_ptr)mu);
    mpfr_float nu1 = mpfr_float((mpfr_ptr)nu);
    fisher_f_distribution<mpfr_float> dist(mu1, nu1); MP_DIST_RETURN
}



void LibMpfr_GammaDist(long Target, MpfrPtr res, MpfrPtr xqp, MpfrPtr shape, MpfrPtr scale, int dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
    mpfr_float shape1 = mpfr_float((mpfr_ptr)shape);
    mpfr_float scale1 = mpfr_float((mpfr_ptr)scale);
    gamma_distribution<mpfr_float> dist(shape1, scale1); MP_DIST_RETURN
}



void LibMpfr_GeometricDist(long Target, MpfrPtr res, MpfrPtr xqp, MpfrPtr p, int dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
    mpfr_float p1 = mpfr_float((mpfr_ptr)p);
    geometric_distribution<mpfr_float> dist(p1); MP_DIST_RETURN
}



void LibMpfr_HypergeometricDist(long Target, MpfrPtr res, MpfrPtr xqp, unsigned r, unsigned n, unsigned N, int dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
    hypergeometric_distribution<mpfr_float> dist(r, n, N); MP_DIST_RETURN
}



void LibMpfr_InverseChi2Dist(long Target, MpfrPtr res, MpfrPtr xqp, MpfrPtr df, MpfrPtr scale, int dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
    mpfr_float df1 = mpfr_float((mpfr_ptr)df);
    mpfr_float scale1 = mpfr_float((mpfr_ptr)scale);
    inverse_chi_squared_distribution<mpfr_float> dist(df1, scale1); MP_DIST_RETURN
}



void LibMpfr_InverseGammaDist(long Target, MpfrPtr res, MpfrPtr xqp, MpfrPtr shape, MpfrPtr scale, int dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
    mpfr_float shape1 = mpfr_float((mpfr_ptr)shape);
    mpfr_float scale1 = mpfr_float((mpfr_ptr)scale);
    inverse_gamma_distribution<mpfr_float> dist(shape1, scale1); MP_DIST_RETURN
}



void LibMpfr_InverseGaussianDist(long Target, MpfrPtr res, MpfrPtr xqp, MpfrPtr mean_, MpfrPtr scale, int dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
    mpfr_float mean1 = mpfr_float((mpfr_ptr)mean_);
    mpfr_float scale1 = mpfr_float((mpfr_ptr)scale);
    inverse_gaussian_distribution<mpfr_float> dist(mean1, scale1); MP_DIST_RETURN
}



void LibMpfr_LaplaceDist(long Target, MpfrPtr res, MpfrPtr xqp, MpfrPtr location, MpfrPtr scale, int dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
    mpfr_float location1 = mpfr_float((mpfr_ptr)location);
    mpfr_float scale1 = mpfr_float((mpfr_ptr)scale);
    laplace_distribution<mpfr_float> dist(location1, scale1); MP_DIST_RETURN
}



void LibMpfr_LogisticDist(long Target, MpfrPtr res, MpfrPtr xqp, MpfrPtr location, MpfrPtr scale, int dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
    mpfr_float location1 = mpfr_float((mpfr_ptr)location);
    mpfr_float scale1 = mpfr_float((mpfr_ptr)scale);
    logistic_distribution<mpfr_float> dist(location1, scale1); MP_DIST_RETURN
}



void LibMpfr_LognormalDist(long Target, MpfrPtr res, MpfrPtr xqp, MpfrPtr location, MpfrPtr scale, int dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
    mpfr_float location1 = mpfr_float((mpfr_ptr)location);
    mpfr_float scale1 = mpfr_float((mpfr_ptr)scale);
    lognormal_distribution<mpfr_float> dist(location1, scale1); MP_DIST_RETURN
}



void LibMpfr_NegBinomialDist(long Target, MpfrPtr res, MpfrPtr xqp, MpfrPtr n, MpfrPtr p, int dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
    mpfr_float n1 = mpfr_float((mpfr_ptr)n);
    mpfr_float p1 = mpfr_float((mpfr_ptr)p);
    negative_binomial_distribution<mpfr_float> dist(n1, p1); MP_DIST_RETURN
}


void LibMpfr_Chi2NCDist(long Target, MpfrPtr res, MpfrPtr xqp, MpfrPtr nu, MpfrPtr nc, int dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
    mpfr_float nu1 = mpfr_float((mpfr_ptr)nu);
    mpfr_float nc1 = mpfr_float((mpfr_ptr)nc);
    non_central_chi_squared_distribution<mpfr_float> dist(nu1, nc1); MP_DIST_RETURN
}


void LibMpfr_StudentTNCDist(long Target, MpfrPtr res, MpfrPtr xqp, MpfrPtr nu, MpfrPtr delta, int dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
    mpfr_float nu1 = mpfr_float((mpfr_ptr)nu);
    mpfr_float delta1 = mpfr_float((mpfr_ptr)delta);
    non_central_t_distribution<mpfr_float> dist(nu1, delta1); MP_DIST_RETURN
}



void LibMpfr_FisherNCDist(long Target, MpfrPtr res, MpfrPtr xqp, MpfrPtr mu, MpfrPtr nu, MpfrPtr nc, int dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
    mpfr_float mu1 = mpfr_float((mpfr_ptr)mu);
    mpfr_float nu1 = mpfr_float((mpfr_ptr)nu);
    mpfr_float nc1 = mpfr_float((mpfr_ptr)nc);
    non_central_f_distribution<mpfr_float> dist(mu1, nu1, nc1); MP_DIST_RETURN
}



void LibMpfr_BetaNCDist(long Target, MpfrPtr res, MpfrPtr xqp, MpfrPtr a, MpfrPtr b, MpfrPtr nc, int dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
    mpfr_float a1 = mpfr_float((mpfr_ptr)a);
    mpfr_float b1 = mpfr_float((mpfr_ptr)b);
    mpfr_float nc1 = mpfr_float((mpfr_ptr)nc);
    non_central_beta_distribution<mpfr_float> dist(a1, b1, nc1); MP_DIST_RETURN
}



void LibMpfr_NormalDist(long Target, MpfrPtr res, MpfrPtr xqp, MpfrPtr mean_, MpfrPtr stdev, int dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
    mpfr_float mean1 = mpfr_float((mpfr_ptr)mean_);
    mpfr_float stdev1 = mpfr_float((mpfr_ptr)stdev);
    normal_distribution<mpfr_float> dist(mean1, stdev1); MP_DIST_RETURN
}



void LibMpfr_ParetoDist(long Target, MpfrPtr res, MpfrPtr xqp, MpfrPtr shape, MpfrPtr scale, int dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
    mpfr_float shape1 = mpfr_float((mpfr_ptr)shape);
    mpfr_float scale1 = mpfr_float((mpfr_ptr)scale);
    pareto_distribution<mpfr_float> dist(shape1, scale1); MP_DIST_RETURN
}



void LibMpfr_PoissonDist(long Target, MpfrPtr res, MpfrPtr xqp, MpfrPtr nu, int dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
    mpfr_float nu1 = mpfr_float((mpfr_ptr)nu);
    poisson_distribution<mpfr_float> dist(nu1); MP_DIST_RETURN
}



void LibMpfr_RayleighDist(long Target, MpfrPtr res, MpfrPtr xqp, MpfrPtr nu, int dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
    mpfr_float nu1 = mpfr_float((mpfr_ptr)nu);
    rayleigh_distribution<mpfr_float> dist(nu1); MP_DIST_RETURN
}



void LibMpfr_SkewNormalDist(long Target, MpfrPtr res, MpfrPtr xqp, MpfrPtr mean_, MpfrPtr scale, MpfrPtr shape, int dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
    mpfr_float mean1 = mpfr_float((mpfr_ptr)mean_);
    mpfr_float shape1 = mpfr_float((mpfr_ptr)shape);
    mpfr_float scale1 = mpfr_float((mpfr_ptr)scale);
    skew_normal_distribution<mpfr_float> dist(mean1, scale1, shape1); MP_DIST_RETURN
}



void LibMpfr_StudentTDist(long Target, MpfrPtr res, MpfrPtr xqp, MpfrPtr nu, int dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
    mpfr_float nu1 = mpfr_float((mpfr_ptr)nu);
    students_t_distribution<mpfr_float> dist(nu1); MP_DIST_RETURN
}



void LibMpfr_TriangularDist(long Target, MpfrPtr res, MpfrPtr xqp, MpfrPtr lower, MpfrPtr mode_, MpfrPtr upper, int dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
    mpfr_float lower1 = mpfr_float((mpfr_ptr)lower);
    mpfr_float mode1 = mpfr_float((mpfr_ptr)mode_);
    mpfr_float upper1 = mpfr_float((mpfr_ptr)upper);
    triangular_distribution<mpfr_float> dist(lower1, mode1, upper1); MP_DIST_RETURN
}



void LibMpfr_WeibullDist(long Target, MpfrPtr res, MpfrPtr xqp, MpfrPtr shape, MpfrPtr scale, int dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
    mpfr_float shape1 = mpfr_float((mpfr_ptr)shape);
    mpfr_float scale1 = mpfr_float((mpfr_ptr)scale);
    weibull_distribution<mpfr_float> dist(shape1, scale1); MP_DIST_RETURN
}



void LibMpfr_UniformDist(long Target, MpfrPtr res, MpfrPtr xqp, MpfrPtr lower, MpfrPtr upper, int dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
    mpfr_float lower1 = mpfr_float((mpfr_ptr)lower);
    mpfr_float upper1 = mpfr_float((mpfr_ptr)upper);
    uniform_distribution<mpfr_float> dist(lower1, upper1); MP_DIST_RETURN
}



//*********************** New , octuple precision **********************************



void LibMpfr_Logaddexp(MpfrPtr res, const MpfrPtr a, const MpfrPtr b, const int dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
	mpfr_float result = logaddexp( mpfr_float((mpfr_ptr)a), mpfr_float((mpfr_ptr)b) );
    mpfr_set((mpfr_ptr)res, result.backend().data(), GMP_RNDN);
}



void LibMpfr_KolmogorovSmirnovDist(long Target, MpfrPtr res, MpfrPtr xqp, MpfrPtr nu, int dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
    mpfr_float nu1 = mpfr_float((mpfr_ptr)nu);
    kolmogorov_smirnov_distribution<mpfr_float> dist(nu1); MP_DIST_RETURN
}



void LibMpfr_HyperexponentialDist(long Target, MpfrPtr res, MpfrPtr xqp, MpfrStatePtr l1, MpfrStatePtr l2, int dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
    hyperexponential_distribution<mpfr_float> dist( *(state_type_vec*) l1, *(state_type_vec*) l2); MP_DIST_RETURN
}











//*********************** Boost Special functions , Mpfr **********************************


void LibMpfr_BernoulliB2n(MpfrPtr res, const int n, int const dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
	mpfr_float result = bernoulli_b2n<mpfr_float>(n);
    mpfr_set((mpfr_ptr)res, result.backend().data(), GMP_RNDN);
}


void LibMpfr_TangentT2n(MpfrPtr res, const int n, int const dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
	mpfr_float result = tangent_t2n<mpfr_float>(n);
    mpfr_set((mpfr_ptr)res, result.backend().data(), GMP_RNDN);
}



void LibMpfr_Sqrt1pm1(MpfrPtr res, const MpfrPtr x, int const dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
	mpfr_float result = sqrt1pm1( mpfr_float((mpfr_ptr)x) );
    mpfr_set((mpfr_ptr)res, result.backend().data(), GMP_RNDN);
}


void LibMpfr_SinPi(MpfrPtr res, const MpfrPtr x, int const dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
	mpfr_float result = sin_pi( mpfr_float((mpfr_ptr)x) );
    mpfr_set((mpfr_ptr)res, result.backend().data(), GMP_RNDN);
}


void LibMpfr_CosPi(MpfrPtr res, const MpfrPtr x, int const dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
	mpfr_float result = cos_pi( mpfr_float((mpfr_ptr)x) );
    mpfr_set((mpfr_ptr)res, result.backend().data(), GMP_RNDN);
}


void LibMpfr_SincPi(MpfrPtr res, const MpfrPtr x, int const dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
	mpfr_float result = sinc_pi( mpfr_float((mpfr_ptr)x) );
    mpfr_set((mpfr_ptr)res, result.backend().data(), GMP_RNDN);
}


void LibMpfr_SinhcPi(MpfrPtr res, const MpfrPtr x, int const dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
	mpfr_float result = sinhc_pi( mpfr_float((mpfr_ptr)x) );
    mpfr_set((mpfr_ptr)res, result.backend().data(), GMP_RNDN);
}


void LibMpfr_Tgamma_(MpfrPtr res, const MpfrPtr x, int const dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
	mpfr_float result = boost::multiprecision::tgamma( mpfr_float((mpfr_ptr)x) );
    mpfr_set((mpfr_ptr)res, result.backend().data(), GMP_RNDN);
}


void LibMpfr_Tgamma1pm1(MpfrPtr res, const MpfrPtr x, int const dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
	mpfr_float result = tgamma1pm1( mpfr_float((mpfr_ptr)x) );
    mpfr_set((mpfr_ptr)res, result.backend().data(), GMP_RNDN);
}




void LibMpfr_Lgamma_(MpfrPtr res, const MpfrPtr x, int const dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
	mpfr_float result = boost::multiprecision::lgamma( mpfr_float((mpfr_ptr)x) );
    mpfr_set((mpfr_ptr)res, result.backend().data(), GMP_RNDN);
}


void LibMpfr_Digamma(MpfrPtr res, const MpfrPtr x, int const dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
	mpfr_float result = digamma( mpfr_float((mpfr_ptr)x) );
    mpfr_set((mpfr_ptr)res, result.backend().data(), GMP_RNDN);
}


void LibMpfr_Trigamma(MpfrPtr res, const MpfrPtr x, int const dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
	mpfr_float result = trigamma( mpfr_float((mpfr_ptr)x) );
    mpfr_set((mpfr_ptr)res, result.backend().data(), GMP_RNDN);
}


void LibMpfr_Factorial(MpfrPtr res, const MpfrPtr x, int const dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
    mpfr_float xt = mpfr_float((mpfr_ptr)x);
	mpfr_float result = tgamma(xt + 1);
    mpfr_set((mpfr_ptr)res, result.backend().data(), GMP_RNDN);
}


void LibMpfr_DoubleFactorial(MpfrPtr res, const MpfrPtr x, int const dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
    mpfr_float xt = mpfr_float((mpfr_ptr)x);
    mpfr_float xt2 = xt/2;
    mpfr_float t1 = (cos_pi(xt)-1)/4;
    mpfr_float pi2 = constants::half_pi<mpfr_float>();
    mpfr_float t2 = pow(pi2, t1);
    mpfr_float result = exp2(xt2) * t2 * tgamma(xt2+1);
    mpfr_set((mpfr_ptr)res, result.backend().data(), GMP_RNDN);
}


void LibMpfr_Erf_(MpfrPtr res, const MpfrPtr x, int const dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
	mpfr_float result = boost::multiprecision::erf( mpfr_float((mpfr_ptr)x) );
    mpfr_set((mpfr_ptr)res, result.backend().data(), GMP_RNDN);
}


void LibMpfr_Erfc_(MpfrPtr res, const MpfrPtr x, int const dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
	mpfr_float result = boost::multiprecision::erfc( mpfr_float((mpfr_ptr)x) );
    mpfr_set((mpfr_ptr)res, result.backend().data(), GMP_RNDN);
}


void LibMpfr_Erf_inv(MpfrPtr res, const MpfrPtr x, int const dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
	mpfr_float result = erf_inv( mpfr_float((mpfr_ptr)x) );
    mpfr_set((mpfr_ptr)res, result.backend().data(), GMP_RNDN);
}


void LibMpfr_Erfc_inv(MpfrPtr res, const MpfrPtr x, int const dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
	mpfr_float result = erfc_inv( mpfr_float((mpfr_ptr)x) );
    mpfr_set((mpfr_ptr)res, result.backend().data(), GMP_RNDN);
}


void LibMpfr_AiryAi(MpfrPtr res, const MpfrPtr x, int const dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
	mpfr_float result = airy_ai( mpfr_float((mpfr_ptr)x) );
    mpfr_set((mpfr_ptr)res, result.backend().data(), GMP_RNDN);
}


void LibMpfr_AiryBi(MpfrPtr res, const MpfrPtr x, int const dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
	mpfr_float result = airy_bi( mpfr_float((mpfr_ptr)x) );
    mpfr_set((mpfr_ptr)res, result.backend().data(), GMP_RNDN);
}


void LibMpfr_AiryAiPrime(MpfrPtr res, const MpfrPtr x, int const dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
	mpfr_float result = airy_ai_prime( mpfr_float((mpfr_ptr)x) );
    mpfr_set((mpfr_ptr)res, result.backend().data(), GMP_RNDN);
}


void LibMpfr_AiryBiPrime(MpfrPtr res, const MpfrPtr x, int const dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
	mpfr_float result = airy_bi_prime( mpfr_float((mpfr_ptr)x) );
    mpfr_set((mpfr_ptr)res, result.backend().data(), GMP_RNDN);
}


void LibMpfr_Aizero(MpfrPtr res, const int n, int const dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
	mpfr_float result = airy_ai_zero<mpfr_float>(n);
    mpfr_set((mpfr_ptr)res, result.backend().data(), GMP_RNDN);
}


void LibMpfr_Bizero(MpfrPtr res, const int n, int const dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
	mpfr_float result = airy_bi_zero<mpfr_float>(n);
    mpfr_set((mpfr_ptr)res, result.backend().data(), GMP_RNDN);
}


void LibMpfr_Ellint_1_K(MpfrPtr res, const MpfrPtr x, int const dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
	mpfr_float result = ellint_1( mpfr_float((mpfr_ptr)x) );
    mpfr_set((mpfr_ptr)res, result.backend().data(), GMP_RNDN);
}


void LibMpfr_Ellint_2_K(MpfrPtr res, const MpfrPtr x, int const dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
	mpfr_float result = ellint_2( mpfr_float((mpfr_ptr)x) );
    mpfr_set((mpfr_ptr)res, result.backend().data(), GMP_RNDN);
}


void LibMpfr_Zeta(MpfrPtr res, const MpfrPtr x, int const dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
	mpfr_float result = zeta( mpfr_float((mpfr_ptr)x) );
    mpfr_set((mpfr_ptr)res, result.backend().data(), GMP_RNDN);
}


void LibMpfr_Ei(MpfrPtr res, const MpfrPtr x, int const dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
	mpfr_float result = expint( mpfr_float((mpfr_ptr)x) );
    mpfr_set((mpfr_ptr)res, result.backend().data(), GMP_RNDN);
}


void LibMpfr_LambertW0(MpfrPtr res, const MpfrPtr x, int const dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
	mpfr_float result = lambert_w0( mpfr_float((mpfr_ptr)x) );
    mpfr_set((mpfr_ptr)res, result.backend().data(), GMP_RNDN);
}


void LibMpfr_LambertWm1(MpfrPtr res, const MpfrPtr x, int const dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
	mpfr_float result = lambert_wm1( mpfr_float((mpfr_ptr)x) );
    mpfr_set((mpfr_ptr)res, result.backend().data(), GMP_RNDN);
}


void LibMpfr_LambertW0Prime(MpfrPtr res, const MpfrPtr x, int const dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
	mpfr_float result = lambert_w0_prime( mpfr_float((mpfr_ptr)x) );
    mpfr_set((mpfr_ptr)res, result.backend().data(), GMP_RNDN);
}


void LibMpfr_LambertWm1Prime(MpfrPtr res, const MpfrPtr x, int const dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
	mpfr_float result = lambert_wm1_prime( mpfr_float((mpfr_ptr)x) );
    mpfr_set((mpfr_ptr)res, result.backend().data(), GMP_RNDN);
}




/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



void LibMpfr_Agm(MpfrPtr res, const MpfrPtr a, const MpfrPtr b, int const dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
	mpfr_float result = agm( mpfr_float((mpfr_ptr)a), mpfr_float((mpfr_ptr)b) );
    mpfr_set((mpfr_ptr)res, result.backend().data(), GMP_RNDN);
}



void LibMpfr_Powm1(MpfrPtr res, const MpfrPtr a, const MpfrPtr b, int const dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
	mpfr_float result = powm1( mpfr_float((mpfr_ptr)a), mpfr_float((mpfr_ptr)b) );
    mpfr_set((mpfr_ptr)res, result.backend().data(), GMP_RNDN);
}



void LibMpfr_TgammaRatio(MpfrPtr res, const MpfrPtr a, const MpfrPtr b, int const dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
	mpfr_float result = tgamma_ratio( mpfr_float((mpfr_ptr)a), mpfr_float((mpfr_ptr)b) );
    mpfr_set((mpfr_ptr)res, result.backend().data(), GMP_RNDN);
}



void LibMpfr_TgammaDeltaRatio(MpfrPtr res, const MpfrPtr a, const MpfrPtr b, int const dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
	mpfr_float result = tgamma_delta_ratio( mpfr_float((mpfr_ptr)a), mpfr_float((mpfr_ptr)b) );
    mpfr_set((mpfr_ptr)res, result.backend().data(), GMP_RNDN);
}



void LibMpfr_Binomial(MpfrPtr res, const MpfrPtr n, const MpfrPtr k, int const dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
    mpfr_float nt = mpfr_float((mpfr_ptr)n);
    mpfr_float kt = mpfr_float((mpfr_ptr)k);
	mpfr_float result = tgamma(nt+1) / ( tgamma(kt+1) * tgamma(nt-kt+1) );
    mpfr_set((mpfr_ptr)res, result.backend().data(), GMP_RNDN);
}



void LibMpfr_RisingFactorial(MpfrPtr res, const MpfrPtr x, const MpfrPtr n, int const dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
    mpfr_float xt = mpfr_float((mpfr_ptr)x);
    mpfr_float nt = mpfr_float((mpfr_ptr)n);
    mpfr_float result = boost::multiprecision::tgamma(xt+nt) / boost::multiprecision::tgamma(xt);
    mpfr_set((mpfr_ptr)res, result.backend().data(), GMP_RNDN);
}



void LibMpfr_FallingFactorial(MpfrPtr res, const MpfrPtr x, const MpfrPtr n, int const dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
    mpfr_float xt = mpfr_float((mpfr_ptr)x);
    mpfr_float nt = mpfr_float((mpfr_ptr)n);
	mpfr_float result = tgamma(xt+1) / tgamma(xt-nt+1);
    mpfr_set((mpfr_ptr)res, result.backend().data(), GMP_RNDN);
}



void LibMpfr_BesselJ(MpfrPtr res, const MpfrPtr v, const MpfrPtr x, int const dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
	mpfr_float result = cyl_bessel_j( mpfr_float((mpfr_ptr)v), mpfr_float((mpfr_ptr)x) );
    mpfr_set((mpfr_ptr)res, result.backend().data(), GMP_RNDN);
}



void LibMpfr_BesselY(MpfrPtr res, const MpfrPtr v, const MpfrPtr x, int const dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
	mpfr_float result = cyl_neumann( mpfr_float((mpfr_ptr)v), mpfr_float((mpfr_ptr)x) );
    mpfr_set((mpfr_ptr)res, result.backend().data(), GMP_RNDN);
}



void LibMpfr_BesselI(MpfrPtr res, const MpfrPtr v, const MpfrPtr x, int const dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
	mpfr_float result = cyl_bessel_i( mpfr_float((mpfr_ptr)v), mpfr_float((mpfr_ptr)x) );
    mpfr_set((mpfr_ptr)res, result.backend().data(), GMP_RNDN);
}



void LibMpfr_BesselK(MpfrPtr res, const MpfrPtr v, const MpfrPtr x, int const dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
	mpfr_float result = cyl_bessel_k( mpfr_float((mpfr_ptr)v), mpfr_float((mpfr_ptr)x) );
    mpfr_set((mpfr_ptr)res, result.backend().data(), GMP_RNDN);
}



void LibMpfr_SphBessel(MpfrPtr res, const unsigned v, const MpfrPtr x, int const dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
	mpfr_float result = sph_bessel( v, mpfr_float((mpfr_ptr)x) );
    mpfr_set((mpfr_ptr)res, result.backend().data(), GMP_RNDN);
}



void LibMpfr_SphNeumann(MpfrPtr res, const unsigned v, const MpfrPtr x, int const dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
	mpfr_float result = sph_neumann( v, mpfr_float((mpfr_ptr)x) );
    mpfr_set((mpfr_ptr)res, result.backend().data(), GMP_RNDN);
}



void LibMpfr_BesselJPrime(MpfrPtr res, const MpfrPtr v, const MpfrPtr x, int const dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
	mpfr_float result = cyl_bessel_j_prime( mpfr_float((mpfr_ptr)v), mpfr_float((mpfr_ptr)x) );
    mpfr_set((mpfr_ptr)res, result.backend().data(), GMP_RNDN);
}



void LibMpfr_BesselYPrime(MpfrPtr res, const MpfrPtr v, const MpfrPtr x, int const dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
	mpfr_float result = cyl_neumann_prime( mpfr_float((mpfr_ptr)v), mpfr_float((mpfr_ptr)x) );
    mpfr_set((mpfr_ptr)res, result.backend().data(), GMP_RNDN);
}



void LibMpfr_BesselIPrime(MpfrPtr res, const MpfrPtr v, const MpfrPtr x, int const dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
	mpfr_float result = cyl_bessel_i_prime( mpfr_float((mpfr_ptr)v), mpfr_float((mpfr_ptr)x) );
    mpfr_set((mpfr_ptr)res, result.backend().data(), GMP_RNDN);
}



void LibMpfr_BesselKPrime(MpfrPtr res, const MpfrPtr v, const MpfrPtr x, int const dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
	mpfr_float result = cyl_bessel_k_prime( mpfr_float((mpfr_ptr)v), mpfr_float((mpfr_ptr)x) );
    mpfr_set((mpfr_ptr)res, result.backend().data(), GMP_RNDN);
}



void LibMpfr_SphBesselPrime(MpfrPtr res, const unsigned v, const MpfrPtr x, int const dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
	mpfr_float result = boost::math::sph_bessel_prime( v, mpfr_float((mpfr_ptr)x) );
    mpfr_set((mpfr_ptr)res, result.backend().data(), GMP_RNDN);
}



void LibMpfr_SphNeumannPrime(MpfrPtr res, const unsigned v, const MpfrPtr x, int const dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
	mpfr_float result = boost::math::sph_neumann_prime( v, mpfr_float((mpfr_ptr)x) );
    mpfr_set((mpfr_ptr)res, result.backend().data(), GMP_RNDN);
}



void LibMpfr_BesselJZero(MpfrPtr res, const MpfrPtr v, const int m, int const dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
	mpfr_float result = cyl_bessel_j_zero( mpfr_float((mpfr_ptr)v), m );
    mpfr_set((mpfr_ptr)res, result.backend().data(), GMP_RNDN);
}



void LibMpfr_BesselYZero(MpfrPtr res, const MpfrPtr v, const int m, int const dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
	mpfr_float result = cyl_neumann_zero( mpfr_float((mpfr_ptr)v), m );
    mpfr_set((mpfr_ptr)res, result.backend().data(), GMP_RNDN);
}



void LibMpfr_GammaP(MpfrPtr res, const MpfrPtr a, const MpfrPtr x, int const dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
	mpfr_float result = gamma_p( mpfr_float((mpfr_ptr)a), mpfr_float((mpfr_ptr)x) );
    mpfr_set((mpfr_ptr)res, result.backend().data(), GMP_RNDN);
}



void LibMpfr_GammaQ(MpfrPtr res, const MpfrPtr a, const MpfrPtr x, int const dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
	mpfr_float result = gamma_q( mpfr_float((mpfr_ptr)a), mpfr_float((mpfr_ptr)x) );
    mpfr_set((mpfr_ptr)res, result.backend().data(), GMP_RNDN);
}



void LibMpfr_TgammaLower(MpfrPtr res, const MpfrPtr a, const MpfrPtr x, int const dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
	mpfr_float result = tgamma_lower( mpfr_float((mpfr_ptr)a), mpfr_float((mpfr_ptr)x) );
    mpfr_set((mpfr_ptr)res, result.backend().data(), GMP_RNDN);
}



void LibMpfr_TgammaUpper(MpfrPtr res, const MpfrPtr a, const MpfrPtr x, int const dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
	mpfr_float result = tgamma( mpfr_float((mpfr_ptr)a), mpfr_float((mpfr_ptr)x) );
    mpfr_set((mpfr_ptr)res, result.backend().data(), GMP_RNDN);
}




void LibMpfr_GammaPInv(MpfrPtr res, const MpfrPtr a, const MpfrPtr p, int const dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
	mpfr_float result = gamma_p_inv( mpfr_float((mpfr_ptr)a), mpfr_float((mpfr_ptr)p) );
    mpfr_set((mpfr_ptr)res, result.backend().data(), GMP_RNDN);
}



void LibMpfr_GammaQInv(MpfrPtr res, const MpfrPtr a, const MpfrPtr p, int const dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
	mpfr_float result = gamma_q_inv( mpfr_float((mpfr_ptr)a), mpfr_float((mpfr_ptr)p) );
    mpfr_set((mpfr_ptr)res, result.backend().data(), GMP_RNDN);
}



void LibMpfr_GammaPInva(MpfrPtr res, const MpfrPtr x, const MpfrPtr p, int const dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
	mpfr_float result = gamma_p_inva( mpfr_float((mpfr_ptr)x), mpfr_float((mpfr_ptr)p) );
    mpfr_set((mpfr_ptr)res, result.backend().data(), GMP_RNDN);
}



void LibMpfr_GammaQInva(MpfrPtr res, const MpfrPtr x, const MpfrPtr p, int const dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
	mpfr_float result = gamma_q_inva( mpfr_float((mpfr_ptr)x), mpfr_float((mpfr_ptr)p) );
    mpfr_set((mpfr_ptr)res, result.backend().data(), GMP_RNDN);
}



void LibMpfr_GammaPDerivative(MpfrPtr res, const MpfrPtr a, const MpfrPtr x, int const dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
	mpfr_float result = gamma_p_derivative( mpfr_float((mpfr_ptr)a), mpfr_float((mpfr_ptr)x) );
    mpfr_set((mpfr_ptr)res, result.backend().data(), GMP_RNDN);
}



void LibMpfr_Beta(MpfrPtr res, const MpfrPtr a, const MpfrPtr b, int const dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
	mpfr_float result = beta( mpfr_float((mpfr_ptr)a), mpfr_float((mpfr_ptr)b) );
    mpfr_set((mpfr_ptr)res, result.backend().data(), GMP_RNDN);
}




void LibMpfr_LegendreP(MpfrPtr res, int n, const MpfrPtr x, int const dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
	mpfr_float result = legendre_p<mpfr_float>(n, mpfr_float((mpfr_ptr)x) );
    mpfr_set((mpfr_ptr)res, result.backend().data(), GMP_RNDN);
}



void LibMpfr_LegendreQ(MpfrPtr res, int n, const MpfrPtr x, int const dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
	mpfr_float result = legendre_q( n, mpfr_float((mpfr_ptr)x) );
    mpfr_set((mpfr_ptr)res, result.backend().data(), GMP_RNDN);
}



void LibMpfr_Laguerre(MpfrPtr res, int n, const MpfrPtr x, int const dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
	mpfr_float result = laguerre( n, mpfr_float((mpfr_ptr)x) );
    mpfr_set((mpfr_ptr)res, result.backend().data(), GMP_RNDN);
}



void LibMpfr_Hermite(MpfrPtr res, int n, const MpfrPtr x, int const dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
	mpfr_float result = hermite( n, mpfr_float((mpfr_ptr)x) );
    mpfr_set((mpfr_ptr)res, result.backend().data(), GMP_RNDN);
}



void LibMpfr_ChebyshevT(MpfrPtr res, int n, const MpfrPtr x, int const dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
	mpfr_float result = chebyshev_t( n, mpfr_float((mpfr_ptr)x) );
    mpfr_set((mpfr_ptr)res, result.backend().data(), GMP_RNDN);
}



void LibMpfr_ChebyshevU(MpfrPtr res, int n, const MpfrPtr x, int const dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
	mpfr_float result = chebyshev_u( n, mpfr_float((mpfr_ptr)x) );
    mpfr_set((mpfr_ptr)res, result.backend().data(), GMP_RNDN);
}



void LibMpfr_Polygamma(MpfrPtr res, int n, const MpfrPtr x, int const dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
	mpfr_float result = polygamma( n, mpfr_float((mpfr_ptr)x) );
    mpfr_set((mpfr_ptr)res, result.backend().data(), GMP_RNDN);
}



void LibMpfr_EllintRC(MpfrPtr res, const MpfrPtr x, const MpfrPtr y, int const dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
	mpfr_float result = ellint_rc( mpfr_float((mpfr_ptr)x), mpfr_float((mpfr_ptr)y) );
    mpfr_set((mpfr_ptr)res, result.backend().data(), GMP_RNDN);
}



void LibMpfr_Ellint1F(MpfrPtr res, const MpfrPtr k, const MpfrPtr phi, int const dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
	mpfr_float result = ellint_1( mpfr_float((mpfr_ptr)k), mpfr_float((mpfr_ptr)phi) );
    mpfr_set((mpfr_ptr)res, result.backend().data(), GMP_RNDN);
}



void LibMpfr_Ellint2F(MpfrPtr res, const MpfrPtr k, const MpfrPtr phi, int const dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
	mpfr_float result = ellint_2( mpfr_float((mpfr_ptr)k), mpfr_float((mpfr_ptr)phi) );
    mpfr_set((mpfr_ptr)res, result.backend().data(), GMP_RNDN);
}



void LibMpfr_Ellint3K(MpfrPtr res, const MpfrPtr k, const MpfrPtr n, int const dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
	mpfr_float result = ellint_3( mpfr_float((mpfr_ptr)k), mpfr_float((mpfr_ptr)n) );
    mpfr_set((mpfr_ptr)res, result.backend().data(), GMP_RNDN);
}





void LibMpfr_JacobiCD(MpfrPtr res, const MpfrPtr k, const MpfrPtr u, int const dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
	mpfr_float result = jacobi_cd( mpfr_float((mpfr_ptr)k), mpfr_float((mpfr_ptr)u) );
    mpfr_set((mpfr_ptr)res, result.backend().data(), GMP_RNDN);
}



void LibMpfr_JacobiCN(MpfrPtr res, const MpfrPtr k, const MpfrPtr u, int const dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
	mpfr_float result = jacobi_cn( mpfr_float((mpfr_ptr)k), mpfr_float((mpfr_ptr)u) );
    mpfr_set((mpfr_ptr)res, result.backend().data(), GMP_RNDN);
}



void LibMpfr_JacobiCS(MpfrPtr res, const MpfrPtr k, const MpfrPtr u, int const dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
	mpfr_float result = jacobi_cs( mpfr_float((mpfr_ptr)k), mpfr_float((mpfr_ptr)u) );
    mpfr_set((mpfr_ptr)res, result.backend().data(), GMP_RNDN);
}



void LibMpfr_JacobiDC(MpfrPtr res, const MpfrPtr k, const MpfrPtr u, int const dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
	mpfr_float result = jacobi_dc( mpfr_float((mpfr_ptr)k), mpfr_float((mpfr_ptr)u) );
    mpfr_set((mpfr_ptr)res, result.backend().data(), GMP_RNDN);
}



void LibMpfr_JacobiDN(MpfrPtr res, const MpfrPtr k, const MpfrPtr u, int const dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
	mpfr_float result = jacobi_dn( mpfr_float((mpfr_ptr)k), mpfr_float((mpfr_ptr)u) );
    mpfr_set((mpfr_ptr)res, result.backend().data(), GMP_RNDN);
}



void LibMpfr_JacobiDS(MpfrPtr res, const MpfrPtr k, const MpfrPtr u, int const dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
	mpfr_float result = jacobi_ds( mpfr_float((mpfr_ptr)k), mpfr_float((mpfr_ptr)u) );
    mpfr_set((mpfr_ptr)res, result.backend().data(), GMP_RNDN);
}



void LibMpfr_JacobiNC(MpfrPtr res, const MpfrPtr k, const MpfrPtr u, int const dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
	mpfr_float result = jacobi_nc( mpfr_float((mpfr_ptr)k), mpfr_float((mpfr_ptr)u) );
    mpfr_set((mpfr_ptr)res, result.backend().data(), GMP_RNDN);
}



void LibMpfr_JacobiND(MpfrPtr res, const MpfrPtr k, const MpfrPtr u, int const dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
	mpfr_float result = jacobi_nd( mpfr_float((mpfr_ptr)k), mpfr_float((mpfr_ptr)u) );
    mpfr_set((mpfr_ptr)res, result.backend().data(), GMP_RNDN);
}



void LibMpfr_JacobiNS(MpfrPtr res, const MpfrPtr k, const MpfrPtr u, int const dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
	mpfr_float result = jacobi_ns( mpfr_float((mpfr_ptr)k), mpfr_float((mpfr_ptr)u) );
    mpfr_set((mpfr_ptr)res, result.backend().data(), GMP_RNDN);
}



void LibMpfr_JacobiSC(MpfrPtr res, const MpfrPtr k, const MpfrPtr u, int const dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
	mpfr_float result = jacobi_sc( mpfr_float((mpfr_ptr)k), mpfr_float((mpfr_ptr)u) );
    mpfr_set((mpfr_ptr)res, result.backend().data(), GMP_RNDN);
}



void LibMpfr_JacobiSD(MpfrPtr res, const MpfrPtr k, const MpfrPtr u, int const dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
	mpfr_float result = jacobi_sd( mpfr_float((mpfr_ptr)k), mpfr_float((mpfr_ptr)u) );
    mpfr_set((mpfr_ptr)res, result.backend().data(), GMP_RNDN);
}



void LibMpfr_JacobiSN(MpfrPtr res, const MpfrPtr k, const MpfrPtr u, int const dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
	mpfr_float result = jacobi_sn( mpfr_float((mpfr_ptr)k), mpfr_float((mpfr_ptr)u) );
    mpfr_set((mpfr_ptr)res, result.backend().data(), GMP_RNDN);
}



void LibMpfr_expint(MpfrPtr res, const unsigned n, const MpfrPtr x, int const dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
	mpfr_float result = expint( n, mpfr_float((mpfr_ptr)x) );
    mpfr_set((mpfr_ptr)res, result.backend().data(), GMP_RNDN);
}



void LibMpfr_OwenT(MpfrPtr res, const MpfrPtr h, const MpfrPtr a, int const dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
	mpfr_float result = owens_t( mpfr_float((mpfr_ptr)h), mpfr_float((mpfr_ptr)a) );
    mpfr_set((mpfr_ptr)res, result.backend().data(), GMP_RNDN);
}






void LibMpfr_IBeta(MpfrPtr res, const MpfrPtr a, const MpfrPtr b, const MpfrPtr x, int const dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
	mpfr_float result = ibeta( mpfr_float((mpfr_ptr)a), mpfr_float((mpfr_ptr)b), mpfr_float((mpfr_ptr)x) );
    mpfr_set((mpfr_ptr)res, result.backend().data(), GMP_RNDN);
}



void LibMpfr_IBetac(MpfrPtr res, const MpfrPtr a, const MpfrPtr b, const MpfrPtr x, int const dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
	mpfr_float result = ibetac( mpfr_float((mpfr_ptr)a), mpfr_float((mpfr_ptr)b), mpfr_float((mpfr_ptr)x) );
    mpfr_set((mpfr_ptr)res, result.backend().data(), GMP_RNDN);
}



void LibMpfr_IBetaNonNormalized(MpfrPtr res, const MpfrPtr a, const MpfrPtr b, const MpfrPtr x, int const dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
	mpfr_float result = beta( mpfr_float((mpfr_ptr)a), mpfr_float((mpfr_ptr)b), mpfr_float((mpfr_ptr)x) );
    mpfr_set((mpfr_ptr)res, result.backend().data(), GMP_RNDN);
}



void LibMpfr_IBetacNonNormalized(MpfrPtr res, const MpfrPtr a, const MpfrPtr b, const MpfrPtr x, int const dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
	mpfr_float result = betac( mpfr_float((mpfr_ptr)a), mpfr_float((mpfr_ptr)b), mpfr_float((mpfr_ptr)x) );
    mpfr_set((mpfr_ptr)res, result.backend().data(), GMP_RNDN);
}



void LibMpfr_IBetaInv(MpfrPtr res, const MpfrPtr a, const MpfrPtr b, const MpfrPtr p, int const dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
	mpfr_float result = ibeta_inv( mpfr_float((mpfr_ptr)a), mpfr_float((mpfr_ptr)b), mpfr_float((mpfr_ptr)p) );
    mpfr_set((mpfr_ptr)res, result.backend().data(), GMP_RNDN);
}



void LibMpfr_IBetacInv(MpfrPtr res, const MpfrPtr a, const MpfrPtr b, const MpfrPtr p, int const dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
	mpfr_float result = ibetac_inv( mpfr_float((mpfr_ptr)a), mpfr_float((mpfr_ptr)b), mpfr_float((mpfr_ptr)p) );
    mpfr_set((mpfr_ptr)res, result.backend().data(), GMP_RNDN);
}



void LibMpfr_IBetaInva(MpfrPtr res, const MpfrPtr b, const MpfrPtr x, const MpfrPtr p, int const dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
	mpfr_float result = ibeta_inva( mpfr_float((mpfr_ptr)b), mpfr_float((mpfr_ptr)x), mpfr_float((mpfr_ptr)p) );
    mpfr_set((mpfr_ptr)res, result.backend().data(), GMP_RNDN);
}



void LibMpfr_IBetacInva(MpfrPtr res, const MpfrPtr b, const MpfrPtr x, const MpfrPtr p, int const dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
	mpfr_float result = ibetac_inva( mpfr_float((mpfr_ptr)b), mpfr_float((mpfr_ptr)x), mpfr_float((mpfr_ptr)p) );
    mpfr_set((mpfr_ptr)res, result.backend().data(), GMP_RNDN);
}



void LibMpfr_IBetaInvb(MpfrPtr res, const MpfrPtr a, const MpfrPtr x, const MpfrPtr p, int const dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
	mpfr_float result = ibeta_invb( mpfr_float((mpfr_ptr)a), mpfr_float((mpfr_ptr)x), mpfr_float((mpfr_ptr)p) );
    mpfr_set((mpfr_ptr)res, result.backend().data(), GMP_RNDN);
}



void LibMpfr_IBetacInvb(MpfrPtr res, const MpfrPtr a, const MpfrPtr x, const MpfrPtr p, int const dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
	mpfr_float result = ibetac_invb( mpfr_float((mpfr_ptr)a), mpfr_float((mpfr_ptr)x), mpfr_float((mpfr_ptr)p) );
    mpfr_set((mpfr_ptr)res, result.backend().data(), GMP_RNDN);
}


void LibMpfr_IBetaDerivative(MpfrPtr res, const MpfrPtr a, const MpfrPtr b, const MpfrPtr x, int const dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
	mpfr_float result = ibeta_derivative( mpfr_float((mpfr_ptr)a), mpfr_float((mpfr_ptr)b), mpfr_float((mpfr_ptr)x) );
    mpfr_set((mpfr_ptr)res, result.backend().data(), GMP_RNDN);
}




void LibMpfr_LegendrePM(MpfrPtr res, const int n, const int m, const MpfrPtr x, int const dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
	mpfr_float result = legendre_p( n, m, mpfr_float((mpfr_ptr)x) );
    mpfr_set((mpfr_ptr)res, result.backend().data(), GMP_RNDN);
}



void LibMpfr_LaguerreM(MpfrPtr res, const int n, const int m, const MpfrPtr x, int const dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
	mpfr_float result = laguerre( n, m, mpfr_float((mpfr_ptr)x) );
    mpfr_set((mpfr_ptr)res, result.backend().data(), GMP_RNDN);
}


void LibMpfr_EllipticRF(MpfrPtr res, const MpfrPtr x, const MpfrPtr y, const MpfrPtr z, int const dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
	mpfr_float result = ellint_rf( mpfr_float((mpfr_ptr)x), mpfr_float((mpfr_ptr)y), mpfr_float((mpfr_ptr)z) );
    mpfr_set((mpfr_ptr)res, result.backend().data(), GMP_RNDN);
}


void LibMpfr_EllipticRD(MpfrPtr res, const MpfrPtr x, const MpfrPtr y, const MpfrPtr z, int const dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
	mpfr_float result = ellint_rd( mpfr_float((mpfr_ptr)x), mpfr_float((mpfr_ptr)y), mpfr_float((mpfr_ptr)z) );
    mpfr_set((mpfr_ptr)res, result.backend().data(), GMP_RNDN);
}


void LibMpfr_EllipticRG(MpfrPtr res, const MpfrPtr x, const MpfrPtr y, const MpfrPtr z, int const dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
	mpfr_float result = ellint_rg( mpfr_float((mpfr_ptr)x), mpfr_float((mpfr_ptr)y), mpfr_float((mpfr_ptr)z) );
    mpfr_set((mpfr_ptr)res, result.backend().data(), GMP_RNDN);
}


void LibMpfr_Ellint3F(MpfrPtr res, const MpfrPtr k, const MpfrPtr n, const MpfrPtr phi, int const dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
	mpfr_float result = ellint_3( mpfr_float((mpfr_ptr)k), mpfr_float((mpfr_ptr)n), mpfr_float((mpfr_ptr)phi) );
    mpfr_set((mpfr_ptr)res, result.backend().data(), GMP_RNDN);
}


void LibMpfr_Gegenbauer(MpfrPtr res, const int n, const MpfrPtr lambda1, const MpfrPtr x, int const dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
	mpfr_float result = gegenbauer(n, mpfr_float((mpfr_ptr)lambda1), mpfr_float((mpfr_ptr)x) );
    mpfr_set((mpfr_ptr)res, result.backend().data(), GMP_RNDN);
}


void LibMpfr_Jacobi(MpfrPtr res, const int n, const MpfrPtr alpha, const MpfrPtr beta, const MpfrPtr x, int const dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
	mpfr_float result = jacobi(n, mpfr_float((mpfr_ptr)alpha), mpfr_float((mpfr_ptr)beta), mpfr_float((mpfr_ptr)x) );
    mpfr_set((mpfr_ptr)res, result.backend().data(), GMP_RNDN);
}



void LibMpfr_SphericalHarmonicR(MpfrPtr res, const int n, const int m, const MpfrPtr theta, const MpfrPtr phi, int const dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
	mpfr_float result = spherical_harmonic_r( n, m, mpfr_float((mpfr_ptr)theta), mpfr_float((mpfr_ptr)phi) );
    mpfr_set((mpfr_ptr)res, result.backend().data(), GMP_RNDN);
}



void LibMpfr_SphericalHarmonicI(MpfrPtr res, const int n, const int m, const MpfrPtr theta, const MpfrPtr phi, int const dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
	mpfr_float result = spherical_harmonic_i( n, m, mpfr_float((mpfr_ptr)theta), mpfr_float((mpfr_ptr)phi) );
    mpfr_set((mpfr_ptr)res, result.backend().data(), GMP_RNDN);
}


void LibMpfr_EllipticRJ(MpfrPtr res, const MpfrPtr x, const MpfrPtr y, const MpfrPtr z, const MpfrPtr p, int const dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
	mpfr_float result = ellint_rj( mpfr_float((mpfr_ptr)x), mpfr_float((mpfr_ptr)y), mpfr_float((mpfr_ptr)z), mpfr_float((mpfr_ptr)p) );
    mpfr_set((mpfr_ptr)res, result.backend().data(), GMP_RNDN);
}



// Hypergeometric and Theta Functions





void LibMpfr_Hypergeo0F1(MpfrPtr res, const MpfrPtr b, const MpfrPtr x, int const dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
	mpfr_float result = hypergeometric_0F1( mpfr_float((mpfr_ptr)b), mpfr_float((mpfr_ptr)x) );
    mpfr_set((mpfr_ptr)res, result.backend().data(), GMP_RNDN);
}



void LibMpfr_Hypergeo1F1(MpfrPtr res, const MpfrPtr a, const MpfrPtr b, const MpfrPtr x, int const dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
	mpfr_float result = hypergeometric_1F1( mpfr_float((mpfr_ptr)a), mpfr_float((mpfr_ptr)b), mpfr_float((mpfr_ptr)x) );
    mpfr_set((mpfr_ptr)res, result.backend().data(), GMP_RNDN);
}



void LibMpfr_Hypergeo1F1r(MpfrPtr res, const MpfrPtr a, const MpfrPtr b, const MpfrPtr x, int const dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
	mpfr_float result = hypergeometric_1F1_regularized( mpfr_float((mpfr_ptr)a), mpfr_float((mpfr_ptr)b), mpfr_float((mpfr_ptr)x) );
    mpfr_set((mpfr_ptr)res, result.backend().data(), GMP_RNDN);
}



void LibMpfr_LogHypergeo1F1(MpfrPtr res, const MpfrPtr a, const MpfrPtr b, const MpfrPtr x, int const dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
	mpfr_float result = log_hypergeometric_1F1( mpfr_float((mpfr_ptr)a), mpfr_float((mpfr_ptr)b), mpfr_float((mpfr_ptr)x) );
    mpfr_set((mpfr_ptr)res, result.backend().data(), GMP_RNDN);
}





void LibMpfr_JacobiTheta1(MpfrPtr res, const MpfrPtr x, const MpfrPtr q, int const dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
	mpfr_float result = jacobi_theta1( mpfr_float((mpfr_ptr)x), mpfr_float((mpfr_ptr)q) );
    mpfr_set((mpfr_ptr)res, result.backend().data(), GMP_RNDN);
}



void LibMpfr_JacobiTheta2(MpfrPtr res, const MpfrPtr x, const MpfrPtr q, int const dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
	mpfr_float result = jacobi_theta2( mpfr_float((mpfr_ptr)x), mpfr_float((mpfr_ptr)q) );
    mpfr_set((mpfr_ptr)res, result.backend().data(), GMP_RNDN);
}



void LibMpfr_JacobiTheta3(MpfrPtr res, const MpfrPtr x, const MpfrPtr q, int const dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
	mpfr_float result = jacobi_theta3( mpfr_float((mpfr_ptr)x), mpfr_float((mpfr_ptr)q) );
    mpfr_set((mpfr_ptr)res, result.backend().data(), GMP_RNDN);
}



void LibMpfr_JacobiTheta4(MpfrPtr res, const MpfrPtr x, const MpfrPtr q, int const dps)
{
    mpfr_float::default_precision(dps);  // in decimal digits
	mpfr_float result = jacobi_theta4( mpfr_float((mpfr_ptr)x), mpfr_float((mpfr_ptr)q) );
    mpfr_set((mpfr_ptr)res, result.backend().data(), GMP_RNDN);
}


















