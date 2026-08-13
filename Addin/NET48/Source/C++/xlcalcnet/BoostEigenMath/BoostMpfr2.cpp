


// See also: https://www.boost.org/doc/libs/1_80_0/boost/math/tools/user.hpp

// \home\MP64\math-boost\include\boost\math\tools\user.hpp

// Note: in exp_sinh_detail.hpp, inserted Real abterm1  [[maybe_unused]] = 1;

#include <boost/math/tools/user.hpp>
#include <boost/math/tools/config.hpp>

#include "BoostMpfr.h"


#include "stdint.h"
#include <complex>
#include <vector>
#include <iostream>
#include <limits>



#include <boost/math/tools/minima.hpp>
#include <boost/math/tools/roots.hpp>
#include <tuple> // for std::tuple and std::make_tuple.
#include <boost/math/constants/constants.hpp>
#include <boost/multiprecision/mpfr.hpp>


#include <Eigen/Dense>

#include "include/cppoptlib/meta.h"
#include "include/cppoptlib/problem.h"
#include "include/cppoptlib/solver/neldermeadsolver.h"
#include "include/cppoptlib/solver/cmaessolver.h"
#include "include/cppoptlib/solver/lbfgssolver.h"
#include "include/cppoptlib/solver/bfgssolver.h"
#include "include/cppoptlib/solver/gradientdescentsolver.h"
#include "include/cppoptlib/solver/conjugatedgradientdescentsolver.h"
#include "include/cppoptlib/solver/newtondescentsolver.h"
#include <mp_BoostEigenConstants.h>


using namespace std;
using namespace boost::math;
using namespace boost::multiprecision;
using namespace boost::math::tools;
using boost::multiprecision::mpfr_float;

////*********************** Boost/CppOptLib **********************************
//
using namespace Eigen;
using namespace cppoptlib;
typedef Matrix<mpfr_float, Dynamic, 1> state_type_vec;
typedef state_type_vec* mpVectorPtr;




class CppOptLibSolver1 : public Problem<mpfr_float>
{
    public:
    using typename cppoptlib::Problem<mpfr_float>::TVector;

    CppOptLibSolver1(MpfrFuncPtr f1, mpVectorPtr matX_, mpVectorPtr matNorm_)
     {func1 = f1; matX = matX_ ; matNorm = matNorm_; };
    mpfr_float value(const TVector &x) {
          *matX = x;
          func1(matX, matNorm);
          mpfr_float norm = (*matNorm)(0,0);
          return norm;
    }

  MpfrFuncPtr func1;
  mpVectorPtr matX, matNorm;
};





void LibMpfr_NelderMeadSolver(MpfrFuncPtr f1, MpfrStatePtr matX_, MpfrStatePtr matNorm_, MpfrStatePtr xPtr, MpfrStatePtr resPtr)
{
 printf("NelderMeadSolver");
    CppOptLibSolver1 f(f1, (mpVectorPtr)matX_, (mpVectorPtr)matNorm_);
    state_type_vec x = (*(mpVectorPtr)xPtr);
    NelderMeadSolver<CppOptLibSolver1> solver;
//    mpfr_float eps = std::numeric_limits<mpfr_float>::epsilon();
    solver.minimize(f, x);
    (*(mpVectorPtr)matX_) = x;
    (*(mpVectorPtr)matNorm_)(0,0) = f(x);
}




void LibMpfr_CMAesSolver(MpfrFuncPtr f1, MpfrStatePtr matX_, MpfrStatePtr matNorm_, MpfrStatePtr xPtr, MpfrStatePtr resPtr)
{
 printf("CMAesSolver");
    CppOptLibSolver1 f(f1, (mpVectorPtr)matX_, (mpVectorPtr)matNorm_);
    state_type_vec x = (*(mpVectorPtr)xPtr);
    CMAesSolver<CppOptLibSolver1> solver;
//    mpfr_float eps = std::numeric_limits<mpfr_float>::epsilon();
    solver.minimize(f, x);
    (*(mpVectorPtr)matX_) = x;
    (*(mpVectorPtr)matNorm_)(0,0) = f(x);
}



void LibMpfr_CppOptLibDirect1(long what, MpfrFuncPtr f1, MpfrStatePtr matX, MpfrStatePtr matNorm, MpfrStatePtr xPtr, MpfrStatePtr resPtr)
{
	switch (what) {
		case mp_nelder_mead_solver: LibMpfr_NelderMeadSolver(f1, matX, matNorm, xPtr,resPtr ); break;
		case mp_cma_es_solver: LibMpfr_CMAesSolver(f1, matX, matNorm, xPtr,resPtr ); break;
	}
}






class CppOptLibSolver2 : public Problem<mpfr_float>
{
    public:
    using typename cppoptlib::Problem<mpfr_float>::TVector;

    CppOptLibSolver2(MpfrFuncPtr f1, MpfrFuncPtr f2, mpVectorPtr matX_, mpVectorPtr matGrad_, mpVectorPtr matNorm_)
     {func1 = f1; func2 = f2;  matX = matX_ ; matGrad = matGrad_; matNorm = matNorm_; };
    mpfr_float value(const TVector &x) {
          *matX = x;
          func1(matX, matNorm);
          mpfr_float norm = (*matNorm)(0,0);
          return norm;
    }
    void gradient(const TVector &x, TVector &grad) {
        *matX = x;
        *matGrad = grad;
        func2(matX, matGrad);
        grad = *matGrad;
    }

  MpfrFuncPtr func1, func2;
  mpVectorPtr matX, matGrad, matNorm;
};




void LibMpfr_LbfgsSolver(MpfrFuncPtr f1, MpfrFuncPtr f2, MpfrStatePtr matX_, MpfrStatePtr matGrad_, MpfrStatePtr matNorm_, MpfrStatePtr xPtr, MpfrStatePtr resPtr)
{
 printf("LbfgsSolver");
    CppOptLibSolver2 f(f1, f2, (mpVectorPtr)matX_, (mpVectorPtr)matGrad_, (mpVectorPtr)matNorm_);
    state_type_vec x = (*(mpVectorPtr)xPtr);
    LbfgsSolver<CppOptLibSolver2> solver;
    mpfr_float eps = std::numeric_limits<mpfr_float>::epsilon();
    Criteria<mpfr_float> m_stop;
    m_stop.defaults();
    m_stop.gradNorm = 1000 * eps;
    solver.setStopCriteria(m_stop);
    solver.minimize(f, x);
    (*(mpVectorPtr)matX_) = x;
    (*(mpVectorPtr)matNorm_)(0,0) = f(x);
}




void LibMpfr_BfgsSolver(MpfrFuncPtr f1, MpfrFuncPtr f2, MpfrStatePtr matX_, MpfrStatePtr matGrad_, MpfrStatePtr matNorm_, MpfrStatePtr xPtr, MpfrStatePtr resPtr)
{
 printf("BfgsSolver");
    CppOptLibSolver2 f(f1, f2, (mpVectorPtr)matX_, (mpVectorPtr)matGrad_, (mpVectorPtr)matNorm_);
    state_type_vec x = (*(mpVectorPtr)xPtr);
    BfgsSolver<CppOptLibSolver2> solver;
    mpfr_float eps = std::numeric_limits<mpfr_float>::epsilon();
    Criteria<mpfr_float> m_stop;
    m_stop.defaults();
    m_stop.gradNorm = 1000 * eps;
    solver.setStopCriteria(m_stop);
    solver.minimize(f, x);
    (*(mpVectorPtr)matX_) = x;
    (*(mpVectorPtr)matNorm_)(0,0) = f(x);
}





void LibMpfr_GradientDescentSolver(MpfrFuncPtr f1, MpfrFuncPtr f2, MpfrStatePtr matX_, MpfrStatePtr matGrad_, MpfrStatePtr matNorm_, MpfrStatePtr xPtr, MpfrStatePtr resPtr)
{
 printf("GradientDescentSolver");
    CppOptLibSolver2 f(f1, f2, (mpVectorPtr)matX_, (mpVectorPtr)matGrad_, (mpVectorPtr)matNorm_);
    state_type_vec x = (*(mpVectorPtr)xPtr);
    GradientDescentSolver<CppOptLibSolver2> solver;
    mpfr_float eps = std::numeric_limits<mpfr_float>::epsilon();
    Criteria<mpfr_float> m_stop;
    m_stop.defaults();
    m_stop.gradNorm = 1000 * eps;
    solver.setStopCriteria(m_stop);
    solver.minimize(f, x);
    (*(mpVectorPtr)matX_) = x;
    (*(mpVectorPtr)matNorm_)(0,0) = f(x);
}


void LibMpfr_ConjugatedGradientDescentSolver(MpfrFuncPtr f1, MpfrFuncPtr f2, MpfrStatePtr matX_, MpfrStatePtr matGrad_, MpfrStatePtr matNorm_, MpfrStatePtr xPtr, MpfrStatePtr resPtr)
{
 printf("ConjugatedGradientDescentSolver");
    CppOptLibSolver2 f(f1, f2, (mpVectorPtr)matX_, (mpVectorPtr)matGrad_, (mpVectorPtr)matNorm_);
    state_type_vec x = (*(mpVectorPtr)xPtr);
    ConjugatedGradientDescentSolver<CppOptLibSolver2> solver;
    mpfr_float eps = std::numeric_limits<mpfr_float>::epsilon();
    Criteria<mpfr_float> m_stop;
    m_stop.defaults();
    m_stop.gradNorm = 1000 * eps;
    solver.setStopCriteria(m_stop);
    solver.minimize(f, x);
    (*(mpVectorPtr)matX_) = x;
    (*(mpVectorPtr)matNorm_)(0,0) = f(x);
}


void LibMpfr_CppOptLibDirect2(long what, MpfrFuncPtr f1, MpfrFuncPtr f2, MpfrStatePtr matX, MpfrStatePtr matGrad, MpfrStatePtr matNorm, MpfrStatePtr xPtr, MpfrStatePtr resPtr)
{
	switch (what) {
		case mp_bfgs_solver: LibMpfr_BfgsSolver(f1, f2, matX, matGrad, matNorm, xPtr,resPtr ); break;
		case mp_conjugated_gradient_descent_solver: LibMpfr_ConjugatedGradientDescentSolver(f1, f2, matX, matGrad, matNorm, xPtr,resPtr ); break;
		case mp_gradient_descent_solver: LibMpfr_GradientDescentSolver(f1, f2, matX, matGrad, matNorm, xPtr,resPtr ); break;
		case mp_lbfgs_solver: LibMpfr_LbfgsSolver(f1, f2, matX, matGrad, matNorm, xPtr,resPtr ); break;
	}
}






class CppOptLibSolver3 : public Problem<mpfr_float>
{
    public:
    using typename cppoptlib::Problem<mpfr_float>::TVector;
    using typename cppoptlib::Problem<mpfr_float>::THessian;

    CppOptLibSolver3(MpfrFuncPtr f1, MpfrFuncPtr f2, MpfrFuncPtr f3, mpVectorPtr matX_, mpVectorPtr matHessian_, mpVectorPtr matGrad_, mpVectorPtr matNorm_)
     {func1 = f1; func2 = f2;  func3 = f3;  matX = matX_ ; matHessian = matHessian_; matGrad = matGrad_; matNorm = matNorm_; };
    mpfr_float value(const TVector &x) {
          *matX = x;
          func1(matX, matNorm);
          mpfr_float norm = (*matNorm)(0,0);
          return norm;
    }
    void gradient(const TVector &x, TVector &grad) {
        *matX = x;
        *matGrad = grad;
        func2(matX, matGrad);
        grad = *matGrad;
    }

    void hessian(const TVector &x, THessian &hessian) {
        hessian(0, 0) = 1200 * x[0] * x[0] - 400 * x[1] + 1;
        hessian(0, 1) = -400 * x[0];
        hessian(1, 0) = -400 * x[0];
        hessian(1, 1) = 200;
    }
  MpfrFuncPtr func1, func2, func3;
  mpVectorPtr matX, matHessian, matGrad, matNorm;
};



void LibMpfr_NewtonDescentSolver(MpfrFuncPtr f1, MpfrFuncPtr f2, MpfrFuncPtr f3, MpfrStatePtr matX_, MpfrStatePtr matHessian_, MpfrStatePtr matGrad_, MpfrStatePtr matNorm_, MpfrStatePtr xPtr, MpfrStatePtr resPtr)
{
 printf("NewtonDescentSolver");
    CppOptLibSolver3 f(f1, f2, f3, (mpVectorPtr)matX_, (mpVectorPtr)matHessian_, (mpVectorPtr)matGrad_, (mpVectorPtr)matNorm_);
    state_type_vec x = (*(mpVectorPtr)xPtr);
    NewtonDescentSolver<CppOptLibSolver3> solver;
    mpfr_float eps = std::numeric_limits<mpfr_float>::epsilon();
    Criteria<mpfr_float> m_stop;
    m_stop.defaults();
    m_stop.gradNorm = 1000 * eps;
    solver.setStopCriteria(m_stop);
    solver.minimize(f, x);
    (*(mpVectorPtr)matX_) = x;
    (*(mpVectorPtr)matNorm_)(0,0) = f(x);
}





void LibMpfr_CppOptLibDirect3(long what, MpfrFuncPtr f1, MpfrFuncPtr f2, MpfrFuncPtr f3, MpfrStatePtr matX, MpfrStatePtr matHessian, MpfrStatePtr matGrad, MpfrStatePtr matNorm, MpfrStatePtr xPtr, MpfrStatePtr resPtr)
{
	switch (what) {
		case mp_newton_descent_solver:LibMpfr_NewtonDescentSolver(f1, f2, f3, matX, matHessian, matGrad, matNorm, xPtr,resPtr ); break;
	}
}




