/* Arbitrary precision arithmetics in C-XSC (MPFR-MPFI)
   ====================================================

Copyright (C) 2010-11 Wiss. Rechnen/Softwaretechnologie
                      Universitaet Wuppertal, Germany

**  This library is free software; you can redistribute it and/or
**  modify it under the terms of the GNU Library General Public
**  License as published by the Free Software Foundation; either
**  version 2 of the License, or (at your option) any later version.
**
**  This library is distributed in the hope that it will be useful,
**  but WITHOUT ANY WARRANTY; without even the implied warranty of
**  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
**  Library General Public License for more details.
**
**  You should have received a copy of the GNU Library General Public
**  License along with this library; if not, write to the Free
**  Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307  USA
*/

/*********************************************/
/*  Datei:  mpfcclass.cpp                    */
/*  Zweck:  C++-Wrapper-Klasse fuer die      */
/*          komplexe MPFR-Bibliothek         */
/*  Based on       mpfr-3.0.0                */
/*********************************************/
//#include "StdAfx.h"


#include "mpfcclass.hpp"
#include "mpfciclass.hpp"

namespace MPFR{

int MpfcClass::base = 10;

  /*Konstruktoren und Destruktoren*/

  MpfcClass::MpfcClass ()
  {
     mpfr_init2(mpfr_re, MPFR::MpfrClass::GetCurrPrecision());
     mpfr_init2(mpfr_im, MPFR::MpfrClass::GetCurrPrecision());
  }

  MpfcClass::MpfcClass (int x, int y, RoundingMode rnd, PrecisionType prec)
  {
     mpfr_init2(mpfr_re, prec);
     mpfr_set_si(mpfr_re, (long int)x, rnd);

     mpfr_init2(mpfr_im, prec);
     mpfr_set_si(mpfr_im, (long int)y, rnd);
  }

  MpfcClass::MpfcClass (const mpfr_t& x, const mpfr_t& y,
                        RoundingMode rnd, PrecisionType prec)
  {
    mpfr_init2(mpfr_re, prec);
    mpfr_set(mpfr_re, x, rnd);

    mpfr_init2(mpfr_im, prec);
    mpfr_set(mpfr_im, y, rnd);
  }

  MpfcClass::MpfcClass (const double& x, const double& y,
                        RoundingMode rnd, PrecisionType prec)
  {
    mpfr_init2(mpfr_re, prec);
    mpfr_set_d(mpfr_re, x, rnd);

    mpfr_init2(mpfr_im, prec);
    mpfr_set_d(mpfr_im, y, rnd);
  }


  MpfcClass::MpfcClass (const double& x,
                        RoundingMode rnd, PrecisionType prec)
  {
    mpfr_init2(mpfr_re, prec);
    mpfr_set_d(mpfr_re, x, rnd);

    mpfr_init2(mpfr_im, prec);
    mpfr_set_d(mpfr_im, 0.0, rnd);
  }

  MpfcClass::MpfcClass (const MpfrClass& x, const MpfrClass& y,
                        RoundingMode rnd, PrecisionType prec)
  // Erzeugt ein Objekt vom Typ MpfcClass, wobei x,y verschiedene Praezisionen besitzen koennen.
  // 1. Werden rnd und prec nicht angegeben, so werden x,y mit dem Current-Rundungsmodus
  //    auf die Current-Praezision gerundet.
  // 2. Wird nur rnd angegeben, so werden x,y mit dem Rundungsmodus rnd auf die
  //    Current-Praezision gerundet.
  // 3. Werden rnd und prec angegeben, so werden x,y mit dem Rundungsmodus rnd
  //    auf die Praezision prec gerundet.
  // Real- und Imaginaerteil des erzeugten Objekts erhalten also stets die gleiche Praezision!
  // Diese Praezision ist entweder die Current-Praezision oder die durch prec vorgegebene Praezision.
  {
    mpfr_init2 (mpfr_re, prec);
    mpfr_set(mpfr_re, getvalue(x), rnd);

    mpfr_init2 (mpfr_im, prec);
    mpfr_set(mpfr_im, getvalue(y), rnd);
  }

  MpfcClass::MpfcClass (int x,
                        RoundingMode rnd,
                        PrecisionType prec)
  {
     mpfr_init2(mpfr_re, prec);
     mpfr_set_si(mpfr_re, (long int)x, rnd);

     mpfr_init2(mpfr_im, prec);
     mpfr_set_si(mpfr_im, 0, rnd);
  }

  MpfcClass::MpfcClass (const MpfcClass& r, RoundingMode rnd, PrecisionType prec)
  {
    mpfr_init2(mpfr_re, prec);
    mpfr_set(mpfr_re, r.mpfr_re, rnd);

    mpfr_init2(mpfr_im, prec);
    mpfr_set(mpfr_im, r.mpfr_im, rnd);
  }

  MpfcClass::MpfcClass (const mpfr_t& x,
                        RoundingMode rnd, PrecisionType prec)
  {
    mpfr_init2(mpfr_re, prec);
    mpfr_set(mpfr_re, x, rnd);

    mpfr_init2(mpfr_im, prec);
    mpfr_set_si(mpfr_im, 0, rnd);
  }

  MpfcClass::MpfcClass (const MpfrClass& x,
                        RoundingMode rnd, PrecisionType prec)
  {
    mpfr_init2(mpfr_re, prec);
    mpfr_set(mpfr_re, getvalue(x), rnd);

    mpfr_init2(mpfr_im, prec);
    mpfr_set_si(mpfr_im, 0, rnd);
  }

  MpfcClass::MpfcClass (const std::string& s,
                        RoundingMode rnd, PrecisionType prec)
  {
    std::string str;
    int i, ik, ie;

    i  = s.find("(");
    ik = s.find(",");
    ie = s.find(")");
    if (i<0 || ik<0 || ie<0 )
    {
      std::cerr << "Error: Format (Number,Number) is required!" << std::endl;
      exit(1);
    }
    str = s.substr (i+1,ik-i-1);
    MpfrClass Re(str, rnd, prec);
    mpfr_init2(mpfr_re, prec);
    mpfr_set(mpfr_re, Re.GetValue(), rnd);

    str = s.substr (ik+1,ie-ik-1);
    MpfrClass Im(str, rnd, prec);
    mpfr_init2(mpfr_im, prec);
    mpfr_set(mpfr_im, Im.GetValue(), rnd);
  }

  MpfcClass::~MpfcClass ()
  {
     mpfr_clear(mpfr_re);
     mpfr_clear(mpfr_im);
  }


// -----------------------------------------------------------
// ------------------- MPFC --> mpfr_t -----------------------
// -----------------------------------------------------------

  // ----------- Member-Funktionen ---------------------------
  mpfr_t& MpfcClass::GetValueRe()
  {
    return this->mpfr_re;
  }

  mpfr_t& MpfcClass::GetValueIm()
  {
    return this->mpfr_im;
  }

  void MpfcClass::SetValueRe(const mpfr_t& v)
  // Der Realteil des aktuellen Objekts wird exakt auf v gesetzt.
  // Der Imaginaerteil des aktuellen Objekts bleibt erhalten.
  // Die Praezision des aktuellen Objekts wird gesetzt auf das
  // Maximum der Praezisionen von v und mpfr_im, d.h. die
  // Praezisionen von Real- und Imaginaerteil sind GLEICH!
  {
    PrecisionType precim = mpfr_get_prec(mpfr_im),
                  prec   = mpfr_get_prec(v);
    if (precim<prec)
      mpfr_prec_round(mpfr_im, prec, RoundNearest);
    else
      prec = precim;
    mpfr_set_prec(mpfr_re, prec);
    mpfr_set(mpfr_re, v, RoundNearest);
  }

  void MpfcClass::SetValueIm(const mpfr_t& v)
  // Der Imaginaerteil des aktuellen Objekts wird exakt auf v gesetzt.
  // Der Realteil des aktuellen Objekts bleibt erhalten.
  // Die Praezision des aktuellen Objekts wird gesetzt auf das
  // Maximum der Praezisionen von v und mpfr_re, d.h. die
  // Praezisionen von Real- und Imaginaerteil sind GLEICH!
  {
    PrecisionType precre = mpfr_get_prec(mpfr_re),
                  prec   = mpfr_get_prec(v);
    if (precre<prec)
      mpfr_prec_round(mpfr_re, prec, RoundNearest);
    else
      prec = precre;
    mpfr_set_prec(mpfr_im, prec);
    mpfr_set(mpfr_im, v, RoundNearest);
  }

  void MpfcClass::SetValue(const mpfr_t& re, const mpfr_t& im)
  // Real- und Imaginaerteil des aktuellen Objekts werden ohne
  // Rundung neu gesetzt auf re bzw. auf im.
  // Das aktuelle Objekt erhaelt als Praezision das Maximum der
  // Praezisionen von re und im, d.h. die Praezisionen von Real-
  // und Imaginaerteil werden auf den gleichen Wert gesetzt!
  {
    PrecisionType precre = mpfr_get_prec(re),
                  prec   = mpfr_get_prec(im);
    if (precre>prec) prec = precre;

    mpfr_set_prec(mpfr_re, prec);
    mpfr_set(mpfr_re, re, RoundNearest);
    mpfr_set_prec(mpfr_im, prec);
    mpfr_set(mpfr_im, im, RoundNearest);
  }

  // ----------- friend-Funktionen ---------------------------

  void times2pown (MpfcClass& r, const long int n, RoundingMode rnd)
  // Calculating r*2^n without changing the precision of r
  {
    mpfr_mul_2si (r.mpfr_re, r.mpfr_re, n, rnd);
    mpfr_mul_2si (r.mpfr_im, r.mpfr_im, n, rnd);
  }

  const mpfr_t& getvalueRe(const MpfcClass& v)
  {
      return v.mpfr_re;
  }

  const mpfr_t& getvalueIm(const MpfcClass& v)
  {
      return v.mpfr_im;
  }

// ----------------------------- Precision and Rounding -----------------------------------

  // Setzten der gleichen Current-Precision fuer die Klassen MpfcClass u. MpfrClass:
  void MpfcClass::SetCurrPrecision (PrecisionType newprec)
  {
     MPFR::MpfrClass::SetCurrPrecision(newprec);
  }

  // Auslesen der Current-Precision
  const PrecisionType MpfcClass::GetCurrPrecision ()
  {
     return MPFR::MpfrClass::GetCurrPrecision();
  }

  // Auslesen der Precision des aktuellen Objekts;
  // Wenn Realteil u. Imaginaerteil verschiedene Praezisionen
  // besitzen, so wird die maximale Präzision zurückgegeben.
  PrecisionType MpfcClass::GetPrecision () const
  {
    PrecisionType prec_re, prec;
    prec_re = mpfr_get_prec(mpfr_re);
    prec    = mpfr_get_prec(mpfr_im);

    if (prec_re > prec)
      prec = prec_re;

    return prec;
  }

  // Setzten der Precision fuer das aktuelle Objekt, Wert wird geloescht
  void MpfcClass::SetPrecision (PrecisionType newprec)
  {
     mpfr_set_prec(mpfr_re, newprec);
     mpfr_set_prec(mpfr_im, newprec);
  }

  // Rundet bez. rnd das aktuelle Objekt (Real- u. Imaginaerteil) auf newprec;
  void MpfcClass::RoundPrecision(PrecisionType newprec, RoundingMode rnd)
  {
     mpfr_prec_round(mpfr_re, newprec, rnd);  // Rounding the real part
     mpfr_prec_round(mpfr_im, newprec, rnd);  // Rounding the imaginary part
  }

  // Gleichen Rundungsmodus setzten in MpfcClass u. MpfrClass:
  void MpfcClass::SetCurrRndMode (RoundingMode newrndmode)
  {
     MPFR::MpfrClass::SetCurrRndMode (newrndmode);
  }

  // Auslesen des aktuellen Rundungsmodus
  const RoundingMode MpfcClass::GetCurrRndMode ()
  {
     return MPFR::MpfrClass::GetCurrRndMode();
  }

  // Setzten der Basis (Wert zwischen 2-36)
  void MpfcClass::SetBase (int b)
  {
    base = b;
  }

  // Auslesen der aktuellen Basis
  const int MpfcClass::GetBase ()
  {
    return base;
  }


  // -------------------------- Assignment Operators ----------------------------------------

  MpfcClass& MpfcClass::operator = (const MpfcClass& v)
  {
    // Assumption:
    // The real part and imaginary part of any single MpfcClass objekt have the same precision;
    // Different MpfcClass objekts may have different precisions;
    // The right object is rounded with the current roundmode to the left object
    // getting the current precision.
    if (this == &v)
    {
      (*this).RoundPrecision(MpfcClass::GetCurrPrecision(), MpfcClass::GetCurrRndMode());
      return *this;
    }
    mpfr_clear(mpfr_re);
    mpfr_init2(mpfr_re, MpfcClass::GetCurrPrecision());
    mpfr_set(mpfr_re, v.mpfr_re, MpfcClass::GetCurrRndMode());

    mpfr_clear(mpfr_im);
    mpfr_init2(mpfr_im, MpfcClass::GetCurrPrecision());
    mpfr_set(mpfr_im, v.mpfr_im, MpfcClass::GetCurrRndMode());

    return *this;
  }

  MpfcClass& MpfcClass::operator = (const MpfrClass& v)
  {
    mpfr_clear(mpfr_re);
    mpfr_init2(mpfr_re, MpfcClass::GetCurrPrecision());
    mpfr_set(mpfr_re, getvalue(v), MpfcClass::GetCurrRndMode());

    mpfr_clear(mpfr_im);
    mpfr_init2(mpfr_im, MpfcClass::GetCurrPrecision());
    mpfr_set_si(mpfr_im, 0, MpfcClass::GetCurrRndMode());

    return *this;
  }

  MpfcClass& MpfcClass::operator = (const double& v)
  {
    mpfr_clear(mpfr_re);
    mpfr_init2(mpfr_re, MpfcClass::GetCurrPrecision());
    mpfr_set_d (mpfr_re, v, MpfcClass::GetCurrRndMode());

    mpfr_clear(mpfr_im);
    mpfr_init2(mpfr_im, MpfcClass::GetCurrPrecision());
    mpfr_set_si(mpfr_im, 0, MpfcClass::GetCurrRndMode());

    return *this;
  }


  MpfcClass& MpfcClass::operator = (const int v)
  {
    mpfr_clear(mpfr_re);
    mpfr_init2(mpfr_re, MpfcClass::GetCurrPrecision());
    mpfr_set_si (mpfr_re, v, MpfcClass::GetCurrRndMode());

    mpfr_clear(mpfr_im);
    mpfr_init2(mpfr_im, MpfcClass::GetCurrPrecision());
    mpfr_set_si(mpfr_im, 0, MpfcClass::GetCurrRndMode());

    return *this;
  }


  MpfcClass& MpfcClass::operator = (const std::string& s)
  {
    PrecisionType prec = MpfrClass::GetCurrPrecision();
    RoundingMode rnd = MpfrClass::GetCurrRndMode();

    std::string str;
    int i, ik, ie;

    i  = s.find("(");
    ik = s.find(",");
    ie = s.find(")");
    if (i<0 || ik<0 || ie<0 )
    {
      std::cerr << "Error: Format (Number,Number) is required!" << std::endl;
      exit(1);
    }
    str = s.substr (i+1,ik-i-1);
    MpfrClass Re(str);
    mpfr_init2(mpfr_re, prec);
    mpfr_set(mpfr_re, Re.GetValue(), rnd);

    str = s.substr (ik+1,ie-ik-1);
    MpfrClass Im(str);
    mpfr_init2(mpfr_im, prec);
    mpfr_set(mpfr_im, Im.GetValue(), rnd);

    return *this;
  }


  // ------------------- Definition der friend-Funktionen -------------------------------------

  // op erhält die Praezision prec und den Wert von op1, wobei bez. rnd gerundet wird.
  // Ohne prec erhält op die Current-Precision, und ohne rnd wird mit dem Current-Rundungsmodus gerundet.
  void set_Mpfc (MpfcClass& op, const MpfcClass& op1, RoundingMode rnd, PrecisionType prec)
  {
    op.SetPrecision(prec);
    mpfr_set(op.mpfr_re, op1.mpfr_re, rnd);
    mpfr_set(op.mpfr_im, op1.mpfr_im, rnd);
  }

  MpfrClass Re(const MpfcClass& z)
  // Calculating Re(z) without rounding and with the
  // actual precision of z;
  {
     MpfrClass r(z.mpfr_re, RoundNearest, z.GetPrecision());
     return r;
  }

  MpfrClass Im(const MpfcClass& z)
  // See the comment of Re(...) !
  {
     MpfrClass r(z.mpfr_im, RoundNearest, z.GetPrecision());
     return r;
  }

  MpfcClass conj(const MpfcClass& z)
  {
    MpfcClass res(z, RoundNearest, z.GetPrecision());
    mpfr_neg (res.mpfr_im, res.mpfr_im, MPFR_RNDN);
    return res;
  }

  MpfrClass abs(const MpfcClass& z, RoundingMode rnd, PrecisionType prec)
  {
    MpfrClass res(0, RoundNearest, prec);
    mpfr_hypot (res.GetValue(), z.mpfr_re, z.mpfr_im, rnd);
    return res;
  }

  MpfrClass arg(const MpfcClass& z, RoundingMode rnd, PrecisionType prec)
  {
    MpfrClass res(0, RoundNearest, prec);
    mpfr_atan2(res.GetValue(), z.mpfr_im, z.mpfr_re, rnd);
    return res;
  }

  MpfrClass argp1(const MpfcClass& z, RoundingMode rnd, PrecisionType prec)
  {
    if ( rnd==MPFR_RNDZ || rnd==MPFR_RNDA)
    {
      std::cerr << "Error: argp1(z): MPFR_RNDZ and MPFR_RNDA not yet implemented!" << std::endl;
      exit(1);
    }
    PrecisionType prec_old = MpfcClass::GetCurrPrecision(),
                  Prec     = z.MpfcClass::GetPrecision();
    if (Prec < prec) Prec = prec;
    MpfcClass::SetCurrPrecision(Prec);
    MpfrClass res, xp1(Re(z)), y(Im(z));

    if (rnd==RoundUp)
    {
      if (y>0)
	mpfr_add_ui(xp1.GetValue(), xp1.GetValue(), (long)1, RoundDown);
      else // y <= 0:
	mpfr_add_ui(xp1.GetValue(), xp1.GetValue(), (long)1, rnd);
    }
    else
    {
      if (rnd==RoundDown)
      {
	if (y>=0)
	  mpfr_add_ui(xp1.GetValue(), xp1.GetValue(), (long)1, RoundUp);
	else
	  mpfr_add_ui(xp1.GetValue(), xp1.GetValue(), (long)1, rnd);
      }
      else
	mpfr_add_ui(xp1.GetValue(), xp1.GetValue(), (long)1, rnd);
    }
    mpfr_atan2(res.GetValue(), y.GetValue(), xp1.GetValue(), rnd);
    res.RoundPrecision(prec, rnd);          // Runden zur Precision prec
    MpfcClass::SetCurrPrecision(prec_old);  // Wiederherstellen der alten Current-Precision
    return res;
  }

  MpfcClass ln(const MpfcClass& z, RoundingMode rnd)
  {
    return MpfcClass( ln_sqrtx2y2(z.mpfr_re,z.mpfr_im,rnd), arg(z,rnd, MPFR::MpfrClass::GetCurrRndMode()), rnd);
  }

  MpfcClass lnp1(const MpfcClass& z, RoundingMode rnd)
  {
    return MpfcClass( ln_sqrtxp1_2y2(z.mpfr_re,z.mpfr_im,rnd), argp1(z,rnd), rnd);
  }

  MpfcClass exp (const MpfcClass& z, RoundingMode rnd)
  {
    if ( rnd==MPFR_RNDZ || rnd==MPFR_RNDA)
    {
      std::cerr << "Error: exp(z): MPFR_RNDZ and MPFR_RNDA not yet implemented!" << std::endl;
      exit(1);
    }
    PrecisionType prec_old = MpfcClass::GetCurrPrecision(),
                  prec     = z.MpfcClass::GetPrecision();
    if (prec < prec_old) prec = prec_old;
    MpfcClass::SetCurrPrecision(prec);
    MpfrClass re(0), im(0), tmp(0);
    // Calculating the real part:
    if (rnd==MPFR_RNDU)
    {
      mpfr_cos (tmp.GetValue(), z.mpfr_im, rnd);  // tmp = cos( Im(z) )
      if (tmp < 0)
        mpfr_exp (re.GetValue(), z.mpfr_re, MPFR_RNDD);
      else mpfr_exp (re.GetValue(), z.mpfr_re, rnd);
    }
    else
    {
      if (rnd==MPFR_RNDD)
      {
        mpfr_cos (tmp.GetValue(), z.mpfr_im, rnd);  // tmp = cos( Im(z) )
        if (tmp < 0)
          mpfr_exp (re.GetValue(), z.mpfr_re, MPFR_RNDU);
        else mpfr_exp (re.GetValue(), z.mpfr_re, rnd);
      }
      else // rnd==MPFR_RNDN
      {
        mpfr_cos (tmp.GetValue(), z.mpfr_im, rnd);
        mpfr_exp (re.GetValue() , z.mpfr_re, rnd);
      }
    }
    mpfr_mul (re.GetValue(), re.GetValue(), tmp.GetValue(), rnd);
    // Calculating the imaginary part:
    if (rnd==MPFR_RNDU)  // Aufrunden
    {
      mpfr_sin (tmp.GetValue(), z.mpfr_im, rnd);  // tmp = sin( Im(z) )
      if (tmp < 0)
        mpfr_exp (im.GetValue(), z.mpfr_re, MPFR_RNDD);
      else mpfr_exp (im.GetValue(), z.mpfr_re, rnd);
    }
    else
    {
      if (rnd==MPFR_RNDD)  // Abrunden
      {
        mpfr_sin (tmp.GetValue(), z.mpfr_im, rnd);  // tmp = sin( Im(z) )
        if (tmp < 0)
          mpfr_exp (im.GetValue(), z.mpfr_re, MPFR_RNDU);
        else mpfr_exp (im.GetValue(), z.mpfr_re, rnd);
      }
      else // RMD==MPFR_RNDN
      {
        mpfr_sin (tmp.GetValue(), z.mpfr_im, rnd);
        mpfr_exp (im.GetValue(), z.mpfr_re, rnd);
      }
    }
    mpfr_mul (im.GetValue(), im.GetValue(), tmp.GetValue(), rnd);
    MpfcClass res(re,im);
    res.RoundPrecision(prec_old, rnd);      // Runden zur alten Current-Precision
    MpfcClass::SetCurrPrecision(prec_old);  // Wiederherstellen der alten Current-Precision
    return res;
  }

  MpfcClass cos (const MpfcClass& z, RoundingMode rnd)
  {
    if ( rnd==MPFR_RNDZ || rnd==MPFR_RNDA)
    {
      std::cerr << "Error: cos(z): MPFR_RNDZ and MPFR_RNDA not yet implemented!" << std::endl;
      exit(1);
    }
    PrecisionType prec_old = MpfcClass::GetCurrPrecision(),
                  prec     = z.MpfcClass::GetPrecision();
    if (prec < prec_old) prec = prec_old;
    MpfcClass::SetCurrPrecision(prec);
    MpfrClass re(0), im(0), tmp(0);
    // Calculating the real part:
    if (rnd==MPFR_RNDU) // Aufrunden:
    {
      mpfr_cos (tmp.GetValue(), z.mpfr_re, rnd);  // tmp = cos( Re(z) )
      if (tmp < 0)
        mpfr_cosh (re.GetValue(), z.mpfr_im, MPFR_RNDD);
      else mpfr_cosh (re.GetValue(), z.mpfr_im, rnd);
    }
    else
    {
      if (rnd==MPFR_RNDD) // Abrunden:
      {
        mpfr_cos (tmp.GetValue(), z.mpfr_re, rnd);  // tmp = cos( Im(z) )
        if (tmp < 0)
          mpfr_cosh (re.GetValue(), z.mpfr_im, MPFR_RNDU);
        else mpfr_cosh (re.GetValue(), z.mpfr_im, rnd);
      }
      else // RMD==MPFR_RNDN
      {
        mpfr_cos (tmp.GetValue(), z.mpfr_re, rnd);
        mpfr_cosh (re.GetValue() , z.mpfr_im, rnd);
      }
    }
    mpfr_mul (re.GetValue(), re.GetValue(), tmp.GetValue(), rnd);
    // Calculating the imaginary part:
    MpfrClass y_ = -Im(z); // y_ = -y is exact because Current-Precision >= Precision(z);
    // Im(cos(z)) = sin( Re(z) ) * sinh(y_);
    if (rnd==MPFR_RNDU)  // Aufrunden
    {
      if (y_ >= 0) // ==> sinh(y_) >= 0:
        mpfr_sin (tmp.GetValue(), z.mpfr_re, rnd);  // tmp = sin( Re(z) )
      else // ==> sinh(y_) < 0:
        mpfr_sin (tmp.GetValue(), z.mpfr_re, MPFR_RNDD);  // tmp = sin( Re(z) )
      if (tmp < 0)
        mpfr_sinh (im.GetValue(), y_.GetValue(), MPFR_RNDD);
      else mpfr_sinh (im.GetValue(), y_.GetValue(), rnd);
    }
    else
    {
      if (rnd==MPFR_RNDD)  // Abrunden
      {
        if (y_ >= 0) // ==> sinh(y_) >= 0:
          mpfr_sin (tmp.GetValue(), z.mpfr_re, rnd);  // tmp = sin( Re(z) )
        else // ==> sinh(y_) < 0:
          mpfr_sin (tmp.GetValue(), z.mpfr_re, MPFR_RNDU);  // tmp = sin( Re(z) )
        if (tmp < 0)
          mpfr_sinh (im.GetValue(), y_.GetValue(), MPFR_RNDU);
        else mpfr_sinh (im.GetValue(), y_.GetValue(), rnd);
      }
      else // RoundTo Nearest, d.h. RMD == MPFR_RNDN
      {
        mpfr_sin (tmp.GetValue(), z.mpfr_re, rnd);
        mpfr_sinh (im.GetValue(), y_.GetValue(), rnd);
      }
    }
    mpfr_mul (im.GetValue(), im.GetValue(), tmp.GetValue(), rnd);
    MpfcClass res(re,im);
    res.RoundPrecision(prec_old, rnd);      // Runden zur alten Current-Precision
    MpfcClass::SetCurrPrecision(prec_old);  // Wiederherstellen der alten Current-Precision
    return res;
  }

  MpfrClass Re_cot(const MpfcClass& z, RoundingMode RMD)
  {
    PrecisionType prec_old = MpfcClass::GetCurrPrecision(),
                  prec     = z.MpfcClass::GetPrecision();
    if (prec < prec_old) prec = prec_old;
    MpfcClass::SetCurrPrecision(prec);
    MpfrClass re(0), Ne(0), tmp(0);
    re = Re(z);
    times2pown(re, 1);  // re = 2x, without rounding
    mpfr_sin (re.GetValue(), re.GetValue(), RMD); // re = sin(2x), (numerator)
    if (RMD==MPFR_RNDU) // rounding up:
    {
      if (re < 0)
      { // rounding up the denominator:
        mpfr_sin (tmp.GetValue(), z.mpfr_re, MPFR_RNDA);
        mpfr_sqr (tmp.GetValue(), tmp.GetValue(), RMD);  // tmp = sin^2(x)
        mpfr_sinh (Ne.GetValue(), z.mpfr_im, MPFR_RNDA);
        mpfr_sqr  (Ne.GetValue(), Ne.GetValue(), RMD);   // Ne = sinh^2(y)
        mpfr_add  (Ne.GetValue(), tmp.GetValue(), Ne.GetValue(), RMD);
      }
      else // re >= 0; rounding down the denominator:
      {
        mpfr_sin (tmp.GetValue(), z.mpfr_re, MPFR_RNDZ);
        mpfr_sqr (tmp.GetValue(), tmp.GetValue(), MPFR_RNDD);  // tmp = sin^2(x)
        mpfr_sinh (Ne.GetValue(), z.mpfr_im, MPFR_RNDZ);
        mpfr_sqr  (Ne.GetValue(), Ne.GetValue(), MPFR_RNDD);   // Ne = sinh^2(y)
        mpfr_add  (Ne.GetValue(), tmp.GetValue(), Ne.GetValue(), MPFR_RNDD);
      }
    }
    else
    {
      if (RMD==MPFR_RNDD) // rounding down:
      {
        if (re < 0)
        { // rounding down the denominator:
          mpfr_sin (tmp.GetValue(), z.mpfr_re, MPFR_RNDZ);
          mpfr_sqr (tmp.GetValue(), tmp.GetValue(), RMD);  // tmp = sin^2(x)
          mpfr_sinh (Ne.GetValue(), z.mpfr_im, MPFR_RNDZ);
          mpfr_sqr  (Ne.GetValue(), Ne.GetValue(), RMD);   // Ne = sinh^2(y)
          mpfr_add  (Ne.GetValue(), tmp.GetValue(), Ne.GetValue(), RMD);
        }
        else // re >= 0; rounding up the denominator:
        {
          mpfr_sin (tmp.GetValue(), z.mpfr_re, MPFR_RNDA);
          mpfr_sqr (tmp.GetValue(), tmp.GetValue(), MPFR_RNDU);  // tmp = sin^2(x)
          mpfr_sinh (Ne.GetValue(), z.mpfr_im, MPFR_RNDA);
          mpfr_sqr  (Ne.GetValue(), Ne.GetValue(), MPFR_RNDU);   // Ne = sinh^2(y)
          mpfr_add  (Ne.GetValue(), tmp.GetValue(), Ne.GetValue(), MPFR_RNDU);
        }
      }
      else // RMD==MPFR_RNDN
      {
        mpfr_sin (tmp.GetValue(), z.mpfr_re, RMD);
        mpfr_sqr (tmp.GetValue(), tmp.GetValue(), RMD);  // tmp = sin^2(x)
        mpfr_sinh (Ne.GetValue(), z.mpfr_im, RMD);
        mpfr_sqr  (Ne.GetValue(), Ne.GetValue(), RMD);   // Ne = sinh^2(y)
        mpfr_add  (Ne.GetValue(), tmp.GetValue(), Ne.GetValue(), RMD);
      }
    }
    times2pown(Ne, 1); // Ne = 2*( sin^2(x) + sinh^2(y) )
    mpfr_div (re.GetValue(), re.GetValue(), Ne.GetValue(), RMD);
    re.RoundPrecision(prec_old, RMD);      // Runden zur alten Current-Precision
    MpfcClass::SetCurrPrecision(prec_old); // Wiederherstellen der alten Current-Precision
    return re;
  }

  MpfrClass Im_cot(const MpfcClass& z, RoundingMode RMD)
  {
    PrecisionType prec_old = MpfcClass::GetCurrPrecision(),
                  prec     = z.MpfcClass::GetPrecision();
    if (prec < prec_old) prec = prec_old;
    MpfcClass::SetCurrPrecision(prec);
    MpfrClass im(0), Ne(0), tmp(0);
    im = -Im(z);
    times2pown(im, 1);  // im = -2y, without rounding
    mpfr_sinh (im.GetValue(), im.GetValue(), RMD); // im = sinh(-2y), (numerator)
    if (RMD==MPFR_RNDU) // rounding up:
    {
      if (im < 0)
      { // rounding up the denominator:
        mpfr_sin (tmp.GetValue(), z.mpfr_re, MPFR_RNDA);
        mpfr_sqr (tmp.GetValue(), tmp.GetValue(), RMD);  // tmp = sin^2(x)
        mpfr_sinh (Ne.GetValue(), z.mpfr_im, MPFR_RNDA);
        mpfr_sqr  (Ne.GetValue(), Ne.GetValue(), RMD);   // Ne = sinh^2(y)
        mpfr_add  (Ne.GetValue(), tmp.GetValue(), Ne.GetValue(), RMD);
      }
      else // im >= 0; rounding down the denominator:
      {
        mpfr_sin (tmp.GetValue(), z.mpfr_re, MPFR_RNDZ);
        mpfr_sqr (tmp.GetValue(), tmp.GetValue(), MPFR_RNDD);  // tmp = sin^2(x)
        mpfr_sinh (Ne.GetValue(), z.mpfr_im, MPFR_RNDZ);
        mpfr_sqr  (Ne.GetValue(), Ne.GetValue(), MPFR_RNDD);   // Ne = sinh^2(y)
        mpfr_add  (Ne.GetValue(), tmp.GetValue(), Ne.GetValue(), MPFR_RNDD); // Ne = sin^2(x) + sinh^2(y);
      }
    }
    else
    {
      if (RMD==MPFR_RNDD) // rounding down:
      {
        if (im < 0)
        { // rounding down the denominator:
          mpfr_sin (tmp.GetValue(), z.mpfr_re, MPFR_RNDZ);
          mpfr_sqr (tmp.GetValue(), tmp.GetValue(), RMD);  // tmp = sin^2(x)
          mpfr_sinh (Ne.GetValue(), z.mpfr_im, MPFR_RNDZ);
          mpfr_sqr  (Ne.GetValue(), Ne.GetValue(), RMD);   // Ne = sinh^2(y)
          mpfr_add  (Ne.GetValue(), tmp.GetValue(), Ne.GetValue(), RMD);
        }
        else // im >= 0; rounding up the denominator:
        {
          mpfr_sin (tmp.GetValue(), z.mpfr_re, MPFR_RNDA);
          mpfr_sqr (tmp.GetValue(), tmp.GetValue(), MPFR_RNDU);  // tmp = sin^2(x)
          mpfr_sinh (Ne.GetValue(), z.mpfr_im, MPFR_RNDA);
          mpfr_sqr  (Ne.GetValue(), Ne.GetValue(), MPFR_RNDU);   // Ne = sinh^2(y)
          mpfr_add  (Ne.GetValue(), tmp.GetValue(), Ne.GetValue(), MPFR_RNDU);
        }
      }
      else // RMD==MPFR_RNDN
      {
        mpfr_sin (tmp.GetValue(), z.mpfr_re, RMD);
        mpfr_sqr (tmp.GetValue(), tmp.GetValue(), RMD);  // tmp = sin^2(x)
        mpfr_sinh (Ne.GetValue(), z.mpfr_im, RMD);
        mpfr_sqr  (Ne.GetValue(), Ne.GetValue(), RMD);   // Ne = sinh^2(y)
        mpfr_add  (Ne.GetValue(), tmp.GetValue(), Ne.GetValue(), RMD); // Ne = sin^2(x) + sinh^2(y)
      }
    }
    times2pown(Ne, 1); // Ne = 2*( sin^2(x) + sinh^2(y) )
    mpfr_div (im.GetValue(), im.GetValue(), Ne.GetValue(), RMD);
    im.RoundPrecision(prec_old, RMD);      // Runden zur alten Current-Precision
    MpfcClass::SetCurrPrecision(prec_old); // Wiederherstellen der alten Current-Precision
    return im;
  }

  MpfcClass cot (const MpfcClass& z, RoundingMode rnd)
  // z = Re(z) + i*Im(z) = x + i*y;
  {
    if ( rnd==MPFR_RNDZ || rnd==MPFR_RNDA)
    {
      std::cerr << "Error: cot(z): MPFR_RNDZ and MPFR_RNDA not yet implemented!" << std::endl;
      exit(1);
    }
    MpfrClass re(0), im(0);
    re = Re_cot(z, rnd);
    im = Im_cot(z, rnd);
    return MpfcClass(re,im);
  }

  MpfrClass asin_T(const MpfcClass& z, bool& scal, RoundingMode rnd)
  // z = x + i*y;
  // Calculating: ( sqrt((x+1)^2 + y^2) + sqrt((x-1)^2 + y^2) )/2 = T(x,y);
  // The return value is calculated in a Current-Precision which is greater or equal
  // to the precision of z.
  // If scal=true the returned value res must be multiplicated by 8 to get T(x,y).
  // Because of T(-x,y) = T(x,y) the term T(x,y) can here be calculated
  // with the assumption x >= 0:
  {
    const int p = 1073741821;  // p = expo( MaxFloat()/(2*sqrt(2))-1 ) mit prec = 2;
    const int k = 3;           // Skalierung mit 2^ (-k);
    scal = false;
    MpfrClass res(0), y_a(0), x_a(0), M(0);
    y_a = abs( Im(z) );  x_a = abs( Re(z) ); // y_a = |y|; Exakt!   x_a = |x|; Exakt!
    M = y_a;
    if (x_a>M)
      M = x_a;    // M = max{|x|,|y|};
    scal = (expo(M) >= p);
    M = 1;
    if (scal)
    {
      times2pown(M, -k);  // M = 1/2^k = 1/8 is exact, even with prec = 2 !
      times2pown(y_a, -k, rnd);
    }
    if (rnd == MPFR_RNDU) // Rounding Up:
    { // Berechnung der 2. Wurzel:
      if (x_a >= 1)
      {
        if (scal)
          times2pown(x_a, -k, rnd);
        mpfr_sub(x_a.GetValue(), x_a.GetValue(), M.GetValue(), rnd);
      }
      else // 0 <= x_a < 1:
      {
        if (scal)
          times2pown(x_a, -k, MPFR_RNDD);
        mpfr_sub(x_a.GetValue(), x_a.GetValue(), M.GetValue(), MPFR_RNDD);
      }
      // x_a = |x|/2^k - 1/2^k, falls skaliert wurde, sonst x_a = |x|-1;
    }
    else
    {
      if (rnd == MPFR_RNDD)
      { // Berechnung der 2. Wurzel:
        if (x_a >= 1)
        {
          if (scal)
            times2pown(x_a, -k, rnd);
          mpfr_sub(x_a.GetValue(), x_a.GetValue(), M.GetValue(), rnd);
        }
        else // 0 <= x_a < 1:
        {
          if (scal)
          times2pown(x_a, -k, MPFR_RNDU);
          mpfr_sub(x_a.GetValue(), x_a.GetValue(), M.GetValue(), MPFR_RNDU);
        }
        // x_a = |x|/2^k - 1/2^k, falls skaliert wurde, sonst x_a = |x|-1;
      }
      else // round to nearest:
      {
        // Berechnung der 2. Wurzel:
        if (scal)
            times2pown(x_a, -k, rnd);
        mpfr_sub(x_a.GetValue(), x_a.GetValue(), M.GetValue(), rnd);
      }
        // x_a = |x|/2^k - 1/2^k, falls skaliert wurde, sonst x_a = |x|-1;
    }
    res = sqrtx2y2(x_a, y_a, rnd); // res = 2. Wurzel
    // Jetzt folgt die Berechnung der 1. Wurzel:
    x_a = abs( Re(z) );  // x_a = |x|; exakt !
    if (scal)
      times2pown(x_a, -k, rnd); // |x| wird wegen Skalierung der Wurzeln durch 8 dividiert.
    mpfr_add(x_a.GetValue(), x_a.GetValue(), M.GetValue(), rnd);
    x_a = sqrtx2y2(x_a, y_a, rnd); // x_a = 1. Wurzel
    mpfr_add(res.GetValue(), x_a.GetValue(), res.GetValue(), rnd); // res = Wurzelsumme
    times2pown(res, -1, rnd);  // res = T(x,y);

    return res;
  }

  MpfrClass acosh_T(const MpfcClass& z, RoundingMode rnd)
  // Mit  T(x,y) := ( sqrt((x+1)^2 + y^2) + sqrt((x-1)^2 + y^2) )/2;
  // wird acosh(T) berechnet in einer Praezision, die
  // mindestens so gross ist wie die Praezision von z.
  {
    const double dbl=0.125;
    MpfrClass res(0), T(0), v(0);
    bool scal=true;

    T = asin_T(z, scal, rnd);
    if (scal)
    // T_u := unskalierter T-Wert;
    // T_s := skalierter T-Wert, d.h. T_u = 8*T_s;
    // acosh(T_u) = log(8T_s + sqrt(64T_s^2-1))
    //            = log(8) + log(T_s + sqrt(T_s^2-1/64))
    //            = 3*log(2) + log(T_s + sqrt(T_s-1/8)*sqrt(T_s+1/8))
    {
      mpfr_sub_d(res.GetValue(), T.GetValue(), dbl, rnd);
      mpfr_sqrt (res.GetValue(), res.GetValue(), rnd); // res = sqrt(T-0.125);
      mpfr_add_d(v.GetValue(), T.GetValue(), dbl, rnd);// v = T + 0.125;
      mpfr_sqrt (v.GetValue(), v.GetValue(), rnd);     // v = sqrt(T+0.125);
      mpfr_mul(res.GetValue(), res.GetValue(), v.GetValue(), rnd); // res = sqrt(T^2-1/64);
      mpfr_add(res.GetValue(), res.GetValue(), T.GetValue(), rnd); // res = T + sqrt(T^2-1/64);
      mpfr_log(res.GetValue(), res.GetValue(), rnd); // res = log(T + sqrt(T^2-1/64));
      v = MPFR::MpfrClass::Ln2(rnd);
      mpfr_mul_ui(v.GetValue(), v.GetValue(), 3, rnd); // v = 3*log(2) = log(8);
      mpfr_add(res.GetValue(), res.GetValue(), v.GetValue(), rnd);
    }
    else
      res = acosh(T,rnd);

    return res;
  }

  MpfrClass asin_rA(const MpfcClass& z, RoundingMode rnd)
  {
    MpfrClass res(0), x_a(0), y_a(0);
    x_a = abs(Re(z));  y_a = abs(Im(z));

    if (rnd == RoundUp)
    {
      mpfr_add_si(res.GetValue(), x_a.GetValue(), 1, RoundDown);     // res = |x|+1, abgerundet
    }
    else
    {
      if (rnd == RoundDown)
      {
        mpfr_add_si(res.GetValue(), x_a.GetValue(), 1, RoundUp);       // res = |x|+1, aufgerundet
      }
      else // rnd = RoundNearest
      {
        mpfr_add_si(res.GetValue(), x_a.GetValue(), 1, rnd);
      }
    }
    mpfr_div(res.GetValue(), y_a.GetValue(), res.GetValue(), rnd);
    mpfr_sqr(res.GetValue(), res.GetValue(), rnd);
    res = sqrtp1m1(res, rnd);
    mpfr_add_si(x_a.GetValue(), x_a.GetValue(), 1, rnd);
    mpfr_mul(res.GetValue(), res.GetValue(), x_a.GetValue(), rnd);

    return res;
  }

  MpfrClass acoshp1_r(const MpfcClass& z, RoundingMode rnd)
  {
    MpfrClass res(0), x_a(0), y_a(0);
    x_a = abs(Re(z));  y_a = abs(Im(z));
    if (x_a == 1)
      res = y_a;
    else
    {
      if (x_a > 1)
      {
        mpfr_sub_si(x_a.GetValue(), x_a.GetValue(), 1, rnd);
        mpfr_hypot(res.GetValue(), x_a.GetValue(), y_a.GetValue(), rnd);
        mpfr_add(res.GetValue(), res.GetValue(), x_a.GetValue(), rnd);
      }
      else // |x| < 1:
      {
        if (rnd == RoundUp)
        {
          mpfr_si_sub(res.GetValue(), 1, x_a.GetValue(), RoundDown);
        }
        else
        {
          if (rnd == RoundDown)
          {
            mpfr_si_sub(res.GetValue(), 1, x_a.GetValue(), RoundUp);
          }
          else // RoundNearest
          {
            mpfr_si_sub(res.GetValue(), 1, x_a.GetValue(),rnd);
          }
        }
        mpfr_div(res.GetValue(), y_a.GetValue(), res.GetValue(), rnd);
        mpfr_sqr(res.GetValue(), res.GetValue(), rnd);
        res = sqrtp1m1(res, rnd);
        mpfr_si_sub(x_a.GetValue(), 1, x_a.GetValue(), rnd);
        mpfr_mul(res.GetValue(), res.GetValue(), x_a.GetValue(), rnd);
      }
    }
    x_a = asin_rA(z, rnd);
    mpfr_add(res.GetValue(), res.GetValue(), x_a.GetValue(), rnd);
    times2pown(res, -1, rnd); // res = T-1;

    res = acoshp1(res, rnd);

    return res;
  }

  MpfrClass Re_asin (const MpfcClass& z, RoundingMode rnd)
  {
    PrecisionType prec_old = MpfcClass::GetCurrPrecision(),
                  prec     = z.MpfcClass::GetPrecision();
    if (prec < prec_old) prec = prec_old;
    MpfcClass::SetCurrPrecision(prec);

    MpfrClass x(0), T(0); // x,T haben die Praezision prec
    bool scal;
    x = Re(z); // Exakt!
    if (Im(z)==0) // y = 0
    {
      if (x<-1)  // Re_asin(z) = -Pi/2
        x = -1;
      else
      {
        if (x>1) // Re_asin(z) = +Pi/2
          x = +1;
      }
      mpfr_asin(x.GetValue(), x.GetValue(), rnd);
    }
    else  // y <> 0:
    {
      if (rnd==MPFR_RNDU) // Rounding Up:
        T = (x>=0)? asin_T(z, scal, MPFR_RNDD) : asin_T(z, scal, MPFR_RNDU);
      else
      {
        if (rnd==MPFR_RNDD) // Rounding Down:
          T = (x>=0)? asin_T(z, scal, MPFR_RNDU) : asin_T(z, scal, MPFR_RNDD);
        else // Round To Nearest:
          T = asin_T(z, scal, rnd);
      }
      if (scal)
        times2pown(x, -3, rnd); // Wegen Skalierung Division des Zaehlers durch 8;
      mpfr_div(x.GetValue(), x.GetValue(), T.GetValue(), rnd);    // x = x/T(x,y);
      if (x>1)  x = 1;
      if (x<-1) x = -1;
      mpfr_asin(x.GetValue(), x.GetValue(), rnd);
    }
    x.RoundPrecision(prec_old, rnd);       // Runden zur alten Current-Precision
    MpfcClass::SetCurrPrecision(prec_old); // Wiederherstellen der alten Current-Precision
    return x;
  } // Re_asin()

  MpfrClass Im_asin (const MpfcClass& z, RoundingMode rnd)
  {
    PrecisionType prec_old = MpfcClass::GetCurrPrecision(),
                  prec     = z.MpfcClass::GetPrecision();
    if (prec < prec_old) prec = prec_old;
    MpfcClass::SetCurrPrecision(prec);
    MpfrClass im(0), x_a(0), y_a(0);

    x_a = abs(Re(z));  y_a = abs(Im(z));
    if (x_a<1.125 && y_a<0.125) // acosh(1+r)  Urspruenglich: if (x_a<2 && y_a<1)
    {
      std::cout << "Rechnung mit: acosh(1+r)" << std::endl;
      if ( (Im(z)==0 && Re(z)>=1) || Im(z)<0 )
      {
        if (rnd==RoundUp)
          im = -acoshp1_r(z, RoundDown);
        else
        {
          if (rnd==RoundDown)
            im = -acoshp1_r(z, RoundUp);
          else im = -acoshp1_r(z, RoundNearest);
        }
      }
      else
        im = acoshp1_r(z, rnd);
    }
    else // acosh(T)
    {
      if ( (Im(z)==0 && Re(z)>=1) || Im(z)<0 )
      {
        if (rnd==RoundUp)
          im = -acosh_T(z, RoundDown);
        else
        {
          if (rnd==RoundDown)
            im = -acosh_T(z, RoundUp);
          else im = -acosh_T(z, RoundNearest);
        }
      }
      else
        im = acosh_T(z, rnd);
    }
    im.RoundPrecision(prec_old, rnd);      // Runden zur alten Current-Precision
    MpfcClass::SetCurrPrecision(prec_old); // Wiederherstellen der alten Current-Precision
    return im;
  }

  MpfcClass asin(const MpfcClass& z, RoundingMode rnd)
  // z = Re(z) + i*Im(z) = x + i*y;
  {
    if ( rnd==MPFR_RNDZ || rnd==MPFR_RNDA)
    {
      std::cerr << "Error: asin(z): MPFR_RNDZ and MPFR_RNDA not yet implemented!" << std::endl;
      exit(1);
    }
    MpfrClass re(0), im(0);

    re = Re_asin(z, rnd);
    im = Im_asin(z, rnd);

    return MpfcClass(re, im);
  }

  MpfrClass Re_acos (const MpfcClass& z, RoundingMode rnd)
  {
    PrecisionType prec_old = MpfcClass::GetCurrPrecision(),
                  prec     = z.MpfcClass::GetPrecision();
    if (prec < prec_old) prec = prec_old;
    MpfcClass::SetCurrPrecision(prec);

    MpfrClass x(0), T(0); // x,T haben die Praezision prec
    bool scal;
    x = Re(z); // Exakt!
    if (Im(z)==0) // y = 0
    {
      if (x<-1)  // Re_acos(z) = Pi
        x = -1;
      else
      {
        if (x>1) // Re_acos(z) = 0
          x = +1;
      }
      mpfr_acos(x.GetValue(), x.GetValue(), rnd);
    }
    else  // y <> 0:
    {
      if (rnd==MPFR_RNDU) // Rounding Up:
      {
        T = (x>=0)? asin_T(z, scal, MPFR_RNDU) : asin_T(z, scal, MPFR_RNDD);
        if (scal) times2pown(x, -2, MPFR_RNDD);
        mpfr_div(x.GetValue(), x.GetValue(), T.GetValue(), MPFR_RNDD);
      }
      else
      {
        if (rnd==MPFR_RNDD) // Rounding Down:
        {
          T = (x>=0)? asin_T(z, scal, MPFR_RNDD) : asin_T(z, scal, MPFR_RNDU);
          if (scal) times2pown(x, -2, MPFR_RNDU);
          mpfr_div(x.GetValue(), x.GetValue(), T.GetValue(), MPFR_RNDU);
        }
        else // Round To Nearest:
        {
          T = asin_T(z, scal, rnd);
          if (scal) times2pown(x, -2, rnd);
          mpfr_div(x.GetValue(), x.GetValue(), T.GetValue(), rnd);
        }
      }
      if (x>1)  x = 1;
      if (x<-1) x = -1;
      mpfr_acos(x.GetValue(), x.GetValue(), rnd);
    }
    x.RoundPrecision(prec_old, rnd);       // Runden zur alten Current-Precision
    MpfcClass::SetCurrPrecision(prec_old); // Wiederherstellen der alten Current-Precision
    return x;
  } // Re_acos()

  MpfrClass Im_acos (const MpfcClass& z, RoundingMode rnd)
  // Im( arccos(z) ) = -Im( arcsin(z) );
  {
    MpfrClass res(0);
    if (rnd==RoundUp)
      res = -Im_asin(z, RoundDown);
    else
    {
      if (rnd==RoundDown)
        res = -Im_asin(z, RoundUp);
      else res = -Im_asin(z, rnd);
    }
    return res;
  }

  MpfcClass acos(const MpfcClass& z, RoundingMode rnd)
  // z = Re(z) + i*Im(z) = x + i*y;
  {
    if ( rnd==MPFR_RNDZ || rnd==MPFR_RNDA)
    {
      std::cerr << "Error: acos(z): MPFR_RNDZ and MPFR_RNDA not yet implemented!" << std::endl;
      exit(1);
    }
    MpfrClass re(0), im(0);

    re = Re_acos(z, rnd);
    im = Im_acos(z, rnd);

    return MpfcClass(re, im);
  }

  MpfcClass sin (const MpfcClass& z, RoundingMode rnd)
  {
    if ( rnd==MPFR_RNDZ || rnd==MPFR_RNDA)
    {
      std::cerr << "Error: sin(z): MPFR_RNDZ and MPFR_RNDA not yet implemented!" << std::endl;
      exit(1);
    }
    PrecisionType prec_old = MpfcClass::GetCurrPrecision(),
                  prec     = z.MpfcClass::GetPrecision();
    if (prec < prec_old) prec = prec_old;
    MpfcClass::SetCurrPrecision(prec);
    MpfrClass re(0), im(0), tmp(0);
    // Calculating the real part: sin(x)*cosh(y)
    if (rnd==MPFR_RNDU) // Aufrunden:
    {
      mpfr_sin (tmp.GetValue(), z.mpfr_re, rnd);  // tmp = sin( Re(z) ) = sin(x)
      if (tmp < 0)
        mpfr_cosh (re.GetValue(), z.mpfr_im, MPFR_RNDD);
      else mpfr_cosh (re.GetValue(), z.mpfr_im, rnd);
    }
    else
    {
      if (rnd==MPFR_RNDD) // Abrunden:
      {
        mpfr_sin (tmp.GetValue(), z.mpfr_re, rnd);  // tmp = sin( Im(z) )
        if (tmp < 0)
          mpfr_cosh (re.GetValue(), z.mpfr_im, MPFR_RNDU);
        else mpfr_cosh (re.GetValue(), z.mpfr_im, rnd);
      }
      else // rnd==MPFR_RNDN
      {
        mpfr_sin (tmp.GetValue(), z.mpfr_re, rnd);
        mpfr_cosh (re.GetValue() , z.mpfr_im, rnd);
      }
    }
    mpfr_mul (re.GetValue(), re.GetValue(), tmp.GetValue(), rnd);
    // Calculating the imaginary part:
    // Im(sin(z)) = cos( Re(z) ) * sinh(Im(z));
    if (rnd==MPFR_RNDU)  // Aufrunden
    {
      if (Im(z) >= 0) // ==> sinh( Im(z) ) >= 0:
        mpfr_cos (tmp.GetValue(), z.mpfr_re, rnd);        // tmp = cos( Re(z) )
      else // ==> sinh( Im(z) ) < 0:
        mpfr_cos (tmp.GetValue(), z.mpfr_re, MPFR_RNDD);  // tmp = cos( Re(z) )
      if (tmp < 0)
        mpfr_sinh (im.GetValue(), z.mpfr_im, MPFR_RNDD);
      else mpfr_sinh (im.GetValue(), z.mpfr_im, rnd);
    }
    else
    {
      if (rnd==MPFR_RNDD)  // Abrunden
      {
        if (Im(z) >= 0) // ==> sinh( Im(z) ) >= 0:
          mpfr_cos (tmp.GetValue(), z.mpfr_re, rnd);        // tmp = cos( Re(z) )
        else // ==> sinh(y_) < 0:
          mpfr_cos (tmp.GetValue(), z.mpfr_re, MPFR_RNDU);  // tmp = cos( Re(z) )
        if (tmp < 0)
          mpfr_sinh (im.GetValue(), z.mpfr_im, MPFR_RNDU);
        else mpfr_sinh (im.GetValue(), z.mpfr_im, rnd);
      }
      else // RoundTo Nearest, d.h. rnd == MPFR_RNDN
      {
        mpfr_cos (tmp.GetValue(), z.mpfr_re, rnd);
        mpfr_sinh (im.GetValue(), z.mpfr_im, rnd);
      }
    }
    mpfr_mul (im.GetValue(), im.GetValue(), tmp.GetValue(), rnd);
    MpfcClass res(re,im);
    res.RoundPrecision(prec_old, rnd);      // Runden zur alten Current-Precision
    MpfcClass::SetCurrPrecision(prec_old);  // Wiederherstellen der alten Current-Precision
    return res;
  }

  MpfcClass tan (const MpfcClass& z, RoundingMode rnd)
  // z = Re(z) + i*Im(z) = x + i*y;
  {
    if ( rnd==MPFR_RNDZ || rnd==MPFR_RNDA)
    {
      std::cerr << "Error: tan(z): MPFR_RNDZ and MPFR_RNDA not yet implemented!" << std::endl;
      exit(1);
    }
    PrecisionType prec_old = MpfcClass::GetCurrPrecision(),
                  prec     = z.MpfcClass::GetPrecision();
    if (prec < prec_old) prec = prec_old;
    MpfcClass::SetCurrPrecision(prec);
    MpfrClass re(0), im(0), Ne(0), tmp(0);
    // Calculating the real part:
    re = Re(z);  // re = x exact!
    times2pown(re, 1);  // re = 2x, without rounding
    mpfr_sin (re.GetValue(), re.GetValue(), rnd); // re = sin(2x), (numerator)
    if (rnd==MPFR_RNDU) // rounding up:
    {
      if (re < 0)
      { // rounding up the denominator:
        mpfr_cos (tmp.GetValue(), z.mpfr_re, MPFR_RNDA);
        mpfr_sqr (tmp.GetValue(), tmp.GetValue(), rnd);  // tmp = cos^2(x)
        mpfr_sinh (Ne.GetValue(), z.mpfr_im, MPFR_RNDA);
        mpfr_sqr  (Ne.GetValue(), Ne.GetValue(), rnd);   // Ne = sinh^2(y)
        mpfr_add  (Ne.GetValue(), tmp.GetValue(), Ne.GetValue(), rnd);
      }
      else // re >= 0; rounding down the denominator:
      {
        mpfr_cos (tmp.GetValue(), z.mpfr_re, MPFR_RNDZ);
        mpfr_sqr (tmp.GetValue(), tmp.GetValue(), MPFR_RNDD);  // tmp = cos^2(x)
        mpfr_sinh (Ne.GetValue(), z.mpfr_im, MPFR_RNDZ);
        mpfr_sqr  (Ne.GetValue(), Ne.GetValue(), MPFR_RNDD);   // Ne = sinh^2(y)
        mpfr_add  (Ne.GetValue(), tmp.GetValue(), Ne.GetValue(), MPFR_RNDD);
      }
    }
    else
    {
      if (rnd==MPFR_RNDD) // rounding down:
      {
        if (re < 0)
        { // rounding down the denominator:
          mpfr_cos (tmp.GetValue(), z.mpfr_re, MPFR_RNDZ);
          mpfr_sqr (tmp.GetValue(), tmp.GetValue(), rnd);  // tmp = cos^2(x)
          mpfr_sinh (Ne.GetValue(), z.mpfr_im, MPFR_RNDZ);
          mpfr_sqr  (Ne.GetValue(), Ne.GetValue(), rnd);   // Ne = sinh^2(y)
          mpfr_add  (Ne.GetValue(), tmp.GetValue(), Ne.GetValue(), rnd);
        }
        else // re >= 0; rounding up the denominator:
        {
          mpfr_cos (tmp.GetValue(), z.mpfr_re, MPFR_RNDA);
          mpfr_sqr (tmp.GetValue(), tmp.GetValue(), MPFR_RNDU);  // tmp = cos^2(x)
          mpfr_sinh (Ne.GetValue(), z.mpfr_im, MPFR_RNDA);
          mpfr_sqr  (Ne.GetValue(), Ne.GetValue(), MPFR_RNDU);   // Ne = sinh^2(y)
          mpfr_add  (Ne.GetValue(), tmp.GetValue(), Ne.GetValue(), MPFR_RNDU);
        }
      }
      else // rnd==MPFR_RNDN
      {
        mpfr_cos (tmp.GetValue(), z.mpfr_re, rnd);
        mpfr_sqr (tmp.GetValue(), tmp.GetValue(), rnd);  // tmp = cos^2(x)
        mpfr_sinh (Ne.GetValue(), z.mpfr_im, rnd);
        mpfr_sqr  (Ne.GetValue(), Ne.GetValue(), rnd);   // Ne = sinh^2(y)
        mpfr_add  (Ne.GetValue(), tmp.GetValue(), Ne.GetValue(), rnd);
      }
    }
    times2pown(Ne, 1); // Ne = 2*( cos^2(x) + sinh^2(y) )
    re /= Ne;
    // Calculating the imaginary part:
    im = Im(z);
    times2pown(im, 1);  // im = 2y, without rounding
    mpfr_sinh (im.GetValue(), im.GetValue(), rnd); // im = sinh(2y), (numerator)
    if (rnd==MPFR_RNDU) // rounding up:
    {
      if (im < 0)
      { // rounding up the denominator:
        mpfr_cos (tmp.GetValue(), z.mpfr_re, MPFR_RNDA);
        mpfr_sqr (tmp.GetValue(), tmp.GetValue(), rnd);  // tmp = cos^2(x)
        mpfr_sinh (Ne.GetValue(), z.mpfr_im, MPFR_RNDA);
        mpfr_sqr  (Ne.GetValue(), Ne.GetValue(), rnd);   // Ne = sinh^2(y)
        mpfr_add  (Ne.GetValue(), tmp.GetValue(), Ne.GetValue(), rnd);
      }
      else // im >= 0; rounding down the denominator:
      {
        mpfr_cos (tmp.GetValue(), z.mpfr_re, MPFR_RNDZ);
        mpfr_sqr (tmp.GetValue(), tmp.GetValue(), MPFR_RNDD);  // tmp = cos^2(x)
        mpfr_sinh (Ne.GetValue(), z.mpfr_im, MPFR_RNDZ);
        mpfr_sqr  (Ne.GetValue(), Ne.GetValue(), MPFR_RNDD);   // Ne = sinh^2(y)
        mpfr_add  (Ne.GetValue(), tmp.GetValue(), Ne.GetValue(), MPFR_RNDD);
      }
    }
    else
    {
      if (rnd==MPFR_RNDD) // rounding down:
      {
        if (im < 0)
        { // rounding down the denominator:
          mpfr_cos (tmp.GetValue(), z.mpfr_re, MPFR_RNDZ);
          mpfr_sqr (tmp.GetValue(), tmp.GetValue(), rnd);  // tmp = cos^2(x)
          mpfr_sinh (Ne.GetValue(), z.mpfr_im, MPFR_RNDZ);
          mpfr_sqr  (Ne.GetValue(), Ne.GetValue(), rnd);   // Ne = sinh^2(y)
          mpfr_add  (Ne.GetValue(), tmp.GetValue(), Ne.GetValue(), rnd);
        }
        else // im >= 0; rounding up the denominator:
        {
          mpfr_cos (tmp.GetValue(), z.mpfr_re, MPFR_RNDA);
          mpfr_sqr (tmp.GetValue(), tmp.GetValue(), MPFR_RNDU);  // tmp = cos^2(x)
          mpfr_sinh (Ne.GetValue(), z.mpfr_im, MPFR_RNDA);
          mpfr_sqr  (Ne.GetValue(), Ne.GetValue(), MPFR_RNDU);   // Ne = sinh^2(y)
          mpfr_add  (Ne.GetValue(), tmp.GetValue(), Ne.GetValue(), MPFR_RNDU);
        }
      }
      else // rnd==MPFR_RNDN
      {
        mpfr_cos (tmp.GetValue(), z.mpfr_re, rnd);
        mpfr_sqr (tmp.GetValue(), tmp.GetValue(), rnd);  // tmp = cos^2(x)
        mpfr_sinh (Ne.GetValue(), z.mpfr_im, rnd);
        mpfr_sqr  (Ne.GetValue(), Ne.GetValue(), rnd);   // Ne = sinh^2(y)
        mpfr_add  (Ne.GetValue(), tmp.GetValue(), Ne.GetValue(), rnd);
      }
    }
    times2pown(Ne, 1); // Ne = 2*( cos^2(x) + sinh^2(y) )
    im /= Ne;
    MpfcClass res(re,im);
    res.RoundPrecision(prec_old, rnd);      // Runden zur alten Current-Precision
    MpfcClass::SetCurrPrecision(prec_old);  // Wiederherstellen der alten Current-Precision
    return res;
  }

  MpfcClass atan(const MpfcClass& z, RoundingMode rnd)
  {
    if ( rnd==MPFR_RNDZ || rnd==MPFR_RNDA)
    {
      std::cerr << "Error: atan(z): MPFR_RNDZ and MPFR_RNDA not yet implemented!" << std::endl;
      exit(1);
    }
    MPFI::MpfciClass zi(z);
    zi = atan(zi);
    if (rnd==RoundUp)
      return Sup(zi);
    else if (rnd==RoundDown)
      return Inf(zi);
    else return mid(zi);
  }

  MpfcClass acot(const MpfcClass& z, RoundingMode rnd)
  {
    if ( rnd==MPFR_RNDZ || rnd==MPFR_RNDA)
    {
      std::cerr << "Error: acot(z): MPFR_RNDZ and MPFR_RNDA not yet implemented!" << std::endl;
      exit(1);
    }
    MPFI::MpfciClass zi(z);
    zi = acot(zi);
    if (rnd==RoundUp)
      return Sup(zi);
    else if (rnd==RoundDown)
      return Inf(zi);
    else return mid(zi);
  }

  MpfcClass asinh(const MpfcClass& z, RoundingMode rnd)
  {
    if ( rnd==MPFR_RNDZ || rnd==MPFR_RNDA)
    {
      std::cerr << "Error: asinh(z): MPFR_RNDZ and MPFR_RNDA not yet implemented!" << std::endl;
      exit(1);
    }
    MPFI::MpfciClass zi(z);
    zi = asinh(zi);
    if (rnd==RoundUp)
      return Sup(zi);
    else if (rnd==RoundDown)
      return Inf(zi);
    else return mid(zi);
  }

  MpfcClass acosh(const MpfcClass& z, RoundingMode rnd)
  {
    if ( rnd==MPFR_RNDZ || rnd==MPFR_RNDA)
    {
      std::cerr << "Error: acosh(z): MPFR_RNDZ and MPFR_RNDA not yet implemented!" << std::endl;
      exit(1);
    }
    MPFI::MpfciClass zi(z);
    zi = acosh(zi);
    if (rnd==RoundUp)
      return Sup(zi);
    else if (rnd==RoundDown)
      return Inf(zi);
    else return mid(zi);
  }

  MpfcClass atanh(const MpfcClass& z, RoundingMode rnd)
  {
    if ( rnd==MPFR_RNDZ || rnd==MPFR_RNDA)
    {
      std::cerr << "Error: atanh(z): MPFR_RNDZ and MPFR_RNDA not yet implemented!" << std::endl;
      exit(1);
    }
    MPFI::MpfciClass zi(z);
    zi = atanh(zi);
    if (rnd==RoundUp)
      return Sup(zi);
    else if (rnd==RoundDown)
      return Inf(zi);
    else return mid(zi);
  }

  MpfcClass acoth(const MpfcClass& z, RoundingMode rnd)
  {
    if ( rnd==MPFR_RNDZ || rnd==MPFR_RNDA)
    {
      std::cerr << "Error: acoth(z): MPFR_RNDZ and MPFR_RNDA not yet implemented!" << std::endl;
      exit(1);
    }
    MPFI::MpfciClass zi(z);
    zi = acoth(zi);
    if (rnd==RoundUp)
      return Sup(zi);
    else if (rnd==RoundDown)
      return Inf(zi);
    else return mid(zi);
  }

  MpfcClass sqrt(const MpfcClass& z, int n, RoundingMode rnd)
  {
    if ( rnd==MPFR_RNDZ || rnd==MPFR_RNDA)
    {
      std::cerr << "Error: sqrt(z,n): MPFR_RNDZ and MPFR_RNDA not yet implemented!" << std::endl;
      exit(1);
    }
    MPFI::MpfciClass zi(z);
    zi = sqrt(zi,n);
    if (rnd==RoundUp)
      return Sup(zi);
    else if (rnd==RoundDown)
      return Inf(zi);
    else return mid(zi);
  }

  MpfcClass exp2(const MpfcClass& z, RoundingMode rnd)
  {
    if ( rnd==MPFR_RNDZ || rnd==MPFR_RNDA)
    {
      std::cerr << "Error: exp2(z): MPFR_RNDZ and MPFR_RNDA not yet implemented!" << std::endl;
      exit(1);
    }
    MPFI::MpfciClass zi(z);
    zi = exp2(zi);
    if (rnd==RoundUp)
      return Sup(zi);
    else if (rnd==RoundDown)
      return Inf(zi);
    else return mid(zi);
  }

  MpfcClass exp10(const MpfcClass& z, RoundingMode rnd)
  {
    if ( rnd==MPFR_RNDZ || rnd==MPFR_RNDA)
    {
      std::cerr << "Error: exp10(z): MPFR_RNDZ and MPFR_RNDA not yet implemented!" << std::endl;
      exit(1);
    }
    MPFI::MpfciClass zi(z);
    zi = exp10(zi);
    if (rnd==RoundUp)
      return Sup(zi);
    else if (rnd==RoundDown)
      return Inf(zi);
    else return mid(zi);
  }

  std::list<MpfcClass> sqrt_all(const MpfcClass& z, int n, RoundingMode rnd)
  {
    if ( rnd==MPFR_RNDZ || rnd==MPFR_RNDA)
    {
      std::cerr << "Error: sqrt_all(z,n): MPFR_RNDZ and MPFR_RNDA not yet implemented!" << std::endl;
      exit(1);
    }
    MPFI::MpfciClass zi(z), ci;
    std::list<MPFI::MpfciClass> resci;
    std::list<MpfcClass> res;
    resci = sqrt_all(zi,n);

    std::list<MPFI::MpfciClass>::iterator pos;
    int k(0);
    for (pos = resci.begin(); pos != resci.end(); ++pos)
    {
      k++;
      ci = *pos;
      if (rnd==RoundUp)
        res.push_back( Sup(ci) );
      else if (rnd==RoundDown)
        res.push_back( Inf(ci) );
      else res.push_back( mid(ci) );
    }

    return res;
  }

  std::list<MpfcClass> sqrt_all(const MpfcClass& z, RoundingMode rnd)
  {
    if ( rnd==MPFR_RNDZ || rnd==MPFR_RNDA)
    {
      std::cerr << "Error: sqrt_all(z): MPFR_RNDZ and MPFR_RNDA not yet implemented!" << std::endl;
      exit(1);
    }
    MPFI::MpfciClass zi(z), ci;
    std::list<MPFI::MpfciClass> resci;
    std::list<MpfcClass> res;
    resci = sqrt_all(zi);

    std::list<MPFI::MpfciClass>::iterator pos;
    int k(0);
    for (pos = resci.begin(); pos != resci.end(); ++pos)
    {
      k++;
      ci = *pos;
      if (rnd==RoundUp)
        res.push_back( Sup(ci) );
      else if (rnd==RoundDown)
        res.push_back( Inf(ci) );
      else res.push_back( mid(ci) );
    }

    return res;
  }

  MpfcClass power(const MpfcClass& z, int n, RoundingMode rnd)
  {
    if ( rnd==MPFR_RNDZ || rnd==MPFR_RNDA)
    {
      std::cerr << "Error: power(z,n): MPFR_RNDZ and MPFR_RNDA not yet implemented!" << std::endl;
      exit(1);
    }
    MPFI::MpfciClass zi(z);
    zi = power_fast(zi,n);
    if (rnd==RoundUp)
      return Sup(zi);
    else if (rnd==RoundDown)
      return Inf(zi);
    else return mid(zi);
  }

  MpfcClass pow(const MpfcClass& z, const MPFR::MpfrClass& p, RoundingMode rnd)
  {
    if ( rnd==MPFR_RNDZ || rnd==MPFR_RNDA)
    {
      std::cerr << "Error: pow(z,r): MPFR_RNDZ and MPFR_RNDA not yet implemented!" << std::endl;
      exit(1);
    }
    MPFI::MpfciClass zi(z);
    MPFI::MpfiClass pi(p);
    zi = pow(zi,pi);
    if (rnd==RoundUp)
      return Sup(zi);
    else if (rnd==RoundDown)
      return Inf(zi);
    else return mid(zi);
  }

  MpfcClass pow(const MpfcClass& z, const MpfcClass& w, RoundingMode rnd)
  {
    if ( rnd==MPFR_RNDZ || rnd==MPFR_RNDA)
    {
      std::cerr << "Error: pow(z,w): MPFR_RNDZ and MPFR_RNDA not yet implemented!" << std::endl;
      exit(1);
    }
    MPFI::MpfciClass zi(z);
    MPFI::MpfciClass wi(w);
    zi = pow(zi,wi);
    if (rnd==RoundUp)
      return Sup(zi);
    else if (rnd==RoundDown)
      return Inf(zi);
    else return mid(zi);
  }

  MpfcClass log2(const MpfcClass& z, RoundingMode rnd)
  {
    if ( rnd==MPFR_RNDZ || rnd==MPFR_RNDA)
    {
      std::cerr << "Error: log2(z): MPFR_RNDZ and MPFR_RNDA not yet implemented!" << std::endl;
      exit(1);
    }
    MPFI::MpfciClass zi(z);
    zi = log2(zi);
    if (rnd==RoundUp)
      return Sup(zi);
    else if (rnd==RoundDown)
      return Inf(zi);
    else return mid(zi);
  }

  MpfcClass log10(const MpfcClass& z, RoundingMode rnd)
  {
    if ( rnd==MPFR_RNDZ || rnd==MPFR_RNDA)
    {
      std::cerr << "Error: log10(z): MPFR_RNDZ and MPFR_RNDA not yet implemented!" << std::endl;
      exit(1);
    }
    MPFI::MpfciClass zi(z);
    zi = log10(zi);
    if (rnd==RoundUp)
      return Sup(zi);
    else if (rnd==RoundDown)
      return Inf(zi);
    else return mid(zi);
  }

  MpfcClass sinh (const MpfcClass& z, RoundingMode rnd)
  // z = x + i*y;
  // sinh(z) = Im( sin(y+ix) ) +i*Re( sin(y+ix) )
  {
    MpfcClass z_(Im(z), Re(z), rnd, z.GetPrecision());  // z_ = y + i*x; Exakt!
    z_ = sin(z_, rnd);
    return MpfcClass( Im(z_), Re(z_) );
  }

  MpfcClass cosh (const MpfcClass& z, RoundingMode rnd)
  // z = x + i*y;
  // cosh(z) = cos( i*z ) = cos(-y +i*x)
  {
    MpfcClass z_(-Im(z), Re(z), rnd, z.GetPrecision());  // z_ = -y + i*x;
    return cos(z_, rnd);
  }

  MpfcClass tanh (const MpfcClass& z, RoundingMode rnd)
  // z = x + i*y;
  // tanh(z) = Im( tan(y+ix) ) + i*Re( tan(y+ix) );
  {
    MpfcClass z_(Im(z), Re(z), rnd, z.GetPrecision());  // z_ = y + i*x;
    z_ = tan(z_, rnd);
    return MpfcClass(Im(z_), Re(z_));
  }

  MpfcClass coth (const MpfcClass& z, RoundingMode rnd)
  // z = x + i*y;
  // coth(z) = -Im( cot(y+ix) ) + i*Re( cot(y+ix) );
  {
    if ( rnd==MPFR_RNDZ || rnd==MPFR_RNDA)
    {
      std::cerr << "Error: coth(z): MPFR_RNDZ and MPFR_RNDA not yet implemented!" << std::endl;
      exit(1);
    }
    MpfcClass z_(-Im(z), Re(z), rnd, z.GetPrecision());  // z_ = -y + i*x; Exakt!
    MpfrClass re (0), im(0);

    re = Re_cot(z_, rnd);
    if (rnd == MPFR_RNDU)
      im = Im_cot(z_, MPFR_RNDD);
    else
    {
      if (rnd == MPFR_RNDD)
        im = Im_cot(z_, MPFR_RNDU);
      else im = Im_cot(z_, rnd);
    }
    return MpfcClass(-im, re);
  }

  MpfcClass sqr (const MpfcClass& z, RoundingMode rnd)
  {
    if ( rnd==MPFR_RNDZ || rnd==MPFR_RNDA)
    {
      std::cerr << "Error: sqr(z): MPFR_RNDZ and MPFR_RNDA not yet implemented!" << std::endl;
      exit(1);
    }
    PrecisionType prec_old = MpfcClass::GetCurrPrecision(),
                  prec     = z.MpfcClass::GetPrecision();
    if (prec < prec_old) prec = prec_old;
    MpfcClass::SetCurrPrecision(prec);

    MpfrClass re(0),im(0);
    re = x2my2(z.mpfr_re, z.mpfr_im, rnd);     // re = (Re(z))^2 - (Im(z))^2;
    // Berechnung des Imaginaerteils:
    if ( abs(Re(z))<abs(Im(z)) ) // |x| < |y|:
    {
      im = Re(z);
      if (rnd == RoundUp)
      {
        if (Im(z)<0)
          times2pown(im, 1, RoundDown);
        else times2pown(im, 1, rnd);
      }
      else
      {
        if (rnd == RoundDown)
        {
          if (Im(z)<0)
            times2pown(im, 1, RoundUp);
          else times2pown(im, 1, rnd);
        }
        else // RoundNearest:
        {
          times2pown(im, 1, rnd);
        }
      }
      mpfr_mul(im.GetValue(), im.GetValue(), z.mpfr_im, rnd);
    }
    else  // |y| <= |x|:
    {
      im = Im(z);
      if (rnd == RoundUp)
      {
        if (Re(z)<0)
          times2pown(im, 1, RoundDown);
        else times2pown(im, 1, rnd);
      }
      else
      {
        if (rnd == RoundDown)
        {
          if (Re(z)<0)
            times2pown(im, 1, RoundUp);
          else times2pown(im, 1, rnd);
        }
        else // RoundNearest:
        {
          times2pown(im, 1, rnd);
        }
      }
      mpfr_mul(im.GetValue(), im.GetValue(), z.mpfr_re, rnd);
    }

    MpfcClass res(re, im, rnd);
    res.RoundPrecision(prec_old, rnd);      // Runden zur alten Current-Precision
    MpfcClass::SetCurrPrecision(prec_old);  // Wiederherstellen der alten Current-Precision

    return res;
  }

  MpfrClass Sqrt_zpx (const MpfrClass& x, const MpfrClass& y, const RoundingMode rnd)
  // z = x + i*y;  x >= 0; y <> 0;
  // The conditions x>= 0 and y <> 0 will not be checked here!
  // |z| := sqrt(x^2+y^2);
  // Sqrt_zpx returns:   sqrt(2) * sqrt(|z|+x) = sqrt(2*(|z|+x)) in the
  // Current-Precision, which is greater or equal Precision(x), Precision(y);
  // Only MPFR_RNDN, MPFR_RNDD, MPFR_RNDU may be used, this is not checked here!
  {
    MpfrClass res(0.0);
    const int c1 = expo(MaxFloat()) - 4,
              k  = 4;
    long int ex_x(expo(x)), ex_y(expo(y));
    MpfrClass t(0.0);
    t = x; // Exact!

    if (ex_x >= c1 || ex_y >= c1)
    { // To avoid overflow scaling is necessary:
      MpfrClass absy(0.0);
      absy = abs(y); // Exact!
      times2pown(absy, -k, rnd);
      times2pown(t   , -k, rnd);
      mpfr_hypot(res.GetValue(), t.GetValue(), absy.GetValue(), rnd);  // res = |z|, (scaled)
      mpfr_add(res.GetValue(), res.GetValue(), t.GetValue(), rnd);     // res = |z| + x, (scaled)
      times2pown(res, 1, rnd);  // because of the factor sqrt(2) !
      mpfr_sqrt(res.GetValue(), res.GetValue(), rnd);
      times2pown(res, 2, rnd);  // Backscaling
    }
    else // Normal calculation without scaling:
    {
      res = sqrtx2y2(x, y, rnd);
      mpfr_add(res.GetValue(), res.GetValue(), t.GetValue(), rnd);
      times2pown(res, 1, rnd);
      mpfr_sqrt(res.GetValue(), res.GetValue(), rnd);
    }

    return res;
  }

  MpfcClass sqrt(const MpfcClass& z, RoundingMode rnd)
  {
    if ( rnd==MPFR_RNDZ || rnd==MPFR_RNDA)
    {
      std::cerr << "Error: sqrt(z): MPFR_RNDZ and MPFR_RNDA not yet implemented!" << std::endl;
      exit(1);
    }
    PrecisionType prec_old = MpfcClass::GetCurrPrecision(),
                  prec     = z.MpfcClass::GetPrecision();
    if (prec < prec_old) prec = prec_old;
    MpfcClass::SetCurrPrecision(prec);
    MpfrClass re(0), im(0), xa(0);

    if ( mpfr_zero_p(z.mpfr_im) != 0 )  // Im(z) = 0:
    {
      if ( mpfr_greaterequal_p(z.mpfr_re, re.GetValue()) != 0 )  // Re(z) >= 0:
        mpfr_sqrt(re.GetValue(), z.mpfr_re, rnd);  // re = sqrt(Re(z)), im = 0.0;
      else // Re(z) < 0:
      {
        re = im;  // re = 0;
        im = sqrt(-Re(z), rnd);
      }
    }
    else // Im(z) <> 0:
    {
      xa = abs( Re(z) );  // xa = |x| exakt!
      if (rnd == MPFR_RNDU) // Aufrunden:
      {
        if ( mpfr_greaterequal_p(z.mpfr_re, re.GetValue()) != 0 )  // Re(z) >= 0:
        {
          re = Sqrt_zpx(xa, z.mpfr_im, rnd);
          times2pown(re, -1, rnd);  // re = Re( sqrt(z) )
          im = (Im(z)>0)? Sqrt_zpx(xa, z.mpfr_im, MPFR_RNDD) : Sqrt_zpx(xa, z.mpfr_im, MPFR_RNDU);
          mpfr_div(im.GetValue(), z.mpfr_im, im.GetValue(), rnd);  // im = Im( sqrt(z) )
        }
        else // Re(z) < 0:
        {
          re = abs( Im(z) ); // Exakt!
          im = Sqrt_zpx(xa, z.mpfr_im, MPFR_RNDD);
          mpfr_div(re.GetValue(), re.GetValue(), im.GetValue(), rnd); // re = Re( sqrt(z) )
          im = (Im(z)>0)? Sqrt_zpx(xa, z.mpfr_im, MPFR_RNDU) : -Sqrt_zpx(xa, z.mpfr_im, MPFR_RNDD);
          times2pown(im, -1, rnd);  // im = Im( sqrt(z) )
        }
      }
      else
      {
        if (rnd == MPFR_RNDD) // Abrunden:
        {
          if ( Re(z) >= 0 )  // Re(z) >= 0:
          {
            re = Sqrt_zpx(xa, z.mpfr_im, rnd);
            times2pown(re, -1, rnd);
            im = (Im(z)>0)? Sqrt_zpx(xa, z.mpfr_im, MPFR_RNDU) : Sqrt_zpx(xa, z.mpfr_im, MPFR_RNDD);
            mpfr_div(im.GetValue(), z.mpfr_im, im.GetValue(), rnd);
          }
          else // Re(z) < 0:
          {
            re = abs( Im(z) );
            im = Sqrt_zpx(xa, z.mpfr_im, MPFR_RNDU);
            mpfr_div(re.GetValue(), re.GetValue(), im.GetValue(), rnd); // re = Re( sqrt(z) )
            im = (Im(z)>0)? Sqrt_zpx(xa, z.mpfr_im, MPFR_RNDD) : -Sqrt_zpx(xa, z.mpfr_im, MPFR_RNDU);
            times2pown(im, -1, rnd);  // im = Im( sqrt(z) )
          }
        }
        else // RoundToNearest, d.h. rnd == MPFR_RNDN
        {
          if ( Re(z) >= 0 )  // Re(z) >= 0:
          {
            re = Sqrt_zpx(xa, z.mpfr_im, rnd);
            times2pown(re, -1, rnd);
            im = Sqrt_zpx(xa, z.mpfr_im, rnd);
            mpfr_div(im.GetValue(), z.mpfr_im, im.GetValue(), rnd);
          }
          else // Re(z) < 0:
          {
            re = abs( Im(z) );
            im = Sqrt_zpx(xa, z.mpfr_im, rnd);
            mpfr_div(re.GetValue(), re.GetValue(), im.GetValue(), rnd); // re = Re( sqrt(z) )
            im = Sqrt_zpx(xa, z.mpfr_im, rnd);
            if (Im(z)<0) im = -im;
            times2pown(im, -1, rnd);  // im = Im( sqrt(z) )
          }
        }
      }

    }

    MpfcClass res(re,im);
    res.RoundPrecision(prec_old, rnd);      // Runden zur alten Current-Precision
    MpfcClass::SetCurrPrecision(prec_old);  // Wiederherstellen der alten Current-Precision
    return res;
  }

  // ------------------- Definition der friend-Funktionen Ende -------------------------------

  void set_nan (MpfcClass& a)
  {
    MPFR::MpfrClass x(0, RoundNearest, a.GetPrecision());
    set_nan(x);
    MpfcClass tmp(x, x, RoundNearest, a.GetPrecision() );
    set_Mpfc(a, tmp, RoundNearest, a.GetPrecision());
  }

  void set_inf (MpfcClass& a, const int k)                                             // Blomquist, 25.05.2010
  {
    MPFR::MpfrClass x(0, MPFR::MpfrClass::GetCurrRndMode(), a.GetPrecision());
    set_inf(x, k);
    MpfcClass tmp(x, x, RoundNearest, a.GetPrecision());
    set_Mpfc(a, tmp, RoundNearest, a.GetPrecision());
  }

  void set_zero (MpfcClass& a)
  {
    MPFR::MpfrClass x(0, MPFR::MpfrClass::GetCurrRndMode(), a.GetPrecision());
    set_zero(x,0);
    MpfcClass tmp(x, x, RoundNearest, a.GetPrecision());
    set_Mpfc(a, tmp, RoundNearest, a.GetPrecision());
  }

  bool isNan(const MpfcClass& v)
  {
    return ( mpfr_nan_p(v.mpfr_re)!=0 || mpfr_nan_p(v.mpfr_im)!=0 );
  }

  bool isZero(const MpfcClass& v)
  {
    return ( mpfr_zero_p(v.mpfr_re)!=0 && mpfr_zero_p(v.mpfr_im)!=0 );
  }

  bool isInf(const MpfcClass& v)
  {
    return ( mpfr_inf_p(v.mpfr_re)!=0 || mpfr_inf_p(v.mpfr_im)!=0 );
  }

  bool isNumber(const MpfcClass& v)
  {
    return ( mpfr_number_p(v.mpfr_re)!=0 && mpfr_number_p(v.mpfr_im)!=0 );
  }

// ---------------------------- Arithmetische Operatoren --------------------------------------------------

// ---------------------------- Addition -----------------------------------------
  MpfcClass MpfcClass::operator + () const
  {
    MpfcClass res(0.0, RoundNearest, this->GetPrecision());
    mpfr_set(res.mpfr_re, mpfr_re, MpfcClass::GetCurrRndMode());
    mpfr_set(res.mpfr_im, mpfr_im, MpfcClass::GetCurrRndMode());
    return res;
  }

  MpfcClass operator + (const MpfcClass& a, const MpfcClass& b)
  {
    MpfcClass z(0); // z mit 0 initialisieren und seine Praezision auf Curren-Precision setzen
    mpfr_add(z.mpfr_re, a.mpfr_re, b.mpfr_re, MpfcClass::GetCurrRndMode());
    mpfr_add(z.mpfr_im, a.mpfr_im, b.mpfr_im, MpfcClass::GetCurrRndMode());
    return z;
  }

  MpfcClass operator + (const MpfcClass& a, const double& b)
  {
    MpfcClass v(0);
    mpfr_add_d(v.mpfr_re, a.mpfr_re, b, MpfcClass::GetCurrRndMode());
    mpfr_set(v.mpfr_im, a.mpfr_im, MpfcClass::GetCurrRndMode());
    return v;
  }

  MpfcClass operator + (const MpfcClass& a, const int b)
  {
    MpfcClass v(0);
    mpfr_add_si(v.mpfr_re, a.mpfr_re, (long int)b, MpfcClass::GetCurrRndMode());
    mpfr_set(v.mpfr_im, a.mpfr_im, MpfcClass::GetCurrRndMode());
    return v;
  }


  MpfcClass operator + (const MpfcClass& a, const MpfrClass& b)
  {
    MpfcClass z(0);
    mpfr_add(z.mpfr_re, a.mpfr_re, getvalue(b), MpfcClass::GetCurrRndMode());
    mpfr_set(z.mpfr_im, a.mpfr_im, MpfcClass::GetCurrRndMode());
    return z;
  }

  MpfcClass operator + (const MpfcClass& a, const mpfr_t& b)
  {
    MpfcClass z(0);
    mpfr_add(z.mpfr_re, a.mpfr_re, b, MpfcClass::GetCurrRndMode());
    mpfr_set(z.mpfr_im, a.mpfr_im, MpfcClass::GetCurrRndMode());
    return z;
  }


  MpfcClass operator + (const double& b, const MpfcClass& a)
  {
    return a+b;
  }

  MpfcClass operator + (const int b, const MpfcClass& a)
  {
    return a+b;
  }


  MpfcClass operator + (const MpfrClass& b, const MpfcClass& a)
  {
    return a+b;
  }

  MpfcClass operator + (const mpfr_t& b, const MpfcClass& a)
  {
    return a+b;
  }


  MpfcClass& operator += (MpfcClass& a, const MpfcClass& b)
  {
    return a = a+b;
  }

  MpfcClass& operator += (MpfcClass& a, const double& b)
  {
    return a = a+b;
  }

  MpfcClass& operator += (MpfcClass& a, const int b)
  {
    return a = a+b;
  }


  MpfcClass& operator += (MpfcClass& a, const MpfrClass& b)
  {
    return a = a+b;
  }

  MpfcClass& operator += (MpfcClass& a, const mpfr_t& b)
  {
    return a = a+b;
  }

  MpfcClass& operator -= (MpfcClass& a, const MpfcClass& b)
  {
    return a = a-b;
  }

  MpfcClass& operator -= (MpfcClass& a, const double& b)
  {
    return a = a-b;
  }

  MpfcClass& operator -= (MpfcClass& a, const int b)
  {
    return a = a-b;
  }


  MpfcClass& operator -= (MpfcClass& a, const MpfrClass& b)
  {
    return a = a-b;
  }

  MpfcClass& operator -= (MpfcClass& a, const mpfr_t& b)
  {
    return a = a-b;
  }

// ---------------------------- Subtraction -----------------------------------------
  MpfcClass MpfcClass::operator - () const
  {
    MpfcClass res(0.0, RoundNearest, this->GetPrecision());
    mpfr_neg(res.mpfr_re, mpfr_re, MpfcClass::GetCurrRndMode());
    mpfr_neg(res.mpfr_im, mpfr_im, MpfcClass::GetCurrRndMode());
    return res;
  }

  MpfcClass operator - (const MpfcClass& a, const MpfcClass& b)
  {
    MpfcClass z(0); // z mit 0 initialisieren und seine Praezision auf Curren-Precision setzen
    mpfr_sub(z.mpfr_re, a.mpfr_re, b.mpfr_re, MpfcClass::GetCurrRndMode());
    mpfr_sub(z.mpfr_im, a.mpfr_im, b.mpfr_im, MpfcClass::GetCurrRndMode());
    return z;
  }

  MpfcClass operator - (const MpfcClass& a, const double& b)
  {
    MpfcClass v(0);
    mpfr_sub_d(v.mpfr_re, a.mpfr_re, b, MpfcClass::GetCurrRndMode());
    mpfr_set(v.mpfr_im, a.mpfr_im, MpfcClass::GetCurrRndMode());
    return v;
  }

  MpfcClass operator - (const MpfcClass& a, const int b)
  {
    MpfcClass v(0);
    mpfr_sub_si(v.mpfr_re, a.mpfr_re, (long int)b, MpfcClass::GetCurrRndMode());
    mpfr_set(v.mpfr_im, a.mpfr_im, MpfcClass::GetCurrRndMode());
    return v;
  }


  MpfcClass operator - (const MpfcClass& a, const MpfrClass& b)
  {
    MpfcClass z(0);
    mpfr_sub(z.mpfr_re, a.mpfr_re, getvalue(b), MpfcClass::GetCurrRndMode());
    mpfr_set(z.mpfr_im, a.mpfr_im, MpfcClass::GetCurrRndMode());
    return z;
  }

  MpfcClass operator - (const MpfcClass& a, const mpfr_t& b)
  {
    MpfcClass z(0);
    mpfr_sub(z.mpfr_re, a.mpfr_re, b, MpfcClass::GetCurrRndMode());
    mpfr_set(z.mpfr_im, a.mpfr_im, MpfcClass::GetCurrRndMode());
    return z;
  }

  MpfcClass operator - (const double& b, const MpfcClass& a)
  {
    MpfcClass v(0);
    mpfr_d_sub(v.mpfr_re, b, a.mpfr_re, MpfcClass::GetCurrRndMode());
    mpfr_neg (v.mpfr_im, a.mpfr_im, MpfcClass::GetCurrRndMode());
    return v;
  }

  MpfcClass operator - (const int b, const MpfcClass& a)
  {
    MpfcClass v(0);
    mpfr_si_sub(v.mpfr_re, (long int)b, a.mpfr_re, MpfcClass::GetCurrRndMode());
    mpfr_neg (v.mpfr_im, a.mpfr_im, MpfcClass::GetCurrRndMode());
    return v;
  }


  MpfcClass operator - (const MpfrClass& b, const MpfcClass& a)
  {
    MpfcClass z(0);
    mpfr_sub(z.mpfr_re, getvalue(b), a.mpfr_re, MpfcClass::GetCurrRndMode());
    mpfr_neg (z.mpfr_im, a.mpfr_im, MpfcClass::GetCurrRndMode());
    return z;
  }

  MpfcClass operator - (const mpfr_t& b, const MpfcClass& a)
  {
    MpfcClass z(0);
    mpfr_sub(z.mpfr_re, b, a.mpfr_re, MpfcClass::GetCurrRndMode());
    mpfr_neg (z.mpfr_im, a.mpfr_im, MpfcClass::GetCurrRndMode());
    return z;
  }

// ---------------------------- Multiplication -----------------------------------------
  MpfcClass operator * (const MpfcClass& a, const MpfcClass& b)
  {
    MpfrClass re(0), im(0);
    scal_prod(re, a.mpfr_re, b.mpfr_re, -Im(a), b.mpfr_im);    // Rounding with respect to the DefaultRndMode,
    scal_prod(im, a.mpfr_im, b.mpfr_re, a.mpfr_re, b.mpfr_im); // which is identical in MpfcClass and MpfrClass !

    return MpfcClass(re,im);
  }

  MpfcClass operator * (const MpfcClass& a, const double& b)
  {
    MpfcClass v(0);
    mpfr_mul_d(v.mpfr_re, a.mpfr_re, b, MpfcClass::GetCurrRndMode());
    mpfr_mul_d(v.mpfr_im, a.mpfr_im, b, MpfcClass::GetCurrRndMode());
    return v;
  }

  MpfcClass operator * (const MpfcClass& a, const int b)
  {
    MpfcClass v(0);
    mpfr_mul_si(v.mpfr_re, a.mpfr_re, (long int)b, MpfcClass::GetCurrRndMode());
    mpfr_mul_si(v.mpfr_im, a.mpfr_im, (long int)b, MpfcClass::GetCurrRndMode());
    return v;
  }


  MpfcClass operator * (const MpfcClass& a, const MpfrClass& b)
  {
    MpfcClass z(0);
    mpfr_mul(z.mpfr_re, a.mpfr_re, getvalue(b), MpfcClass::GetCurrRndMode());
    mpfr_mul(z.mpfr_im, a.mpfr_im, getvalue(b), MpfcClass::GetCurrRndMode());
    return z;
  }

  MpfcClass operator * (const MpfcClass& a, const mpfr_t& b)
  {
    MpfcClass z(0);
    mpfr_mul(z.mpfr_re, a.mpfr_re, b, MpfcClass::GetCurrRndMode());
    mpfr_mul(z.mpfr_im, a.mpfr_im, b, MpfcClass::GetCurrRndMode());
    return z;
  }

  MpfcClass operator * (const double& b, const MpfcClass& a)
  {
    return a*b;
  }

  MpfcClass operator * (const int b, const MpfcClass& a)
  {
    return a*b;
  }


  MpfcClass operator * (const MpfrClass& b, const MpfcClass& a)
  {
    return a*b;
  }

  MpfcClass operator * (const mpfr_t& b, const MpfcClass& a)
  {
    return a*b;
  }

  MpfcClass& operator *= (MpfcClass& a, const MpfcClass& b)
  {
    return a = a*b;
  }

  MpfcClass& operator *= (MpfcClass& a, const double& b)
  {
    return a = a*b;
  }

  MpfcClass& operator *= (MpfcClass& a, const int b)
  {
    return a = a*b;
  }


  MpfcClass& operator *= (MpfcClass& a, const MpfrClass& b)
  {
    return a = a*b;
  }

  MpfcClass& operator *= (MpfcClass& a, const mpfr_t& b)
  {
    return a = a*b;
  }

// ---------------------------- Division -----------------------------------------
  MpfcClass operator / (const MpfcClass& a, const MpfcClass& b)
  // The real and imaginary parts of the quotient a/b are rounded with
  // respect to the actual DefaultRndMode;
  // The rounding-modes MPFR_RNDZ and MPFR_RNDA generate an arror message.
  {
    MpfrClass re(0), im(0);
    // Calculating the real and imaginary part of (a+ib) / (x+iy)
    re = Compl_Re(a.mpfr_re, a.mpfr_im, b.mpfr_re, b.mpfr_im);  // Rounding with respect to the CurrRndMode, which is
    im = Compl_Im(a.mpfr_re, a.mpfr_im, b.mpfr_re, b.mpfr_im);  // identical in MpfcClass and MpfrClass !
    return MpfcClass(re,im);
  }

  MpfcClass operator / (const double& a, const MpfcClass& b)
  // a is exactly rounded to a variable of type MpfcClass.
  // The real and imaginary parts of the quotient a/b are rounded with
  // respect to the actual Current-RoundingMode;
  // The rounding-modes MPFR_RNDZ and MPFR_RNDA generate an arror message.
  {
    return MpfcClass(a, RoundNearest, 53) / b;
  }

  MpfcClass operator / (const int a, const MpfcClass& b)
  // a is exactly rounded to a variable of type MpfcClass.
  // The real and imaginary parts of the quotient a/b are rounded with
  // respect to the actual DefaultRndMode;
  // The rounding-modes MPFR_RNDZ and MPFR_RNDA generate an arror message.
  {
    return MpfcClass(a, RoundNearest, 64) / b;
  }


  MpfcClass operator / (const MpfrClass& a, const MpfcClass& b)
  // The real and imaginary parts of the quotient a/b are rounded with
  // respect to the actual DefaultRndMode;
  // The rounding-modes MPFR_RNDZ and MPFR_RNDA generate an arror message.
  {
    return MpfcClass(MpfcClass(a, RoundNearest, a.GetPrecision())) / b;
  }

  MpfcClass operator / (const mpfr_t& a, const MpfcClass& b)
  // The real and imaginary parts of the quotient a/b are rounded with
  // respect to the actual DefaultRndMode;
  // The rounding-modes MPFR_RNDZ and MPFR_RNDA generate an arror message.
  {
    return MpfcClass(MpfcClass(a, RoundNearest, mpfr_get_prec(a))) / b;
  }

  MpfcClass operator / (const MpfcClass& a, const MpfrClass& b)
  {
    MpfcClass z(0);
    mpfr_div(z.mpfr_re, a.mpfr_re, getvalue(b), MpfcClass::GetCurrRndMode());
    mpfr_div(z.mpfr_im, a.mpfr_im, getvalue(b), MpfcClass::GetCurrRndMode());
    return z;
  }

  MpfcClass operator / (const MpfcClass& a, const mpfr_t& b)
  {
    MpfcClass z(0);
    mpfr_div(z.mpfr_re, a.mpfr_re, b, MpfcClass::GetCurrRndMode());
    mpfr_div(z.mpfr_im, a.mpfr_im, b, MpfcClass::GetCurrRndMode());
    return z;
  }

  MpfcClass operator / (const MpfcClass& a, const double& b)
  {
    MpfcClass v(0);
    mpfr_div_d(v.mpfr_re, a.mpfr_re, b, MpfcClass::GetCurrRndMode());
    mpfr_div_d(v.mpfr_im, a.mpfr_im, b, MpfcClass::GetCurrRndMode());
    return v;
  }

  MpfcClass operator / (const MpfcClass& a, const int b)
  {
    MpfcClass v(0);
    mpfr_div_si(v.mpfr_re, a.mpfr_re, (long int)b, MpfcClass::GetCurrRndMode());
    mpfr_div_si(v.mpfr_im, a.mpfr_im, (long int)b, MpfcClass::GetCurrRndMode());
    return v;
  }


  MpfcClass& operator /= (MpfcClass& a, const MpfcClass& b)
  {
    return a = a/b;
  }

  MpfcClass& operator /= (MpfcClass& a, const double& b)
  {
    return a = a/b;
  }

  MpfcClass& operator /= (MpfcClass& a, const int b)
  {
    return a = a/b;
  }


  MpfcClass& operator /= (MpfcClass& a, const MpfrClass& b)
  {
    return a = a/b;
  }

  MpfcClass& operator /= (MpfcClass& a, const mpfr_t& b)
  {
    return a = a/b;
  }

// --------------------------- Compare-Operators --------------------------------------------
  bool operator == (const MpfcClass& a, const MpfcClass& b)
  {
    return ( mpfr_equal_p(a.mpfr_re, b.mpfr_re)!=0 && mpfr_equal_p(a.mpfr_im, b.mpfr_im)!=0 );
  }

  bool operator == (const MpfcClass& a, const MpfrClass& b)
  {
    return ( mpfr_equal_p(a.mpfr_re, getvalue(b))!=0 && mpfr_zero_p(a.mpfr_im)!=0 );
  }

  bool operator == (const MpfcClass& a, const mpfr_t& b)
  {
    return ( mpfr_equal_p(a.mpfr_re, b)!=0 && mpfr_zero_p(a.mpfr_im)!=0 );
  }

  bool operator == (const MpfcClass& a, const double& b)
  {
    MpfrClass tmp(b, RoundNearest, 53);
    return ( mpfr_equal_p(a.mpfr_re, tmp.GetValue())!=0 && mpfr_zero_p(a.mpfr_im)!=0 );
  }

  bool operator == (const MpfcClass& a, const int b)
  {
    MpfrClass tmp(b, RoundNearest, 64);
    return ( mpfr_equal_p(a.mpfr_re, tmp.GetValue())!=0 && mpfr_zero_p(a.mpfr_im)!=0 );
  }


  bool operator == (const MpfrClass& b, const MpfcClass& a)
  {
    return (a == b);
  }

  bool operator == (const mpfr_t& b, const MpfcClass& a)
  {
    return (a == b);
  }

  bool operator == (const double& b, const MpfcClass& a)
  {
    return (a == b);
  }

  bool operator == (const int b, const MpfcClass& a)
  {
    return (a == b);
  }


  bool operator != (const MpfcClass& a, const MpfcClass& b)
  {
    return ( mpfr_equal_p(a.mpfr_re, b.mpfr_re)==0 || mpfr_equal_p(a.mpfr_im, b.mpfr_im)==0 );
  }

  bool operator != (const MpfcClass& a, const MpfrClass& b)
  {
    return ( mpfr_equal_p(a.mpfr_re, getvalue(b))==0 || mpfr_zero_p(a.mpfr_im)==0 );
  }

  bool operator != (const MpfcClass& a, const mpfr_t& b)
  {
    return ( mpfr_equal_p(a.mpfr_re, b)==0 || mpfr_zero_p(a.mpfr_im)==0 );
  }

  bool operator != (const MpfcClass& a, const double& b)
  {
    MpfrClass tmp(b, RoundNearest, 53);
    return ( mpfr_equal_p(a.mpfr_re, tmp.GetValue())==0 || mpfr_zero_p(a.mpfr_im)==0 );
  }

  bool operator != (const MpfcClass& a, const int b)
  {
    MpfrClass tmp(b, RoundNearest, 64);
    return ( mpfr_equal_p(a.mpfr_re, tmp.GetValue())==0 || mpfr_zero_p(a.mpfr_im)==0 );
  }


  bool operator != (const MpfrClass& b, const MpfcClass& a)
  {
    return (a != b);
  }

  bool operator != (const mpfr_t& b, const MpfcClass& a)
  {
    return (a != b);
  }

  bool operator != (const double& b, const MpfcClass& a)
  {
    return (a != b);
  }

  bool operator != (const int b, const MpfcClass& a)
  {
    return (a != b);
  }


  std::string to_string(const MpfcClass& t, RoundingMode rnd, PrecisionType prec)  // Blomquist 09.10.2010
  // Diese Funktion liefert einen string des aktuellen Objekts in Gleitpunktdarstellung
  // im Format  (Number,Number)  ohne interne Leerzeichen.
  // Gerundet wird bez. rnd;
  // Der string wird mit prec Dezimalstellen generiert, wenn base = 10 ist.
  // Mit prec=0 erhaelt der string mindestens so viele Dezimalstellen (bei base=10),
  // wie es der Praezision des aktuellen Objekts entspricht, wobei aber nicht garantiert
  // wird, dass der string den exakten Wert des aktuellen Objekt wiedergibt!
  // Mit hinreichend grossem prec liefert der string jedoch den exakten Wert des aktuellen Objekts.
  {
    std::string res, tmp;
    res = '(';
    tmp = to_string(Re(t), rnd, prec);
    res = res + tmp;
    res = res + ',';
    tmp = " ";
    tmp = to_string(Im(t), rnd, prec);
    return res + tmp + ')';
  }

  // -------------------------------------------- Ausgabe-Operator ---------------------------------------
  std::ostream& operator << (std::ostream& os, const MpfcClass& v)
  {
    std::cout << "(";
    mpfr_out_str (stdout , MpfcClass::GetBase(), std::cout.precision() , v.mpfr_re, MPFR::MpfrClass::GetCurrRndMode());
    std::cout << ", ";
    mpfr_out_str (stdout , MpfcClass::GetBase(), std::cout.precision() , v.mpfr_im, MPFR::MpfrClass::GetCurrRndMode());
    std::cout << ")";
    return os;
  }

  // -------------------------------------------- Eingabe-Operator ---------------------------------------
  std::istream& operator >> (std::istream& is, MpfcClass& v)
  {
    is >> std::ws;

    char c;
    std::string input;

    is.get(c);
    if ( c != '(' )
    {
      std::cerr << "Error: Required input format: (Number,Number) without whitespaces!" << std::endl;
      exit(1);
    }
    // Erstes Zeichen als '(' erfolgreich gelesen;
    // Jetzt werden alle Zeichen bis zum ',' nach input eingelesen:

    is.get(c);
    while (c != ',')
    {
      input += c;
      is.get(c);
    }

    input += "\0";

    PrecisionType prec  =  v.GetPrecision();
    MpfrClass RE(0.0, RoundNearest, prec);

    if ( mpfr_set_str( RE.GetValue(), const_cast<char *>(input.c_str()), MpfcClass::GetBase(), MpfcClass::GetCurrRndMode() ) )
    {
      std::cerr << "Input error, wrong base or wrong input format? (Number,Number) without whitespaces!" << std::endl;
      exit(1);
    }

    RE.RoundPrecision(prec, MpfrClass::GetCurrRndMode());

    input = " ";
    is.get(c);
    while (c != ')')
    {
      input += c;
      is.get(c);
    }
    input += "\0";

    MpfrClass IM(0.0, RoundNearest, prec);

    if ( mpfr_set_str( IM.GetValue(), const_cast<char *>(input.c_str()), MpfcClass::GetBase(), MpfcClass::GetCurrRndMode() ) )
    {
      std::cerr << "Input error, wrong base or wrong input format? (Number,Number) without whitespaces!" << std::endl;
      exit(1);
    }

    IM.RoundPrecision(prec, MpfrClass::GetCurrRndMode());

    MpfcClass res(RE,IM, MpfcClass::GetCurrRndMode(), prec);
    v = res;

    return is;
  }


// --------------------------------- MpfcClass <--> real, complex -------------------------------------


  MpfcClass double2Mpfc (const double& x)
  {
    MpfcClass res(0, RoundNearest, 53);
    mpfr_set_d(res.mpfr_re, x, RoundNearest);
    return res;
  }

  MpfcClass int2Mpfc (const int& x)
  {
    MpfcClass res(0, RoundNearest, 64);
    mpfr_set_si(res.mpfr_re, x, RoundNearest);
    return res;
  }


  MpfcClass MpfrClass2Mpfc(const MpfrClass& v)
  {
    MpfcClass res(0, RoundNearest, v.GetPrecision());
    mpfr_set(res.mpfr_re, getvalue(v), RoundNearest);
    return res;
  }

  MpfcClass mpfr_t2Mpfc(const mpfr_t& v)
  {
    MpfcClass res(0, RoundNearest, mpfr_get_prec(v));
    mpfr_set(res.mpfr_re, v, RoundNearest);
    return res;
  }

  MpfcClass string2Mpfc (const std::string& s, RoundingMode rnd, PrecisionType prec)
  {
     MpfcClass res(s, rnd, prec);
     return res;
  }

}; // namespace MPFR
