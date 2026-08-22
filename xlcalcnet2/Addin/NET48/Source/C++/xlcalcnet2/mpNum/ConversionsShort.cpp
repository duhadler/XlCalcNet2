
#include "mpNumC_Main.h"

#include "Helperfunctions.h"



/***********************************************************************************/




DblPtr Lib_Dbl_Init_Func()
{
	DblPtr x = NULL;
	x = (double*)malloc(sizeof(double));
//	*(double*)x = 0.0;
	return x;
}


void Lib_Dbl_Clear(DblPtr x)
{
	free(x);
}



ExtPtr Lib_Ext_Init_Func()
{
	ExtPtr x = NULL;
	x = (long double*)malloc(sizeof(long double));
	return x;
}


void Lib_Ext_Clear(ExtPtr x)
{
	free(x);
}




QuadPtr Lib_Quad_Init_Func()
{
	QuadPtr x = NULL;
	x = (__float128*)malloc(sizeof(__float128));
	return x;
}


void Lib_Quad_Clear(QuadPtr x)
{
	free(x);
}



/***********************************************************************************/


CplxPtr Lib_Cplx_Init_Func()
{
	CplxPtr z;
	z = (std::complex<double>*) malloc(sizeof(std::complex<double>));
	return z;
}



void Lib_Cplx_Clear(CplxPtr z)
{
	free(z);
}




/***********************************************************************************/
/***********************************************************************************/
/***********************************************************************************/



FmpzPolyPtr Lib_Poly_Fmpz_Init_Func()
{
	FmpzPolyPtr A;
	A = malloc(sizeof(fmpz_poly_struct));
	fmpz_poly_init((fmpz_poly_struct*)A);
	return A;
}


void Lib_Poly_Fmpz_Clear(FmpzPolyPtr A)
{
	fmpz_poly_clear((fmpz_poly_struct*)A);
	free(A);
}



/***********************************************************************************/

FmpqPolyPtr Lib_Poly_Fmpq_Init_Func()
{
	FmpqPolyPtr A;
	A = malloc(sizeof(fmpq_poly_struct));
	fmpq_poly_init((fmpq_poly_struct*)A);
	return A;
}


void Lib_Poly_Fmpq_Clear(FmpqPolyPtr A)
{
	fmpq_poly_clear((fmpq_poly_struct*)A);
	free(A);
}

/***********************************************************************************/


ArbPolyPtr Lib_Poly_Arb_Init_Func()
{
	ArbPolyPtr A;
	A = malloc(sizeof(arb_poly_struct));
	arb_poly_init((arb_poly_struct*)A);
	return A;
}


void Lib_Poly_Arb_Clear(ArbPolyPtr A)
{
	arb_poly_clear((arb_poly_struct*)A);
	free(A);
}

/***********************************************************************************/



AcbPolyPtr Lib_Poly_Acb_Init_Func()
{
	AcbPolyPtr A;
	A = malloc(sizeof(acb_poly_struct));
	acb_poly_init((acb_poly_struct*)A);
	return A;
}


void Lib_Poly_Acb_Clear(AcbPolyPtr A)
{
	acb_poly_clear((acb_poly_struct*)A);
	free(A);
}


int32_t Get_Real_Type(int32_t mpType_)
{
    int32_t res = 0;
    switch (mpType_) {
    case mp_double2: case mp_complex2: res = mp_double2; break;
    case mp_xrf: case mp_xcf: res = mp_xrf; break;
#ifndef _MSC_VER
    case mp_ext: case mp_ext_cplx: res = mp_ext; break;
    case mp_quad: case mp_quad_cplx: res = mp_quad; break;
#endif
    case mp_mprf: case mp_mpcf: res = mp_mprf; break;
    case mp_mpri: case mp_mpci: res = mp_mpri; break;
    case mp_drf: case mp_dcf: res = mp_drf; break;
    case mp_arf: case mp_acf: res = mp_arf; break;
    case mp_arb: case mp_acb: res = mp_arb; break;
    case mp_fmpq: case mp_fmpz: res = mp_fmpq; break;
    }
    return res;
}



bool Is_Real_Type(int32_t mpType)
{
    bool res = false;
    switch (mpType) {
    case mp_double2:
    case mp_xrf:
#ifndef _MSC_VER
    case mp_ext:
    case mp_quad:
#endif
    case mp_mprf:
    case mp_mpri:
    case mp_drf:
    case mp_arf:
    case mp_arb:
    case mp_fmpq: res = true; break;
    }
    return res;
}


/***********************************************************************************/
/***********************************************************************************/
/***********************************************************************************/

void Lib_Eigen_GetCoeff_(int32_t mpType, ScalarResPtr result, long row, long col, mpNumMatrixPtr Matrix)
{
    if (Is_Real_Type(mpType)){
        Lib_Set_Matrix_Mode(mpType); Lib_Eigen_MpAny_GetCoeff(result, row, col, Matrix);}
    else {
        Lib_Set_Matrix_Mode(Get_Real_Type(mpType)); Lib_Eigen_MpAnyCplx_GetCoeff(result, row, col, Matrix);}
}


void Lib_Eigen_SetCoeff_(int32_t mpType, mpNumMatrixPtr Matrix, ScalarResPtr result, long row, long col)
{
    if (Is_Real_Type(mpType)){
        Lib_Set_Matrix_Mode(mpType); Lib_Eigen_MpAny_SetCoeff(Matrix, result, row, col);}
    else {
        Lib_Set_Matrix_Mode(Get_Real_Type(mpType)); Lib_Eigen_MpAnyCplx_SetCoeff(Matrix, result, row, col);}
}





void Lib_Eigen_Sort(int32_t mpType, mpNumMatrixPtr Matrix, int32_t ColumnToSortBy, int32_t SortOrder, int32_t SortCriterion)
{
	if (ColumnToSortBy < 0)
	{
        if (Is_Real_Type(mpType)){
            Lib_Set_Matrix_Mode(mpType); Lib_Eigen_MpAny_Sort(Matrix, SortOrder, SortCriterion);}
        else {
            Lib_Set_Matrix_Mode(Get_Real_Type(mpType)); Lib_Eigen_MpAnyCplx_Sort(Matrix, SortOrder, SortCriterion);}
	}
	else
	{
        if (Is_Real_Type(mpType)){
            Lib_Set_Matrix_Mode(mpType); Lib_Eigen_MpAny_SortRowsByColumn(Matrix, ColumnToSortBy, SortOrder, SortCriterion);}
        else {
            Lib_Set_Matrix_Mode(Get_Real_Type(mpType)); Lib_Eigen_MpAnyCplx_SortRowsByColumn(Matrix, ColumnToSortBy, SortOrder, SortCriterion);}
	}
}



void Lib_Eigen_Select_Rows(int32_t mpType, mpNumMatrixPtr res, mpNumMatrixPtr A)
{
    if (Is_Real_Type(mpType))
        {
            Lib_Set_Matrix_Mode(mpType); Lib_Eigen_MpAny_Select_Rows(res, A);
        }
    else {
            Lib_Set_Matrix_Mode(mpType); Lib_Eigen_MpAnyCplx_Select_Rows(res, A);
         }
}



uint32_t Lib_Eigen_GetInfo(int32_t mpCat, int32_t mpType, long what, mpNumMatrixPtr Matrix)
{
	switch (mpCat) {
	case mp_poly2:
	case mp_eigen:  /* eigen */
	{
	    uint32_t res = 0;
        if (Is_Real_Type(mpType)){
            Lib_Set_Matrix_Mode(mpType); res = Lib_Eigen_MpAny_GetInfo(what, Matrix);}
        else {
            Lib_Set_Matrix_Mode(Get_Real_Type(mpType)); res = Lib_Eigen_MpAnyCplx_GetInfo(what, Matrix);}

	    return res;
	}; break;

	default: return 0;  break;
	}
}


void Lib_Eigen_Get_Block(int32_t mpCat, int32_t mpType, mpNumMatrixPtr result, long what, long i, long j, long p, long q, mpNumMatrixPtr source)
{
	switch (mpCat) {
	case mp_poly2:
	case mp_eigen:  /* eigen */
	{
        if (Is_Real_Type(mpType)){
            Lib_Set_Matrix_Mode(mpType); Lib_Eigen_MpAny_Get_Block(result, what, i, j, p, q, source);}
        else {
            Lib_Set_Matrix_Mode(Get_Real_Type(mpType)); Lib_Eigen_MpAnyCplx_Get_Block(result, what, i, j, p, q, source);}
	}; break;

	}
}


void Lib_Eigen_Put_Block(int32_t mpCat, int32_t mpType, mpNumMatrixPtr result, long what, long i, long j, long p, long q, mpNumMatrixPtr source)
{
	switch (mpCat) {
	case mp_poly2:
	case mp_eigen:  /* eigen */
	{
        if (Is_Real_Type(mpType)){
            Lib_Set_Matrix_Mode(mpType); Lib_Eigen_MpAny_Put_Block(result, what, i, j, p, q, source);}
        else {
            Lib_Set_Matrix_Mode(Get_Real_Type(mpType)); Lib_Eigen_MpAnyCplx_Put_Block(result, what, i, j, p, q, source);}

	}; break;

	}
}



void Lib_Eigen_SetSpecialValue(int32_t mpCat, int32_t mpType, mpNumMatrixPtr result, long what, long m, long n)
{
	switch (mpCat) {
	case mp_poly2:
	case mp_eigen:  /* eigen */
	{
        if (Is_Real_Type(mpType)){
            Lib_Set_Matrix_Mode(mpType); Lib_Eigen_MpAny_SetSpecialValue(result, what, m, n);}
        else {
            Lib_Set_Matrix_Mode(Get_Real_Type(mpType)); Lib_Eigen_MpAnyCplx_SetSpecialValue(result, what, m, n);}
	}; break;

	}
}



void Lib_Eigen_SetSpecialValue2(int32_t mpCat, int32_t mpType, mpNumMatrixPtr result, long what, long Vertical, long Horizontal, long PartialMode, mpNumMatrixPtr source)
{
	switch (mpCat) {
	case mp_poly2:
	case mp_eigen:  /* eigen */
	{
        if (Is_Real_Type(mpType)){
            Lib_Set_Matrix_Mode(mpType); Lib_Eigen_MpAny_SetSpecialValue2(result, what, Vertical, Horizontal, PartialMode, source);}
        else {
            Lib_Set_Matrix_Mode(Get_Real_Type(mpType)); Lib_Eigen_MpAnyCplx_SetSpecialValue2(result, what, Vertical, Horizontal, PartialMode, source);}
	}; break;

	}
}




uint32_t Lib_Eigen_Compare(int32_t mpCat, int32_t mpType, long what, mpNumMatrixPtr x, mpNumMatrixPtr y)
{
	switch (mpCat) {
	case mp_poly2:
	case mp_eigen:  /* eigen */
	{
	    uint32_t res = 0;
        if (Is_Real_Type(mpType)){
            Lib_Set_Matrix_Mode(mpType); res = Lib_Eigen_MpAny_Compare(what, x, y);}
        else {
            Lib_Set_Matrix_Mode(Get_Real_Type(mpType)); res = Lib_Eigen_MpAnyCplx_Compare(what, x, y);}
		return res;
	}; break;

	default: return 0;  break;
	}
}



void Lib_Eigen_BasicArithmetic(int32_t mpCat, int32_t mpType, mpNumMatrixPtr result, long what, mpNumMatrixPtr x, mpNumMatrixPtr y)
{
	switch (mpCat) {
	case mp_poly2:
	case mp_eigen:  /* eigen */
	{
        if (Is_Real_Type(mpType)){
            Lib_Set_Matrix_Mode(mpType); Lib_Eigen_MpAny_BasicArithmetic(result, what, x, y);}
        else {
            Lib_Set_Matrix_Mode(Get_Real_Type(mpType)); Lib_Eigen_MpAnyCplx_BasicArithmetic(result, what, x, y);}
	}; break;
	}
}





void Lib_Eigen_Stats(int32_t mpCat, int32_t mpType, mpNumMatrixPtr result, long what, long PartialMode, mpNumMatrixPtr source)
{
	switch (mpCat) {
	case mp_poly2:
	case mp_eigen:  /* eigen */
	{
		if (Is_Real_Type(mpType)) {
			Lib_Set_Matrix_Mode(mpType); Lib_Eigen_MpAny_Stats(result, what, PartialMode, source); break;
		}
		else {
			Lib_Set_Matrix_Mode(Get_Real_Type(mpType)); Lib_Eigen_MpAnyCplx_Stats(result, what, PartialMode, source); break;
		}
	}; break;
	}
}



void Lib_Eigen_Stats2(int32_t mpCat, int32_t mpType, mpNumMatrixPtr result, long *IndexX, long *IndexY, long what, mpNumMatrixPtr source)
{
	switch (mpCat) {
	case mp_poly2:
	case mp_eigen:  /* eigen */
	{
	    Lib_Set_Matrix_Mode(mpType); Lib_Eigen_MpAny_Stats2(result, IndexX, IndexY, what, source); break;
    }

	}
}



void Lib_Map_GetItemValue(int32_t mpCat, int32_t mpType, mpNumMatrixPtr ptr, MapPtr z, char *s)
{
	switch (mpCat) {
	case mp_eigen:  /* eigen */
	    {
            if (Is_Real_Type(mpType)){
                Lib_Set_Matrix_Mode(mpType); Lib_Map_MpAny_GetItemValue(ptr, z, s);}
            else {
                Lib_Set_Matrix_Mode(Get_Real_Type(mpType)); Lib_Map_MpAnyCplx_GetItemValue(ptr, z, s);}
	}; break;

	}
}


void Lib_Eigen_MultipleResults(int32_t mpCat, int32_t mpType, MapPtr z, int32_t what, char *s, mpNumMatrixPtr A, mpNumMatrixPtr b)
{
	switch (mpCat) {
	case mp_eigen:  /* eigen */
	{
        if (Is_Real_Type(mpType)){
            Lib_Set_Matrix_Mode(mpType); Lib_Eigen_MpAny_MultipleResults(z, what, s, A, b);}
        else {
            Lib_Set_Matrix_Mode(Get_Real_Type(mpType)); Lib_Eigen_MpAnyCplx_MultipleResults(z, what, s, A, b);}
	}; break;

	}
}


/***********************************************************************************/
/***********************************************************************************/
/***********************************************************************************/


AnyPtr Lib_Init_Func(int32_t mpCat, int32_t mpType)
{
	switch (mpCat) {
	case mp_scalar:  /* scalar */
	{
		switch (mpType) {

		case mp_mpcf: return Lib_Mpfc_Init_Func(); break;
		case mp_mprf: return Lib_Mpfr_Init_Func(); break;

		case mp_acb: return Lib_Acb_Init_Func(); break;
		case mp_arb: return Lib_Arb_Init_Func(); break;

		default: return NULL;  break;
		}
	}; break;

	case mp_poly2:
	case mp_eigen:  /* eigen */
        {
            if (Is_Real_Type(mpType)){
                Lib_Set_Matrix_Mode(mpType); return Lib_Eigen_MpAny_Init_Func();}
            else {
                Lib_Set_Matrix_Mode(Get_Real_Type(mpType)); return Lib_Eigen_MpAnyCplx_Init_Func();}
        }; break;

	case mp_map:   /* map */
        {
            if (Is_Real_Type(mpType)){
                Lib_Set_Matrix_Mode(mpType); return Lib_Map_MpAny_Init_Func();}
            else {
                Lib_Set_Matrix_Mode(Get_Real_Type(mpType)); return Lib_Map_MpAnyCplx_Init_Func();}
        }; break;

	case mp_poly:   /* poly */
	{
		switch (mpType) {
		case mp_acb: return Lib_Poly_Acb_Init_Func(); break;
		case mp_arb: return Lib_Poly_Arb_Init_Func(); break;

		case mp_fmpq: return Lib_Poly_Fmpq_Init_Func(); break;
		case mp_fmpz: return Lib_Poly_Fmpz_Init_Func(); break;
		default: return NULL;  break;
		}
	}; break;

	default: return NULL;  break;
	}
}



/***********************************************************************************/


void Lib_Clear(int32_t mpCat, int32_t mpType, AnyPtr x)
{
	switch (mpCat) {
	case mp_scalar:  /* scalar */
	{
		switch (mpType) {

		case mp_complex2:  Lib_Cplx_Clear(x); break;  //??? Needed ???
		case mp_double2:  Lib_Dbl_Clear(x); break;  //??? Needed ???

		case mp_xcf:  Lib_Cplx_Clear(x); break;
		case mp_xrf:  Lib_Dbl_Clear(x); break;

		case mp_acb:  Lib_Acb_Clear(x); break;
		case mp_arb:  Lib_Arb_Clear(x); break;

		case mp_mpcf:  Lib_Mpfc_Clear(x); break;
		case mp_mprf:  Lib_Mpfr_Clear(x); break;
		}
	}; break;

	case mp_poly2:
	case mp_eigen:  /* eigen */
        {
            if (Is_Real_Type(mpType)){
                Lib_Set_Matrix_Mode(mpType); Lib_Eigen_MpAny_Clear(x);}
            else {
                Lib_Set_Matrix_Mode(Get_Real_Type(mpType)); Lib_Eigen_MpAnyCplx_Clear(x);}
        }; break;

	case mp_map:   /* map */
        {
            if (Is_Real_Type(mpType)){
                Lib_Set_Matrix_Mode(mpType); Lib_Map_MpAny_Clear(x);}
            else {
                Lib_Set_Matrix_Mode(Get_Real_Type(mpType)); Lib_Map_MpAnyCplx_Clear(x);}
        }; break;

	case mp_poly:   /* poly */
	{
		switch (mpType) {
		case mp_acb:  Lib_Poly_Acb_Clear(x); break;
		case mp_arb:  Lib_Poly_Arb_Clear(x); break;

		case mp_fmpq:  Lib_Poly_Fmpq_Clear(x); break;
		case mp_fmpz:  Lib_Poly_Fmpz_Clear(x); break;
		}
	}; break;

	}
}







/***********************************************************************************/
/***********************************************************************************/
/***********************************************************************************/




void Lib_FmpzMatRandom(mpNumMatrixPtr matResult, int32_t what, int32_t mRows, int32_t mCols)
{
	flint_rand_t state;
	flint_randinit(state);
	fmpz_mat_t fmpz_mat_Result;
	fmpz_mat_init(fmpz_mat_Result, mRows, mCols);
	fmpz_mat_randtest(fmpz_mat_Result, state, 125);

	//   fmpz_mat_print(fmpz_mat_Result);

	   /*  insert result   */
	(*(mpAnyMatrixPtr)matResult).resize(mRows, mCols);
	for (int i = 0; i < mRows; i++)
	{
		for (int j = 0; j < mCols; j++)
		{
			fmpq_set_fmpz((fmpq_ptr)((mpAnyMatrixPtr)matResult)->coeff(i, j).scalar_srcptr(),
				fmpz_mat_entry(fmpz_mat_Result, i, j));
		}
	}


	/*  clean up   */
	fmpz_mat_clear(fmpz_mat_Result);
	flint_randclear(state);
}


int32_t Use_Fmpz_FlintMat(mpAnyMatrixPtr matResult, fmpz_ptr scalarResult, int32_t what, mpAnyMatrixPtr matA, mpAnyMatrixPtr matB)
{
	int mRows = (matA)->rows();
	int mCols = (matA)->cols();

	fmpz_mat_t fmpz_mat_Result, fmpz_mat_A, fmpz_mat_B;

	fmpz_mat_init(fmpz_mat_Result, mRows, mCols);
	fmpz_mat_init(fmpz_mat_A, mRows, mCols);
	fmpz_mat_init(fmpz_mat_B, mRows, mCols);

	/*  insert matA   */
	for (int i = 0; i < mRows; i++)
	{
		for (int j = 0; j < mCols; j++)
		{
			fmpz_set(fmpz_mat_entry(fmpz_mat_A, i, j),
				fmpq_numref((fmpq_ptr)(matA)->coeff(i, j).scalar_srcptr()));
		}
	}

	if ((what == mp_linalg_solve))
	{
		/*  insert matB   */
		for (int i = 0; i < mRows; i++)
		{
			for (int j = 0; j < mCols; j++)
			{
				fmpz_set(fmpz_mat_entry(fmpz_mat_B, i, j),
					fmpq_numref((fmpq_ptr)(matB)->coeff(i, j).scalar_srcptr()));
			}
		}
	}

	int32_t result = 0;
	switch (what) {
	case mp_linalg_solve: result = fmpz_mat_solve(fmpz_mat_Result, scalarResult, fmpz_mat_A, fmpz_mat_B); break;
	case mp_linalg_det: fmpz_mat_det(scalarResult, fmpz_mat_A); break;
	case mp_linalg_inverse: result = fmpz_mat_inv(fmpz_mat_Result, scalarResult, fmpz_mat_A); break;
	case mp_linalg_rank: result = fmpz_mat_rank(fmpz_mat_A); break;
	case mp_linalg_charpol: fmpz_mat_charpoly((fmpz_poly_struct*)matResult, fmpz_mat_A); break;
	case mp_linalg_trace: fmpz_mat_trace(scalarResult, fmpz_mat_A); break;
	}

	/*  insert result   */

	if ((what != mp_linalg_det) && (what != mp_linalg_trace) && (what != mp_linalg_charpol))
	{
		(*matResult).resize(mRows, mCols);
		for (int i = 0; i < mRows; i++)
		{
			for (int j = 0; j < mCols; j++)
			{
				fmpq_set_fmpz((fmpq_ptr)(matResult)->coeff(i, j).scalar_srcptr(),
					fmpz_mat_entry(fmpz_mat_Result, i, j));
			}
		}
	}

	/*  clean up   */
	fmpz_mat_clear(fmpz_mat_B);
	fmpz_mat_clear(fmpz_mat_A);
	fmpz_mat_clear(fmpz_mat_Result);

	return result;
}



int32_t Use_Fmpq_FlintMat(mpAnyMatrixPtr matResult, fmpq_ptr scalarResult, int32_t what, mpAnyMatrixPtr matA, mpAnyMatrixPtr matB)
{
	int mRows = (matA)->rows();
	int mCols = (matA)->cols();

	fmpq_mat_t fmpq_mat_Result, fmpq_mat_A, fmpq_mat_B;

	fmpq_mat_init(fmpq_mat_Result, mRows, mCols);
	fmpq_mat_init(fmpq_mat_A, mRows, mCols);
	fmpq_mat_init(fmpq_mat_B, mRows, mCols);

	/*  insert matA   */
	for (int i = 0; i < mRows; i++)
	{
		for (int j = 0; j < mCols; j++)
		{
			fmpq_set(fmpq_mat_entry(fmpq_mat_A, i, j),
				(fmpq_ptr)(matA)->coeff(i, j).scalar_srcptr());
		}
	}

	if ((what == mp_linalg_solve) || (what == mp_linalg_mul))
	{
		/*  insert matB   */
		for (int i = 0; i < mRows; i++)
		{
			for (int j = 0; j < mCols; j++)
			{
				fmpq_set(fmpq_mat_entry(fmpq_mat_B, i, j),
					(fmpq_ptr)(matB)->coeff(i, j).scalar_srcptr());
			}
		}
	}

	int32_t result = 0;
	switch (what) {
	case mp_linalg_mul: fmpq_mat_mul(fmpq_mat_Result, fmpq_mat_A, fmpq_mat_B); break;
	case mp_linalg_solve: result = fmpq_mat_solve(fmpq_mat_Result, fmpq_mat_A, fmpq_mat_B); break;
	case mp_linalg_det: fmpq_mat_det(scalarResult, fmpq_mat_A); break;
	case mp_linalg_inverse: result = fmpq_mat_inv(fmpq_mat_Result, fmpq_mat_A); break;
		//        case mp_linalg_rank: result = fmpq_mat_rank(fmpq_mat_A); break;
	case mp_linalg_charpol: fmpq_mat_charpoly((fmpq_poly_struct*)matResult, fmpq_mat_A); break;
	case mp_linalg_trace: fmpq_mat_trace(scalarResult, fmpq_mat_A); break;
	}

	/*  insert result   */

	//if ((what == mp_linalg_solve) || (what == mp_linalg_mul) || (what == mp_linalg_inverse))
	if ((what != mp_linalg_det) && (what != mp_linalg_trace) && (what != mp_linalg_charpol))
	{
		(*matResult).resize(mRows, mCols);
		for (int i = 0; i < mRows; i++)
		{
			for (int j = 0; j < mCols; j++)
			{
				fmpq_set((fmpq_ptr)(matResult)->coeff(i, j).scalar_srcptr(),
					fmpq_mat_entry(fmpq_mat_Result, i, j));
			}
		}
	}

	/*  clean up   */
	fmpq_mat_clear(fmpq_mat_B);
	fmpq_mat_clear(fmpq_mat_A);
	fmpq_mat_clear(fmpq_mat_Result);

	return result;
}



int32_t  Use_Arb_ArbMat(mpAnyMatrixPtr matResult, arb_ptr scalarResult, int32_t what, mpAnyMatrixPtr matA, mpAnyMatrixPtr matB)
{
	int32_t prec = mpfr_get_default_prec();
	int mRows = (matA)->rows();
	int mCols = (matA)->cols();

	arb_mat_t arb_mat_Result, arb_mat_A, arb_mat_B;

	arb_mat_init(arb_mat_Result, mRows, mCols);
	arb_mat_init(arb_mat_A, mRows, mCols);
	arb_mat_init(arb_mat_B, mRows, mCols);



	/*  insert matA   */
	for (int i = 0; i < mRows; i++)
	{
		for (int j = 0; j < mCols; j++)
		{
			arb_set(arb_mat_entry(arb_mat_A, i, j),
				(arb_ptr)(matA)->coeff(i, j).scalar_srcptr());
		}
	}

	if ((what == mp_linalg_solve) || (what == mp_linalg_mul))
	{
		/*  insert matB   */
		for (int i = 0; i < mRows; i++)
		{
			for (int j = 0; j < mCols; j++)
			{
				arb_set(arb_mat_entry(arb_mat_B, i, j),
					(arb_ptr)(matB)->coeff(i, j).scalar_srcptr());
			}
		}
	}


	int32_t result = 0;
	switch (what) {
	case mp_linalg_mul: arb_mat_mul(arb_mat_Result, arb_mat_A, arb_mat_B, prec); break;
	case mp_linalg_solve: result = arb_mat_solve(arb_mat_Result, arb_mat_A, arb_mat_B, prec); break;
	case mp_linalg_det: arb_mat_det(scalarResult, arb_mat_A, prec); break;
	case mp_linalg_inverse: result = arb_mat_inv(arb_mat_Result, arb_mat_A, prec); break;
	case mp_linalg_exp: arb_mat_exp(arb_mat_Result, arb_mat_A, prec); break;
	case mp_linalg_charpol: arb_mat_charpoly((arb_poly_struct*)matResult, arb_mat_A, prec); break;
	case mp_linalg_trace: arb_mat_trace(scalarResult, arb_mat_A, prec); break;
	}

	/*  insert result   */

	//if ((what == mp_linalg_solve) || (what == mp_linalg_mul) || (what == mp_linalg_inverse) || (what == mp_linalg_exp))
	if ((what != mp_linalg_det) && (what != mp_linalg_trace) && (what != mp_linalg_charpol))
		{
		(*matResult).resize(mRows, mCols);
		for (int i = 0; i < mRows; i++)
		{
			for (int j = 0; j < mCols; j++)
			{
				arb_set((arb_ptr)(matResult)->coeff(i, j).scalar_srcptr(),
					arb_mat_entry(arb_mat_Result, i, j));
			}
		}
	}

	/*  clean up   */
	arb_mat_clear(arb_mat_B);
	arb_mat_clear(arb_mat_A);
	arb_mat_clear(arb_mat_Result);

	return result;
}



int32_t Use_Acb_ArbMat(mpAnyMatrixCPtr matResult, acb_ptr scalarResult, int32_t what, mpAnyMatrixCPtr matA, mpAnyMatrixCPtr matB)
{
	int32_t prec = mpfr_get_default_prec();
	int mRows = (matA)->rows();
	int mCols = (matA)->cols();

	acb_mat_t acb_mat_Result, acb_mat_A, acb_mat_B;

	acb_mat_init(acb_mat_Result, mRows, mCols);
	acb_mat_init(acb_mat_A, mRows, mCols);
	acb_mat_init(acb_mat_B, mRows, mCols);


	/*  insert matA into acb_mat_A  */
	for (int i = 0; i < mRows; i++)
	{
		for (int j = 0; j < mCols; j++)
		{
			acb_set_arb_arb(arb_mat_entry(acb_mat_A, i, j),
				(arb_ptr)real((matA)->coeff(i, j)).scalar_srcptr(),
				(arb_ptr)imag((matA)->coeff(i, j)).scalar_srcptr());
		}
	}

	if ((what == mp_linalg_solve) || (what == mp_linalg_mul))
	{
		/*  insert matB into acb_mat_B  */
		for (int i = 0; i < mRows; i++)
		{
			for (int j = 0; j < mCols; j++)
			{
				acb_set_arb_arb(arb_mat_entry(acb_mat_B, i, j),
					(arb_ptr)real((matB)->coeff(i, j)).scalar_srcptr(),
					(arb_ptr)imag((matB)->coeff(i, j)).scalar_srcptr());
			}
		}
	}

	int32_t result = 0;
	switch (what) {
	case mp_linalg_mul: acb_mat_mul(acb_mat_Result, acb_mat_A, acb_mat_B, prec); break;
	case mp_linalg_solve: result = acb_mat_solve(acb_mat_Result, acb_mat_A, acb_mat_B, prec); break;
	case mp_linalg_det: acb_mat_det(scalarResult, acb_mat_A, prec); break;
	case mp_linalg_inverse: result = acb_mat_inv(acb_mat_Result, acb_mat_A, prec); break;
	case mp_linalg_exp: acb_mat_exp(acb_mat_Result, acb_mat_A, prec); break;
	case mp_linalg_charpol: acb_mat_charpoly((acb_poly_struct*)matResult, acb_mat_A, prec); break;
	case mp_linalg_trace: acb_mat_trace(scalarResult, acb_mat_A, prec); break;
	}


	/*  insert result   */

	//if ((what == mp_linalg_solve) || (what == mp_linalg_mul) || (what == mp_linalg_inverse) || (what == mp_linalg_exp))
	if ((what != mp_linalg_det) && (what != mp_linalg_trace) && (what != mp_linalg_charpol))
	{
		(*matResult).resize(mRows, mCols);
		for (int i = 0; i < mRows; i++)
		{
			for (int j = 0; j < mCols; j++)
			{
				(*matResult)(i, j) =
					std::complex<mpAny::mpscalar>(acb_realref(acb_mat_entry(acb_mat_Result, i, j)),
						acb_imagref(acb_mat_entry(acb_mat_Result, i, j)));
			}
		}
	}

	/*  clean up   */
	acb_mat_clear(acb_mat_B);
	acb_mat_clear(acb_mat_A);
	acb_mat_clear(acb_mat_Result);

	return result;
}





/* mat sin etc, FFT etc, eigenvalues etc  */

int32_t Use_Acb_ArbMat2(mpAnyMatrixCPtr matResult1, mpAnyMatrixCPtr matResult2, acb_ptr scalarResult, int32_t what,
	mpAnyMatrixCPtr matA, mpAnyMatrixCPtr matB)
{
	int32_t prec = mpfr_get_default_prec();
	int mRows = (matA)->rows();
	int mCols = (matA)->cols();

	acb_mat_t acb_mat_Result, acb_mat_A, acb_mat_B;

	acb_mat_init(acb_mat_Result, mRows, mCols);
	acb_mat_init(acb_mat_A, mRows, mCols);
	acb_mat_init(acb_mat_B, mRows, mCols);


	/*  insert matA into acb_mat_A  */
	for (int i = 0; i < mRows; i++)
	{
		for (int j = 0; j < mCols; j++)
		{
			acb_set_arb_arb(arb_mat_entry(acb_mat_A, i, j),
				(arb_ptr)real((matA)->coeff(i, j)).scalar_srcptr(),
				(arb_ptr)imag((matA)->coeff(i, j)).scalar_srcptr());
		}
	}

	if ((what == mp_linalg_solve))
	{
		/*  insert matB into acb_mat_B  */
		for (int i = 0; i < mRows; i++)
		{
			for (int j = 0; j < mCols; j++)
			{
				acb_set_arb_arb(arb_mat_entry(acb_mat_B, i, j),
					(arb_ptr)real((matB)->coeff(i, j)).scalar_srcptr(),
					(arb_ptr)imag((matB)->coeff(i, j)).scalar_srcptr());
			}
		}
	}

	int32_t result = 0;
	switch (what) {
	case mp_linalg_solve: result = acb_mat_solve(acb_mat_Result, acb_mat_A, acb_mat_B, prec); break;
	case mp_linalg_det: acb_mat_det(scalarResult, acb_mat_A, prec); break;
	case mp_linalg_inverse: result = acb_mat_inv(acb_mat_Result, acb_mat_A, prec); break;
	case mp_linalg_exp: acb_mat_exp(acb_mat_Result, acb_mat_A, prec); break;
	case mp_linalg_charpol: acb_mat_charpoly((acb_poly_struct*)matResult1, acb_mat_A, prec); break;
	case mp_linalg_trace: acb_mat_trace(scalarResult, acb_mat_A, prec); break;
	}


	/*  insert result   */

	if ((what == mp_linalg_solve) || (what == mp_linalg_inverse) || (what == mp_linalg_exp))
	{
		(*matResult1).resize(mRows, mCols);
		for (int i = 0; i < mRows; i++)
		{
			for (int j = 0; j < mCols; j++)
			{
				(*matResult1)(i, j) =
					std::complex<mpAny::mpscalar>(acb_realref(acb_mat_entry(acb_mat_Result, i, j)),
						acb_imagref(acb_mat_entry(acb_mat_Result, i, j)));
			}
		}
	}

	/*  clean up   */
	acb_mat_clear(acb_mat_B);
	acb_mat_clear(acb_mat_A);
	acb_mat_clear(acb_mat_Result);

	return result;
}




void AcbMatEigEnclosureRump(acb_ptr res_lambda, mpAnyMatrixCPtr matJ,	mpAnyMatrixCPtr matR,   mpAnyMatrixCPtr matA, acb_ptr lambda_approx, mpAnyMatrixCPtr matR_approx)
{
	acb_mat_t J;
	acb_mat_t R;
	acb_mat_t A;
	acb_mat_t R_approx;

	int32_t prec = mpfr_get_default_prec();
	int mRows = (matA)->rows();
	int mCols = (matA)->cols();

	acb_mat_init(J, mRows, mCols);
	acb_mat_init(R, mRows, mCols);

	acb_mat_init(A, mRows, mCols);
	//acb_mat_init(R_approx, mRows, mCols);
	acb_mat_init(R_approx, mRows, 1);

//	printf("Before insert matA into A \n");
	/*  insert matA into A  */
	for (int i = 0; i < mRows; i++)
	{
		for (int j = 0; j < mCols; j++)
		{
			acb_set_arb_arb(arb_mat_entry(A, i, j),
				(arb_ptr)real((matA)->coeff(i, j)).scalar_srcptr(),
				(arb_ptr)imag((matA)->coeff(i, j)).scalar_srcptr());
		}
	}

//	printf("Listing of A \n");
//    acb_mat_printd(A, 10);
//	printf("Before insert matR_approx into R_approx \n");

	/*  insert matR_approx into R_approx  */
	for (int i = 0; i < mRows; i++)
	{
//		for (int j = 0; j < mCols; j++)
		for (int j = 0; j < 1; j++)
		{
			acb_set_arb_arb(arb_mat_entry(R_approx, i, j),
				(arb_ptr)real((matR_approx)->coeff(i, j)).scalar_srcptr(),
				(arb_ptr)imag((matR_approx)->coeff(i, j)).scalar_srcptr());
		}
	}

//	printf("Listing of R_approx \n");
//    acb_mat_printd(R_approx, 10);
//	printf("Before acb_mat_eig_enclosure_rump \n");

	acb_mat_eig_enclosure_rump(res_lambda, J, R, A, lambda_approx, R_approx, prec);



//	printf("Before insert result matJ \n");
	/*  insert result matJ  */
    (*matJ).resize(mRows, mCols);
    for (int i = 0; i < mRows; i++)
    {
        for (int j = 0; j < mCols; j++)
        {
            (*matJ)(i, j) =
                std::complex<mpAny::mpscalar>(acb_realref(acb_mat_entry(J, i, j)),
                    acb_imagref(acb_mat_entry(J, i, j)));
        }
    }


//	printf("Before insert result matR \n");
	/*  insert result matR  */
    (*matR).resize(mRows, mCols);
    for (int i = 0; i < mRows; i++)
    {
        for (int j = 0; j < mCols; j++)
        {
            (*matR)(i, j) =
                std::complex<mpAny::mpscalar>(acb_realref(acb_mat_entry(R, i, j)),
                    acb_imagref(acb_mat_entry(R, i, j)));
        }
    }



	/*  clean up   */
	acb_mat_clear(J);
	acb_mat_clear(R);
	acb_mat_clear(A);
	acb_mat_clear(R_approx);

}


void Lib_AcbMatEigEnclosureRump(AcbPtr res_lambda, mpNumMatrixPtr matJ,	mpNumMatrixPtr matR, mpNumMatrixPtr matA, AcbPtr lambda_approx, mpNumMatrixPtr matR_approx)
{
    AcbMatEigEnclosureRump((acb_ptr)res_lambda, (mpAnyMatrixCPtr)matJ, (mpAnyMatrixCPtr)matR, (mpAnyMatrixCPtr)matA, (acb_ptr)lambda_approx, (mpAnyMatrixCPtr)matR_approx);
}

int32_t AcbMatEigSimple(mpAnyMatrixCPtr matE, mpAnyMatrixCPtr matL, mpAnyMatrixCPtr matR,   mpAnyMatrixCPtr matA, mpAnyMatrixCPtr matE_approx, mpAnyMatrixCPtr matR_approx)
{
	int32_t result = 0;
	acb_ptr E;
	acb_mat_t L;
	acb_mat_t R;
	acb_mat_t A;
	acb_ptr E_approx;
	acb_mat_t R_approx;

	int32_t prec = mpfr_get_default_prec();
	int mRows = (matA)->rows();
	int mCols = (matA)->cols();
	slong n = mRows;

	E = _acb_vec_init(n);
	E_approx = _acb_vec_init(n);

	acb_mat_init(L, mRows, mCols);
	acb_mat_init(R, mRows, mCols);

	acb_mat_init(A, mRows, mCols);
	acb_mat_init(R_approx, mRows, mCols);



//	printf("Before insert matE_approx into E_approx \n");
	/*  insert matE_approx into E_approx  */
	for (slong i = 0; i < mRows; i++)
	{
			acb_set_arb_arb(E_approx + i,
				(arb_ptr)real((matE_approx)->coeff(i, 0)).scalar_srcptr(),
				(arb_ptr)imag((matE_approx)->coeff(i, 0)).scalar_srcptr());

//            acb_printd(E_approx+i, 10);
//            printf("\n");
	}




//	printf("Before insert matA into A \n");
	/*  insert matA into A  */
	for (int i = 0; i < mRows; i++)
	{
		for (int j = 0; j < mCols; j++)
		{
			acb_set_arb_arb(arb_mat_entry(A, i, j),
				(arb_ptr)real((matA)->coeff(i, j)).scalar_srcptr(),
				(arb_ptr)imag((matA)->coeff(i, j)).scalar_srcptr());
		}
	}

//	printf("Listing of A \n");
//    acb_mat_printd(A, 10);
//	printf("Before insert matR_approx into R_approx \n");

	/*  insert matR_approx into R_approx  */
	for (int i = 0; i < mRows; i++)
	{
		for (int j = 0; j < mCols; j++)
		{
			acb_set_arb_arb(arb_mat_entry(R_approx, i, j),
				(arb_ptr)real((matR_approx)->coeff(i, j)).scalar_srcptr(),
				(arb_ptr)imag((matR_approx)->coeff(i, j)).scalar_srcptr());
		}
	}

//	printf("Listing of R_approx \n");
//    acb_mat_printd(R_approx, 10);
//	printf("Before acb_mat_eig_enclosure_rump \n");






	result = acb_mat_eig_simple(E, L, R, A, E_approx, R_approx, prec);





//	printf("Before insert result matL \n");
	/*  insert result matL  */
    (*matL).resize(mRows, mCols);
    for (int i = 0; i < mRows; i++)
    {
        for (int j = 0; j < mCols; j++)
        {
            (*matL)(i, j) =
                std::complex<mpAny::mpscalar>(acb_realref(acb_mat_entry(L, i, j)),
                    acb_imagref(acb_mat_entry(L, i, j)));
        }
    }


//	printf("Before insert result matR \n");
	/*  insert result matR  */
    (*matR).resize(mRows, mCols);
    for (int i = 0; i < mRows; i++)
    {
        for (int j = 0; j < mCols; j++)
        {
            (*matR)(i, j) =
                std::complex<mpAny::mpscalar>(acb_realref(acb_mat_entry(R, i, j)),
                    acb_imagref(acb_mat_entry(R, i, j)));
        }
    }



//	printf("Before insert result E \n");
	/*  insert E into matE  */
	for (int i = 0; i < mRows; i++)
	{
        (*matE)(i, 0) = std::complex<mpAny::mpscalar>(acb_realref(E + i), acb_imagref(E + i));
	}



	/*  clean up   */
	acb_mat_clear(L);
	acb_mat_clear(R);
	acb_mat_clear(A);
	acb_mat_clear(R_approx);

	_acb_vec_clear(E_approx, n);
	_acb_vec_clear(E, n);
	return result;

}



int32_t Lib_AcbMatEigSimple(mpNumMatrixPtr matResultE, mpNumMatrixPtr matResultL, mpNumMatrixPtr matResultR,   mpNumMatrixPtr matA, mpNumMatrixPtr matE_approx, mpNumMatrixPtr matR_approx)
{
    int32_t result = AcbMatEigSimple((mpAnyMatrixCPtr)matResultE, (mpAnyMatrixCPtr)matResultL, (mpAnyMatrixCPtr)matResultR,   (mpAnyMatrixCPtr)matA, (mpAnyMatrixCPtr)matE_approx, (mpAnyMatrixCPtr)matR_approx);
    return result;
}



int32_t AcbMatEigMultiple(mpAnyMatrixCPtr matE, mpAnyMatrixCPtr matA, mpAnyMatrixCPtr matE_approx, mpAnyMatrixCPtr matR_approx)
{
	int32_t result = 0;
	acb_ptr E;
	acb_mat_t A;
	acb_ptr E_approx;
	acb_mat_t R_approx;

	int32_t prec = mpfr_get_default_prec();
	int mRows = (matA)->rows();
	int mCols = (matA)->cols();
	slong n = mRows;

	E = _acb_vec_init(n);
	E_approx = _acb_vec_init(n);

	acb_mat_init(A, mRows, mCols);
	acb_mat_init(R_approx, mRows, mCols);

//	printf("Before insert matE_approx into E_approx \n");
	/*  insert matE_approx into E_approx  */
	for (slong i = 0; i < mRows; i++)
	{
			acb_set_arb_arb(E_approx + i,
				(arb_ptr)real((matE_approx)->coeff(i, 0)).scalar_srcptr(),
				(arb_ptr)imag((matE_approx)->coeff(i, 0)).scalar_srcptr());
//            acb_printd(E_approx+i, 10);
//            printf("\n");
	}


//	printf("Before insert matA into A \n");
	/*  insert matA into A  */
	for (int i = 0; i < mRows; i++)
	{
		for (int j = 0; j < mCols; j++)
		{
			acb_set_arb_arb(arb_mat_entry(A, i, j),
				(arb_ptr)real((matA)->coeff(i, j)).scalar_srcptr(),
				(arb_ptr)imag((matA)->coeff(i, j)).scalar_srcptr());
		}
	}

//	printf("Listing of A \n");
//    acb_mat_printd(A, 10);
//	printf("Before insert matR_approx into R_approx \n");

	/*  insert matR_approx into R_approx  */
	for (int i = 0; i < mRows; i++)
	{
		for (int j = 0; j < mCols; j++)
		{
			acb_set_arb_arb(arb_mat_entry(R_approx, i, j),
				(arb_ptr)real((matR_approx)->coeff(i, j)).scalar_srcptr(),
				(arb_ptr)imag((matR_approx)->coeff(i, j)).scalar_srcptr());
		}
	}

//	printf("Listing of R_approx \n");
//    acb_mat_printd(R_approx, 10);
//	printf("Before acb_mat_eig_enclosure_rump \n");



	result = acb_mat_eig_multiple(E, A, E_approx, R_approx, prec);



//	printf("Before insert result E \n");
	/*  insert E into matE  */
	for (int i = 0; i < mRows; i++)
	{
        (*matE)(i, 0) = std::complex<mpAny::mpscalar>(acb_realref(E + i), acb_imagref(E + i));
	}

	/*  clean up   */
	acb_mat_clear(A);
	acb_mat_clear(R_approx);

	_acb_vec_clear(E_approx, n);
	_acb_vec_clear(E, n);
	return result;

}



int32_t Lib_AcbMatEigMultiple(mpNumMatrixPtr matResultE, mpNumMatrixPtr matA, mpNumMatrixPtr matE_approx, mpNumMatrixPtr matR_approx)
{
    int32_t result = AcbMatEigMultiple((mpAnyMatrixCPtr)matResultE, (mpAnyMatrixCPtr)matA, (mpAnyMatrixCPtr)matE_approx, (mpAnyMatrixCPtr)matR_approx);
    return result;
}





int32_t Lib_Use_FlintArbMat(mpNumMatrixPtr matResult, ScalarPtr scalarResult, int32_t mpdata, int32_t what, mpNumMatrixPtr matA, mpNumMatrixPtr matB)
{
	int32_t result = 0;
	switch (mpdata) {


	case mp_fmpz: result = Use_Fmpz_FlintMat((mpAnyMatrixPtr)matResult, (fmpz_ptr)scalarResult, what, (mpAnyMatrixPtr)matA, (mpAnyMatrixPtr)matB); break;
	case mp_fmpq: result = Use_Fmpq_FlintMat((mpAnyMatrixPtr)matResult, (fmpq_ptr)scalarResult, what, (mpAnyMatrixPtr)matA, (mpAnyMatrixPtr)matB); break;
	case mp_arb: result = Use_Arb_ArbMat((mpAnyMatrixPtr)matResult, (arb_ptr)scalarResult, what, (mpAnyMatrixPtr)matA, (mpAnyMatrixPtr)matB); break;
	case mp_acb: result = Use_Acb_ArbMat((mpAnyMatrixCPtr)matResult, (acb_ptr)scalarResult, what, (mpAnyMatrixCPtr)matA, (mpAnyMatrixCPtr)matB); break;

	}
	return result;
}



void Lib_Set_Default(int32_t what, int32_t value)
{
	switch (what) {
	case mp_default_prec: {
		Lib_Mpfr_Set_Default_Prec(value);
	}
	break;
	}
}


int32_t Lib_Get_Default(int32_t what)
{
	int32_t res = 0;
	switch (what) {
	case mp_default_prec: res = Lib_Mpfr_Get_Default_Prec(); break;
	}
	return res;
}

//

///***********************************************************************************/
///***********************************************************************************/
//




void Lib_ConvertMatrixAndPoly(mpNumMatrixPtr Result, int32_t proc, int32_t op1_type, int32_t op2_type, mpNumMatrixPtr Source)
{


	if (proc == mp_conv_mat_set_real_part_in_complex)
	{
		switch (op1_type)
		{
		case mp_mpcf: {
			switch (op2_type) {
			case mp_mpcf: Lib_Set_Matrix_Mode(mp_mprf); (*((mpAnyMatrixCPtr)Result)).real() = *((mpAnyMatrixPtr)Source); break;
			}
		} break;
		case mp_acb: {
			switch (op2_type) {
			case mp_acb: Lib_Set_Matrix_Mode(mp_arb); (*((mpAnyMatrixCPtr)Result)).real() = *((mpAnyMatrixPtr)Source); break;
			}
		} break;
		}
	}


	if (proc == mp_conv_mat_set_imag_part_in_complex)
	{
		switch (op1_type)
		{
		case mp_mpcf: {
			switch (op2_type) {
			case mp_mpcf: Lib_Set_Matrix_Mode(mp_mprf); (*((mpAnyMatrixCPtr)Result)).imag() = *((mpAnyMatrixPtr)Source); break;
			}
		} break;
		case mp_acb: {
			switch (op2_type) {
			case mp_acb: Lib_Set_Matrix_Mode(mp_arb); (*((mpAnyMatrixCPtr)Result)).imag() = *((mpAnyMatrixPtr)Source); break;
			}
		} break;
		}
	}


	if (proc == mp_conv_mat_get_real_part_from_complex)
	{
		switch (op1_type)
		{
		case mp_mpcf: {
			switch (op2_type) {
			case mp_mpcf: Lib_Set_Matrix_Mode(mp_mprf); *((mpAnyMatrixPtr)Result) = (*((mpAnyMatrixCPtr)Source)).real(); break;
			}
		} break;
		case mp_acb: {
			switch (op2_type) {
			case mp_acb: Lib_Set_Matrix_Mode(mp_arb); *((mpAnyMatrixPtr)Result) = (*((mpAnyMatrixCPtr)Source)).real(); break;
			}
		} break;
		}
	}


	if (proc == mp_conv_mat_get_imag_part_from_complex)
	{
		switch (op1_type)
		{

		case mp_mpcf: {
			switch (op2_type) {
			case mp_mpcf: Lib_Set_Matrix_Mode(mp_mprf); *((mpAnyMatrixPtr)Result) = (*((mpAnyMatrixCPtr)Source)).imag(); break;
			}
		} break;


		case mp_acb: {
			switch (op2_type) {
			case mp_acb: Lib_Set_Matrix_Mode(mp_arb); *((mpAnyMatrixPtr)Result) = (*((mpAnyMatrixCPtr)Source)).imag(); break;
			}
		} break;

		}
	}



}

