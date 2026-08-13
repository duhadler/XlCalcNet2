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
/*  Datei:  mpfciclass.hpp                   */
/*  Zweck:  C++-Wrapper-Klasse fuer          */
/*          die MPFI-Bibliothek              */
/*  Based on    mpfr-3.0.0, mpfi-1.4         */
/*********************************************/


#ifndef _MPFCI_CLASS_H_
#define _MPFCI_CLASS_H_

#include "mpficlass.hpp"
#include "mpfcclass.hpp"
#include <list>



namespace MPFI{

class MpfciClass
{
  public:
  //protected:
    mpfi_t mpfi_re;      // mpfi_t-variable for real part interval
    mpfi_t mpfi_im;      // mpfi_t-variable for imaginary part interval

    static int base;

  //public:

//--------------------------------------------------------
//----------begin constructor and destructors-------------
//--------------------------------------------------------

    MpfciClass ();

    MpfciClass (const mpfi_t&, const mpfi_t&, PrecisionType = MPFR::MpfrClass::GetCurrPrecision());

    MpfciClass (const mpfi_t&, PrecisionType = MPFR::MpfrClass::GetCurrPrecision());

explicit MpfciClass (const MpfiClass&, const MpfiClass&, PrecisionType = MPFR::MpfrClass::GetCurrPrecision());

explicit MpfciClass (const MpfiClass&, PrecisionType = MPFR::MpfrClass::GetCurrPrecision());


explicit MpfciClass (const MPFR::MpfcClass&, PrecisionType = MPFR::MpfrClass::GetCurrPrecision());


    MpfciClass (const mpfr_t&, const mpfr_t&, PrecisionType = MPFR::MpfrClass::GetCurrPrecision());

    MpfciClass (const mpfr_t&, PrecisionType = MPFR::MpfrClass::GetCurrPrecision());

explicit MpfciClass (const MPFR::MpfrClass&, const MPFR::MpfrClass&,
                                             PrecisionType = MPFR::MpfrClass::GetCurrPrecision());
explicit MpfciClass (const MPFR::MpfrClass&, PrecisionType = MPFR::MpfrClass::GetCurrPrecision());

explicit MpfciClass (const double&, const double&, PrecisionType = MPFR::MpfrClass::GetCurrPrecision());

explicit MpfciClass (const double&, PrecisionType = MPFR::MpfrClass::GetCurrPrecision());


explicit MpfciClass (const int, const int, PrecisionType = MPFR::MpfrClass::GetCurrPrecision());

explicit MpfciClass (const int, PrecisionType = MPFR::MpfrClass::GetCurrPrecision());

    MpfciClass (const MpfciClass&, PrecisionType = MPFR::MpfrClass::GetCurrPrecision());

explicit MpfciClass (const std::string&, PrecisionType = MPFR::MpfrClass::GetCurrPrecision());

    ~MpfciClass ();

//--------------------------------------------------------
//----------end constructor and destructors---------------
//--------------------------------------------------------

    mpfi_t& GetValueRe();
    mpfi_t& GetValueIm();

    void SetValueRe(const mpfi_t&);
    void SetValueIm(const mpfi_t&);
    void SetValue(const mpfi_t&, const mpfi_t&);

   friend const mpfi_t& getvalueRe(const MpfciClass&);
   friend const mpfi_t& getvalueIm(const MpfciClass&);

   friend void times2pown (MpfciClass&, const long int);

    // ----------------- Precision Handling ---------------------------------
    static void SetCurrPrecision (PrecisionType);
    static const PrecisionType GetCurrPrecision ();

    PrecisionType GetPrecision () const;
    void SetPrecision (PrecisionType);
    void RoundPrecision(PrecisionType);

    // ---------- Base Handling for Input|Output -------------
    static void SetBase (int);
    static const int GetBase ();


    // Zuweisungsoperatoren
    MpfciClass& operator = (const MpfciClass&);
    MpfciClass& operator = (const MPFR::MpfcClass&);
    MpfciClass& operator = (const mpfi_t&);
    MpfciClass& operator = (const MpfiClass&);
    MpfciClass& operator = (const mpfr_t&);
    MpfciClass& operator = (const MPFR::MpfrClass&);
    MpfciClass& operator = (const double&);
    MpfciClass& operator = (const int&);
    MpfciClass& operator = (const std::string&);

    friend MpfciClass mpfi_t2Mpfci(const mpfi_t&);
    friend MpfciClass MpfiClass2Mpfci(const MpfiClass&);
    friend MpfciClass mpfr_t2Mpfci(const mpfr_t&);
    friend MpfciClass MpfrClass2Mpfci(const MPFR::MpfrClass&);
    friend MpfciClass double2Mpfci(const double&);
    friend MpfciClass int2Mpfci(const int&);

    //friend void set_Mpfci (MpfciClass&, const MpfciClass&, PrecisionType = MPFR::MpfrClass::GetCurrPrecision());

//--------------------------------------------------------
//----------start comparison Functions -------------------
//--------------------------------------------------------

    friend bool isNan     (const MpfciClass&);
    friend bool isInf     (const MpfciClass&);
    friend bool isBounded (const MpfciClass&);
    friend bool isZero    (const MpfciClass&);

//--------------------------------------------------------
//----------end comparison Functions ---------------------
//--------------------------------------------------------

  friend MpfciClass operator - (const MpfciClass&);

//--------------------------------------------------------
//----------start + Arithmetic Functions------------------
//--------------------------------------------------------
  friend MpfciClass operator + (const MpfciClass&, const MpfciClass&);
  friend MpfciClass operator + (const MpfciClass&, const MPFR::MpfcClass&);
  friend MpfciClass operator + (const MpfciClass&, const mpfi_t&);
  friend MpfciClass operator + (const MpfciClass&, const MpfiClass&);
  friend MpfciClass operator + (const MpfciClass&, const mpfr_t&);
  friend MpfciClass operator + (const MpfciClass&, const MPFR::MpfrClass&);
  friend MpfciClass operator + (const MpfciClass&, const double&);
  friend MpfciClass operator + (const MpfciClass&, const int);

//--------------------------------------------------------
//----------start - Arithmetic Functions------------------
//--------------------------------------------------------
  friend MpfciClass operator - (const MpfciClass&, const MpfciClass&);
  friend MpfciClass operator - (const MpfciClass&, const MPFR::MpfcClass&);
  friend MpfciClass operator - (const MpfciClass&, const mpfi_t&);
  friend MpfciClass operator - (const MpfciClass&, const MpfiClass&);
  friend MpfciClass operator - (const MpfciClass&, const mpfr_t&);
  friend MpfciClass operator - (const MpfciClass&, const MPFR::MpfrClass&);
  friend MpfciClass operator - (const MpfciClass&, const double&);
  friend MpfciClass operator - (const MpfciClass&, const int);

  friend MpfciClass operator - (const MPFR::MpfcClass&, const MpfciClass&);
  friend MpfciClass operator - (const mpfi_t&, const MpfciClass&);
  friend MpfciClass operator - (const MpfiClass&, const MpfciClass&);
  friend MpfciClass operator - (const mpfr_t&, const MpfciClass&);
  friend MpfciClass operator - (const MPFR::MpfrClass&, const MpfciClass&);
  friend MpfciClass operator - (const double&, const MpfciClass&);
  friend MpfciClass operator - (const int, const MpfciClass&);

  friend MpfciClass operator * (const MpfciClass&, const mpfi_t&);
  friend MpfciClass operator * (const MpfciClass&, const MpfiClass&);
  friend MpfciClass operator * (const MpfciClass&, const mpfr_t&);
  friend MpfciClass operator * (const MpfciClass&, const MPFR::MpfrClass&);
  friend MpfciClass operator * (const MpfciClass&, const double&);
  friend MpfciClass operator * (const MpfciClass&, const int);


//--------------------------------------------------------
//----------start extended Arithmetic Functions-----------
//--------------------------------------------------------

  friend MpfciClass conj  (const MpfciClass&);
  friend MpfiClass  abs   (const MpfciClass&, PrecisionType);
  friend MpfiClass  Arg   (const MpfciClass&, PrecisionType);
  friend MpfiClass  arg   (const MpfciClass&, PrecisionType);

  friend std::ostream& operator << (std::ostream&, const MpfciClass&);
  friend std::istream& operator >> (std::istream&, MpfciClass&);

  friend MpfiClass Re(const MpfciClass&);
  friend MpfiClass Im(const MpfciClass&);

  friend MpfciClass operator & (const MpfciClass&, const MpfciClass&);

};  // Class end

   void times2pown (MpfciClass&, const long int);

   std::ostream& operator << (std::ostream&, const MpfciClass&);
   std::istream& operator >> (std::istream&, MpfciClass&);

   std::string to_string (const MpfciClass&, PrecisionType = 0);

   MpfiClass Re(const MpfciClass&);
   MpfiClass Im(const MpfciClass&);

   MpfciClass mpfi_t2Mpfci(const mpfi_t&);
   MpfciClass MpfiClass2Mpfci(const MpfiClass&);
   MpfciClass mpfr_t2Mpfci(const mpfr_t&);
   MpfciClass MpfrClass2Mpfci(const MPFR::MpfrClass&);
   MpfciClass double2Mpfci(const double&);
   MpfciClass int2Mpfci(const int&);

   MpfciClass string2Mpfci (const std::string&, const PrecisionType = MPFR::MpfrClass::GetCurrPrecision());

   const mpfi_t& getvalueRe(const MpfciClass&);
   const mpfi_t& getvalueIm(const MpfciClass&);

   void set_Mpfci (MpfciClass&, const MpfciClass&, PrecisionType);

   bool isNan     (const MpfciClass&);
   bool isInf     (const MpfciClass&);
   bool isBounded (const MpfciClass&);
   bool isZero    (const MpfciClass&);
   bool isPoint   (const MpfciClass&);

   void set_nan  (MpfciClass&);
   void set_inf  (MpfciClass&);
   void set_zero (MpfciClass&);

   MPFR::MpfcClass Inf(const MpfciClass&, PrecisionType = MPFR::MpfrClass::GetCurrPrecision());
   MPFR::MpfcClass Sup(const MpfciClass&, PrecisionType = MPFR::MpfrClass::GetCurrPrecision());

   MPFR::MpfcClass mid(const MpfciClass&);
   MpfciClass Blow(const MpfciClass&, const MPFR::MpfrClass);

   int in (const MpfciClass&, const MpfciClass&);
   int in (const MpfiClass&, const MpfciClass&);
   int in (const mpfi_t&, const MpfciClass&);
   int in (const MPFR::MpfrClass&, const MpfciClass&);
   int in (const mpfr_t&, const MpfciClass&);
   int in (const double&, const MpfciClass&);
   int in (const int&, const MpfciClass&);
   int in (const MPFR::MpfcClass&, const MpfciClass&);

//--------------------------------------------------------
//----------start Comparison operators--------------------
//--------------------------------------------------------

bool operator == (const MpfciClass&, const MpfciClass&);
bool operator == (const MpfciClass&, const MPFR::MpfcClass&);
bool operator == (const MpfciClass&, const mpfi_t&);
bool operator == (const MpfciClass&, const MpfiClass&);
bool operator == (const MpfciClass&, const mpfr_t&);
bool operator == (const MpfciClass&, const MPFR::MpfrClass&);
bool operator == (const MpfciClass&, const double&);
bool operator == (const MpfciClass&, const int);

bool operator == (const MPFR::MpfcClass&,  const MpfciClass&);
bool operator == (const mpfi_t&,           const MpfciClass&);
bool operator == (const MpfiClass&,        const MpfciClass&);
bool operator == (const mpfr_t&,           const MpfciClass&);
bool operator == (const MPFR::MpfrClass&,  const MpfciClass&);
bool operator == (const double&,           const MpfciClass&);
bool operator == (const int,               const MpfciClass&);

bool operator != (const MpfciClass&, const MpfciClass&);
bool operator != (const MpfciClass&, const MPFR::MpfcClass&);
bool operator != (const MpfciClass&, const mpfi_t&);
bool operator != (const MpfciClass&, const MpfiClass&);
bool operator != (const MpfciClass&, const mpfr_t&);
bool operator != (const MpfciClass&, const MPFR::MpfrClass&);
bool operator != (const MpfciClass&, const double&);
bool operator != (const MpfciClass&, const int);

bool operator != (const MPFR::MpfcClass&,  const MpfciClass&);
bool operator != (const mpfi_t&,           const MpfciClass&);
bool operator != (const MpfiClass&,        const MpfciClass&);
bool operator != (const mpfr_t&,           const MpfciClass&);
bool operator != (const MPFR::MpfrClass&,  const MpfciClass&);
bool operator != (const double&,           const MpfciClass&);
bool operator != (const int,               const MpfciClass&);

// ------------------------------------------------------------------
// ------------------------ Intersection ----------------------------
// ------------------------------------------------------------------

  MpfciClass operator & (const MpfciClass&, const MpfciClass&);
  MpfciClass operator & (const MpfciClass&, const MPFR::MpfcClass&);
  MpfciClass operator & (const MpfciClass&, const mpfi_t&);
  MpfciClass operator & (const MpfciClass&, const MpfiClass&);
  MpfciClass operator & (const MpfciClass&, const mpfr_t&);
  MpfciClass operator & (const MpfciClass&, const MPFR::MpfrClass&);
  MpfciClass operator & (const MpfciClass&, const double&);
  MpfciClass operator & (const MpfciClass&, const int);

  MpfciClass operator & (const MPFR::MpfcClass&,  const MpfciClass&);
  MpfciClass operator & (const mpfi_t&,           const MpfciClass&);
  MpfciClass operator & (const MpfiClass&,        const MpfciClass&);
  MpfciClass operator & (const mpfr_t&,           const MpfciClass&);
  MpfciClass operator & (const MPFR::MpfrClass&,  const MpfciClass&);
  MpfciClass operator & (const double&,           const MpfciClass&);
  MpfciClass operator & (const int,               const MpfciClass&);

  MpfciClass & operator &= (MpfciClass&, const MpfciClass&);
  MpfciClass & operator &= (MpfciClass&, const MPFR::MpfcClass&);
  MpfciClass & operator &= (MpfciClass&, const mpfi_t&);
  MpfciClass & operator &= (MpfciClass&, const MpfiClass&);
  MpfciClass & operator &= (MpfciClass&, const mpfr_t&);
  MpfciClass & operator &= (MpfciClass&, const MPFR::MpfrClass&);
  MpfciClass & operator &= (MpfciClass&, const double&);
  MpfciClass & operator &= (MpfciClass&, const int);


  MpfciClass operator | (const MpfciClass&, const MpfciClass&);
  MpfciClass operator | (const MpfciClass&, const MPFR::MpfcClass&);
  MpfciClass operator | (const MpfciClass&, const mpfi_t&);
  MpfciClass operator | (const MpfciClass&, const MpfiClass&);
  MpfciClass operator | (const MpfciClass&, const mpfr_t&);
  MpfciClass operator | (const MpfciClass&, const MPFR::MpfrClass&);
  MpfciClass operator | (const MpfciClass&, const double&);
  MpfciClass operator | (const MpfciClass&, const int);

  MpfciClass operator | (const MPFR::MpfcClass&, const MpfciClass&);
  MpfciClass operator | (const mpfi_t&,          const MpfciClass&);
  MpfciClass operator | (const MpfiClass&,       const MpfciClass&);
  MpfciClass operator | (const mpfr_t&,          const MpfciClass&);
  MpfciClass operator | (const MPFR::MpfrClass&, const MpfciClass&);
  MpfciClass operator | (const double&,          const MpfciClass&);
  MpfciClass operator | (const int,              const MpfciClass&);

  MpfciClass & operator |= (MpfciClass&, const MpfciClass&);
  MpfciClass & operator |= (MpfciClass&, const MPFR::MpfcClass&);
  MpfciClass & operator |= (MpfciClass&, const mpfi_t&);
  MpfciClass & operator |= (MpfciClass&, const MpfiClass&);
  MpfciClass & operator |= (MpfciClass&, const mpfr_t&);
  MpfciClass & operator |= (MpfciClass&, const MPFR::MpfrClass&);
  MpfciClass & operator |= (MpfciClass&, const double&);
  MpfciClass & operator |= (MpfciClass&, const int);


  MpfciClass operator + (const MpfciClass&);
  MpfciClass operator - (const MpfciClass&);

  MpfciClass operator + (const MpfciClass&, const MpfciClass&);
  MpfciClass operator + (const MpfciClass&, const MPFR::MpfcClass&);
  MpfciClass operator + (const MpfciClass&, const mpfi_t&);
  MpfciClass operator + (const MpfciClass&, const MpfiClass&);
  MpfciClass operator + (const MpfciClass&, const mpfr_t&);
  MpfciClass operator + (const MpfciClass&, const MPFR::MpfrClass&);
  MpfciClass operator + (const MpfciClass&, const double&);
  MpfciClass operator + (const MpfciClass&, const int);

  MpfciClass operator + (const MPFR::MpfcClass&, const MpfciClass&);
  MpfciClass operator + (const mpfi_t&,          const MpfciClass&);
  MpfciClass operator + (const MpfiClass&,       const MpfciClass&);
  MpfciClass operator + (const mpfr_t&,          const MpfciClass&);
  MpfciClass operator + (const MPFR::MpfrClass&, const MpfciClass&);
  MpfciClass operator + (const double&,          const MpfciClass&);
  MpfciClass operator + (const int,              const MpfciClass&);

  MpfciClass& operator += (MpfciClass&, const MpfciClass&);
  MpfciClass& operator += (MpfciClass&, const MPFR::MpfcClass&);
  MpfciClass& operator += (MpfciClass&, const mpfi_t&);
  MpfciClass& operator += (MpfciClass&, const MpfiClass&);
  MpfciClass& operator += (MpfciClass&, const mpfr_t&);
  MpfciClass& operator += (MpfciClass&, const MPFR::MpfrClass&);
  MpfciClass& operator += (MpfciClass&, const double&);
  MpfciClass& operator += (MpfciClass&, const int);


  MpfciClass operator - (const MpfciClass&, const MpfciClass&);
  MpfciClass operator - (const MpfciClass&, const MPFR::MpfcClass&);
  MpfciClass operator - (const MpfciClass&, const mpfi_t&);
  MpfciClass operator - (const MpfciClass&, const MpfiClass&);
  MpfciClass operator - (const MpfciClass&, const mpfr_t&);
  MpfciClass operator - (const MpfciClass&, const MPFR::MpfrClass&);
  MpfciClass operator - (const MpfciClass&, const double&);
  MpfciClass operator - (const MpfciClass&, const int);

  MpfciClass operator - (const MPFR::MpfcClass&, const MpfciClass&);
  MpfciClass operator - (const mpfi_t&, const MpfciClass&);
  MpfciClass operator - (const MpfiClass&, const MpfciClass&);
  MpfciClass operator - (const mpfr_t&, const MpfciClass&);
  MpfciClass operator - (const MPFR::MpfrClass&, const MpfciClass&);
  MpfciClass operator - (const double&, const MpfciClass&);
  MpfciClass operator - (const int, const MpfciClass&);

  MpfciClass& operator -= (MpfciClass&, const MpfciClass&);
  MpfciClass& operator -= (MpfciClass&, const MPFR::MpfcClass&);
  MpfciClass& operator -= (MpfciClass&, const mpfi_t&);
  MpfciClass& operator -= (MpfciClass&, const MpfiClass&);
  MpfciClass& operator -= (MpfciClass&, const mpfr_t&);
  MpfciClass& operator -= (MpfciClass&, const MPFR::MpfrClass&);
  MpfciClass& operator -= (MpfciClass&, const double&);
  MpfciClass& operator -= (MpfciClass&, const int);

  MpfciClass operator * (const MpfciClass&, const MpfciClass&);
  MpfciClass operator * (const MpfciClass&, const MPFR::MpfcClass&);
  MpfciClass operator * (const MpfciClass&, const mpfi_t&);
  MpfciClass operator * (const MpfciClass&, const MpfiClass&);
  MpfciClass operator * (const MpfciClass&, const mpfr_t&);
  MpfciClass operator * (const MpfciClass&, const MPFR::MpfrClass&);
  MpfciClass operator * (const MpfciClass&, const double&);
  MpfciClass operator * (const MpfciClass&, const int);

  MpfciClass operator * (const MPFR::MpfcClass&, const MpfciClass&);
  MpfciClass operator * (const mpfi_t&, const MpfciClass&);
  MpfciClass operator * (const MpfiClass&, const MpfciClass&);
  MpfciClass operator * (const mpfr_t&, const MpfciClass&);
  MpfciClass operator * (const MPFR::MpfrClass&, const MpfciClass&);
  MpfciClass operator * (const double&, const MpfciClass&);
  MpfciClass operator * (const int, const MpfciClass&);

  MpfciClass& operator *= (MpfciClass&, const MpfciClass&);
  MpfciClass& operator *= (MpfciClass&, const MPFR::MpfcClass&);
  MpfciClass& operator *= (MpfciClass&, const mpfi_t&);
  MpfciClass& operator *= (MpfciClass&, const MpfiClass&);
  MpfciClass& operator *= (MpfciClass&, const mpfr_t&);
  MpfciClass& operator *= (MpfciClass&, const MPFR::MpfrClass&);
  MpfciClass& operator *= (MpfciClass&, const double&);
  MpfciClass& operator *= (MpfciClass&, const int);

  MpfciClass operator / (const MpfciClass&, const MpfciClass&);
  MpfciClass operator / (const MpfciClass&, const MPFR::MpfcClass&);
  MpfciClass operator / (const MpfciClass&, const mpfi_t&);
  MpfciClass operator / (const MpfciClass&, const MpfiClass&);
  MpfciClass operator / (const MpfciClass&, const mpfr_t&);
  MpfciClass operator / (const MpfciClass&, const MPFR::MpfrClass&);
  MpfciClass operator / (const MpfciClass&, const double&);
  MpfciClass operator / (const MpfciClass&, const int);

  MpfciClass operator / (const MPFR::MpfcClass&, const MpfciClass&);
  MpfciClass operator / (const mpfi_t&, const MpfciClass&);
  MpfciClass operator / (const MpfiClass&, const MpfciClass&);
  MpfciClass operator / (const mpfr_t&, const MpfciClass&);
  MpfciClass operator / (const MPFR::MpfrClass&, const MpfciClass&);
  MpfciClass operator / (const double&, const MpfciClass&);
  MpfciClass operator / (const int, const MpfciClass&);

  MpfciClass& operator /= (MpfciClass&, const MpfciClass&);
  MpfciClass& operator /= (MpfciClass&, const MPFR::MpfcClass&);
  MpfciClass& operator /= (MpfciClass&, const mpfi_t&);
  MpfciClass& operator /= (MpfciClass&, const MpfiClass&);
  MpfciClass& operator /= (MpfciClass&, const mpfr_t&);
  MpfciClass& operator /= (MpfciClass&, const MPFR::MpfrClass&);
  MpfciClass& operator /= (MpfciClass&, const double&);
  MpfciClass& operator /= (MpfciClass&, const int);

  MpfciClass conj (const MpfciClass&);
  MpfiClass  abs  (const MpfciClass&, PrecisionType = MPFR::MpfrClass::GetCurrPrecision());
  MpfiClass  Arg  (const MpfciClass&, PrecisionType = MPFR::MpfrClass::GetCurrPrecision());
  MpfiClass  argp1(const MpfciClass&, PrecisionType = MPFR::MpfrClass::GetCurrPrecision());
  MpfiClass  arg  (const MpfciClass&, PrecisionType = MPFR::MpfrClass::GetCurrPrecision());
  MpfciClass sqr  (const MpfciClass&);
  MpfciClass Ln   (const MpfciClass&);
  MpfciClass Lnp1 (const MpfciClass&);
  MpfciClass lnp1 (const MpfciClass&);
  MpfciClass ln   (const MpfciClass&);
  MpfciClass log2 (const MpfciClass&);
  MpfciClass log10(const MpfciClass&);
  MpfciClass sqrt(const MpfciClass&);
  std::list<MpfciClass> sqrt_all(const MpfciClass&);
  MpfciClass sqrt(const MpfciClass&, int);
  std::list<MpfciClass> sqrt_all(const MpfciClass&, int);
  MpfciClass exp(const MpfciClass&);
  MpfciClass exp2(const MpfciClass&);
  MpfciClass exp10(const MpfciClass&);
  MpfciClass sin(const MpfciClass&);
  MpfciClass cos(const MpfciClass&);
  MpfciClass tan(const MpfciClass&);
  MpfciClass cot(const MpfciClass&);
  MpfciClass cosh(const MpfciClass&);
  MpfciClass sinh(const MpfciClass&);
  MpfciClass tanh(const MpfciClass&);
  MpfciClass coth(const MpfciClass&);
  MpfciClass asin(const MpfciClass&);
  MpfciClass acos(const MpfciClass&);
  MpfciClass atan(const MpfciClass&);
  MpfciClass acot(const MpfciClass&);
  MpfciClass asinh(const MpfciClass&);
  MpfciClass acosh(const MpfciClass&);
  MpfciClass atanh(const MpfciClass&);
  MpfciClass acoth(const MpfciClass&);

  MpfciClass power_fast(const MpfciClass&, int);
  MpfciClass power(const MpfciClass&, int);
  MpfciClass pow  (const MpfciClass&, const MpfiClass&);
  MpfciClass pow  (const MpfciClass&, const MpfciClass&);
  std::list<MpfciClass> pow_all(const MpfciClass&, const MpfiClass&);


  bool operator < (const MpfciClass&, const MpfciClass&);
  bool operator < (const MpfciClass&, const mpfi_t&);
  bool operator < (const MpfciClass&, const MpfiClass&);
  bool operator < (const mpfi_t&, const MpfciClass&);
  bool operator < (const MpfiClass&, const MpfciClass&);

  bool operator < (const MPFR::MpfcClass&, const MpfciClass&);
  bool operator < (const mpfr_t&,          const MpfciClass&);
  bool operator < (const MPFR::MpfrClass&, const MpfciClass&);
  bool operator < (const double&,          const MpfciClass&);
  bool operator < (const int,              const MpfciClass&);

  bool operator <= (const MpfciClass&, const MpfciClass&);
  bool operator <= (const MpfciClass&, const mpfi_t&);
  bool operator <= (const MpfciClass&, const MpfiClass&);
  bool operator <= (const mpfi_t&,          const MpfciClass&);
  bool operator <= (const MpfiClass&,       const MpfciClass&);

  bool operator <= (const MPFR::MpfcClass&, const MpfciClass&);
  bool operator <= (const mpfr_t&,          const MpfciClass&);
  bool operator <= (const MPFR::MpfrClass&, const MpfciClass&);
  bool operator <= (const double&,          const MpfciClass&);
  bool operator <= (const int,              const MpfciClass&);

  bool operator > (const MpfciClass&, const MpfciClass&);
  bool operator > (const MpfciClass&, const mpfi_t&);
  bool operator > (const MpfciClass&, const MpfiClass&);
  bool operator > (const mpfi_t&,          const MpfciClass&);
  bool operator > (const MpfiClass&,       const MpfciClass&);

  bool operator > (const MpfciClass&, const MPFR::MpfcClass&);
  bool operator > (const MpfciClass&, const mpfr_t&);
  bool operator > (const MpfciClass&, const MPFR::MpfrClass&);
  bool operator > (const MpfciClass&, const double&);
  bool operator > (const MpfciClass&, const int);

  bool operator >= (const MpfciClass&, const MpfciClass&);
  bool operator >= (const MpfciClass&, const mpfi_t&);
  bool operator >= (const MpfciClass&, const MpfiClass&);
  bool operator >= (const mpfi_t&,          const MpfciClass&);
  bool operator >= (const MpfiClass&,       const MpfciClass&);

  bool operator >= (const MpfciClass&, const MPFR::MpfcClass&);
  bool operator >= (const MpfciClass&, const mpfr_t&);
  bool operator >= (const MpfciClass&, const MPFR::MpfrClass&);
  bool operator >= (const MpfciClass&, const double&);
  bool operator >= (const MpfciClass&, const int);

}

#endif
