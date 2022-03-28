/*
 * @(#)Function2Arg.cs        5.0.0    2022-03-28
 *
 * You may use this software under the condition of "Simplified BSD License"
 *
 * Copyright 2010-2022 MARIUSZ GROMADA. All rights reserved.
 *
 * Redistribution and use in source and binary forms, with or without modification, are
 * permitted provided that the following conditions are met:
 *
 *    1. Redistributions of source code must retain the above copyright notice, this list of
 *       conditions and the following disclaimer.
 *
 *    2. Redistributions in binary form must reproduce the above copyright notice, this list
 *       of conditions and the following disclaimer in the documentation and/or other materials
 *       provided with the distribution.
 *
 * THIS SOFTWARE IS PROVIDED BY <MARIUSZ GROMADA> ``AS IS'' AND ANY EXPRESS OR IMPLIED
 * WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND
 * FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL <COPYRIGHT HOLDER> OR
 * CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR
 * CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR
 * SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON
 * ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING
 * NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF
 * ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
 *
 * The views and conclusions contained in the software and documentation are those of the
 * authors and should not be interpreted as representing official policies, either expressed
 * or implied, of MARIUSZ GROMADA.
 *
 * If you have any questions/bugs feel free to contact:
 *
 *     Mariusz Gromada
 *     mariuszgromada.org@gmail.com
 *     http://mathparser.org
 *     http://mathspace.pl
 *     http://janetsudoku.mariuszgromada.org
 *     http://github.com/mariuszgromada/MathParser.org-mXparser
 *     http://mariuszgromada.github.io/MathParser.org-mXparser
 *     http://mxparser.sourceforge.net
 *     http://bitbucket.org/mariuszgromada/mxparser
 *     http://mxparser.codeplex.com
 *     http://github.com/mariuszgromada/Janet-Sudoku
 *     http://janetsudoku.codeplex.com
 *     http://sourceforge.net/projects/janetsudoku
 *     http://bitbucket.org/mariuszgromada/janet-sudoku
 *     http://github.com/mariuszgromada/MathParser.org-mXparser
 *     http://scalarmath.org/
 *     https://play.google.com/store/apps/details?id=org.mathparser.scalar.lite
 *     https://play.google.com/store/apps/details?id=org.mathparser.scalar.pro
 *
 *                              Asked if he believes in one God, a mathematician answered:
 *                              "Yes, up to isomorphism."
 */
using System;

namespace org.mariuszgromada.math.mxparser.parsertokens {
	/**
	 * Binary functions (2 arguments) - mXparser tokens definition.
	 *
	 * @author         <b>Mariusz Gromada</b><br>
	 *                 <a href="mailto:mariuszgromada.org@gmail.com">mariuszgromada.org@gmail.com</a><br>
	 *                 <a href="http://mathspace.pl" target="_blank">MathSpace.pl</a><br>
	 *                 <a href="http://mathparser.org" target="_blank">MathParser.org - mXparser project page</a><br>
	 *                 <a href="http://github.com/mariuszgromada/MathParser.org-mXparser" target="_blank">mXparser on GitHub</a><br>
	 *                 <a href="http://mxparser.sourceforge.net" target="_blank">mXparser on SourceForge</a><br>
	 *                 <a href="http://bitbucket.org/mariuszgromada/mxparser" target="_blank">mXparser on Bitbucket</a><br>
	 *                 <a href="http://mxparser.codeplex.com" target="_blank">mXparser on CodePlex</a><br>
	 *                 <a href="http://janetsudoku.mariuszgromada.org" target="_blank">Janet Sudoku - project web page</a><br>
	 *                 <a href="http://github.com/mariuszgromada/Janet-Sudoku" target="_blank">Janet Sudoku on GitHub</a><br>
	 *                 <a href="http://janetsudoku.codeplex.com" target="_blank">Janet Sudoku on CodePlex</a><br>
	 *                 <a href="http://sourceforge.net/projects/janetsudoku" target="_blank">Janet Sudoku on SourceForge</a><br>
	 *                 <a href="http://bitbucket.org/mariuszgromada/janet-sudoku" target="_blank">Janet Sudoku on BitBucket</a><br>
	 *                 <a href="https://play.google.com/store/apps/details?id=org.mathparser.scalar.lite" target="_blank">Scalar Free</a><br>
	 *                 <a href="https://play.google.com/store/apps/details?id=org.mathparser.scalar.pro" target="_blank">Scalar Pro</a><br>
	 *                 <a href="http://scalarmath.org/" target="_blank">ScalarMath.org</a><br>
	 *
	 * @version        5.0.0
	 */
	[CLSCompliant(true)]
	public sealed class Function2Arg {
		/*
		 * BinaryFunction - token type id.
		 */
		public const int TYPE_ID							= 5;
		public const String TYPE_DESC						= "Binary Function";
		/*
		 * BinaryFunction - tokens id.
		 */
		public const int LOG_ID								= 1;
		public const int MOD_ID								= 2;
		public const int BINOM_COEFF_ID						= 3;
		public const int BERNOULLI_NUMBER_ID				= 4;
		public const int STIRLING1_NUMBER_ID				= 5;
		public const int STIRLING2_NUMBER_ID				= 6;
		public const int WORPITZKY_NUMBER_ID				= 7;
		public const int EULER_NUMBER_ID					= 8;
		public const int KRONECKER_DELTA_ID					= 9;
		public const int EULER_POLYNOMIAL_ID				= 10;
		public const int HARMONIC_NUMBER_ID					= 11;
		public const int RND_UNIFORM_CONT_ID				= 12;
		public const int RND_UNIFORM_DISCR_ID				= 13;
		public const int ROUND_ID							= 14;
		public const int RND_NORMAL_ID						= 15;
		public const int NDIG_ID							= 16;
		public const int DIGIT10_ID							= 17;
		public const int FACTVAL_ID							= 18;
		public const int FACTEXP_ID							= 19;
		public const int ROOT_ID							= 20;
		public const int INC_GAMMA_LOWER_ID					= 21;
		public const int INC_GAMMA_UPPER_ID					= 22;
		public const int REG_GAMMA_LOWER_ID					= 23;
		public const int REG_GAMMA_UPPER_ID					= 24;
		public const int PERMUTATIONS_ID					= 25;
		public const int BETA_ID							= 26;
		public const int LOG_BETA_ID						= 27;
		public const int PDF_STUDENT_T_ID					= 28;
		public const int CDF_STUDENT_T_ID					= 29;
		public const int QNT_STUDENT_T_ID					= 30;
		/*
		 * BinaryFunction - tokens key words.
		 */
		public const String LOG_STR 						= "log";
		public const String MOD_STR 						= "mod";
		public const String BINOM_COEFF_STR					= "C";
		public const String BINOM_COEFF_NCK_STR				= "nCk";
		public const String BERNOULLI_NUMBER_STR			= "Bern";
		public const String STIRLING1_NUMBER_STR			= "Stirl1";
		public const String STIRLING2_NUMBER_STR			= "Stirl2";
		public const String WORPITZKY_NUMBER_STR			= "Worp";
		public const String EULER_NUMBER_STR				= "Euler";
		public const String KRONECKER_DELTA_STR				= "KDelta";
		public const String EULER_POLYNOMIAL_STR			= "EulerPol";
		public const String HARMONIC_NUMBER_STR				= "Harm";
		public const String RND_UNIFORM_CONT_STR 			= "rUni";
		public const String RND_UNIFORM_DISCR_STR  			= "rUnid";
		public const String ROUND_STR						= "round";
		public const String RND_NORMAL_STR					= "rNor";
		public const String NDIG_STR						= "ndig";
		public const String DIGIT10_STR						= "dig10";
		public const String FACTVAL_STR						= "factval";
		public const String FACTEXP_STR						= "factexp";
		public const String ROOT_STR						= "root";
		public const String INC_GAMMA_LOWER_STR				= "GammaL";
		public const String INC_GAMMA_UPPER_STR				= "GammaU";
		public const String REG_GAMMA_LOWER_STR				= "GammaRegL";
		public const String REG_GAMMA_UPPER_STR				= "GammaRegU";
		public const String REG_GAMMA_LOWER_P_STR			= "GammaP";
		public const String REG_GAMMA_UPPER_Q_STR			= "GammaQ";
		public const String PERMUTATIONS_STR				= "nPk";
		public const String BETA_STR						= "Beta";
		public const String LOG_BETA_STR					= "logBeta";
		public const String PDF_STUDENT_T_STR				= "pStud";
		public const String CDF_STUDENT_T_STR				= "cStud";
		public const String QNT_STUDENT_T_STR				= "qStud";
		/*
		 * BinaryFunction - syntax.
		 */
		public static readonly String LOG_SYN 						= SyntaxStringBuilder.binaryFunction(LOG_STR, SyntaxStringBuilder.a, SyntaxStringBuilder.b);
		public static readonly String MOD_SYN 						= SyntaxStringBuilder.binaryFunction(MOD_STR, SyntaxStringBuilder.a, SyntaxStringBuilder.b);
		public static readonly String BINOM_COEFF_SYN				= SyntaxStringBuilder.binaryFunction(BINOM_COEFF_STR, SyntaxStringBuilder.n, SyntaxStringBuilder.k);
		public static readonly String BERNOULLI_NUMBER_SYN			= SyntaxStringBuilder.binaryFunction(BERNOULLI_NUMBER_STR, SyntaxStringBuilder.m, SyntaxStringBuilder.n);
		public static readonly String STIRLING1_NUMBER_SYN			= SyntaxStringBuilder.binaryFunction(STIRLING1_NUMBER_STR, SyntaxStringBuilder.n, SyntaxStringBuilder.k);
		public static readonly String STIRLING2_NUMBER_SYN			= SyntaxStringBuilder.binaryFunction(STIRLING2_NUMBER_STR, SyntaxStringBuilder.n, SyntaxStringBuilder.k);
		public static readonly String WORPITZKY_NUMBER_SYN			= SyntaxStringBuilder.binaryFunction(WORPITZKY_NUMBER_STR, SyntaxStringBuilder.n, SyntaxStringBuilder.k);
		public static readonly String EULER_NUMBER_SYN				= SyntaxStringBuilder.binaryFunction(EULER_NUMBER_STR, SyntaxStringBuilder.n, SyntaxStringBuilder.k);
		public static readonly String KRONECKER_DELTA_SYN			= SyntaxStringBuilder.binaryFunction(KRONECKER_DELTA_STR, SyntaxStringBuilder.i, SyntaxStringBuilder.j);
		public static readonly String EULER_POLYNOMIAL_SYN			= SyntaxStringBuilder.binaryFunction(EULER_POLYNOMIAL_STR, SyntaxStringBuilder.m, SyntaxStringBuilder.x);
		public static readonly String HARMONIC_NUMBER_SYN			= SyntaxStringBuilder.binaryFunction(HARMONIC_NUMBER_STR, SyntaxStringBuilder.x, SyntaxStringBuilder.n);
		public static readonly String RND_UNIFORM_CONT_SYN 			= SyntaxStringBuilder.binaryFunction(RND_UNIFORM_CONT_STR, SyntaxStringBuilder.a, SyntaxStringBuilder.b);
		public static readonly String RND_UNIFORM_DISCR_SYN  		= SyntaxStringBuilder.binaryFunction(RND_UNIFORM_DISCR_STR, SyntaxStringBuilder.a, SyntaxStringBuilder.b);
		public static readonly String ROUND_SYN						= SyntaxStringBuilder.binaryFunction(ROUND_STR, SyntaxStringBuilder.x, SyntaxStringBuilder.n);
		public static readonly String RND_NORMAL_SYN				= SyntaxStringBuilder.binaryFunction(RND_NORMAL_STR, SyntaxStringBuilder.mean, SyntaxStringBuilder.stdv);
		public static readonly String NDIG_SYN						= SyntaxStringBuilder.binaryFunction(NDIG_STR, SyntaxStringBuilder.number, SyntaxStringBuilder.basestr);
		public static readonly String DIGIT10_SYN					= SyntaxStringBuilder.binaryFunction(DIGIT10_STR, SyntaxStringBuilder.num, SyntaxStringBuilder.pos);
		public static readonly String FACTVAL_SYN					= SyntaxStringBuilder.binaryFunction(FACTVAL_STR, SyntaxStringBuilder.number, SyntaxStringBuilder.factorid);
		public static readonly String FACTEXP_SYN					= SyntaxStringBuilder.binaryFunction(FACTEXP_STR, SyntaxStringBuilder.number, SyntaxStringBuilder.factorid);
		public static readonly String ROOT_SYN						= SyntaxStringBuilder.binaryFunction(ROOT_STR, SyntaxStringBuilder.rootorder, SyntaxStringBuilder.number);
		public static readonly String INC_GAMMA_LOWER_SYN			= SyntaxStringBuilder.binaryFunction(INC_GAMMA_LOWER_STR, SyntaxStringBuilder.s, SyntaxStringBuilder.x);
		public static readonly String INC_GAMMA_UPPER_SYN			= SyntaxStringBuilder.binaryFunction(INC_GAMMA_UPPER_STR, SyntaxStringBuilder.s, SyntaxStringBuilder.x);
		public static readonly String REG_GAMMA_LOWER_SYN			= SyntaxStringBuilder.binaryFunction(REG_GAMMA_LOWER_STR, SyntaxStringBuilder.s, SyntaxStringBuilder.x);
		public static readonly String REG_GAMMA_UPPER_SYN			= SyntaxStringBuilder.binaryFunction(REG_GAMMA_UPPER_STR, SyntaxStringBuilder.s, SyntaxStringBuilder.x);
		public static readonly String REG_GAMMA_LOWER_P_SYN			= SyntaxStringBuilder.binaryFunction(REG_GAMMA_LOWER_P_STR, SyntaxStringBuilder.s, SyntaxStringBuilder.x);
		public static readonly String REG_GAMMA_UPPER_Q_SYN			= SyntaxStringBuilder.binaryFunction(REG_GAMMA_UPPER_Q_STR, SyntaxStringBuilder.s, SyntaxStringBuilder.x);
		public static readonly String BINOM_COEFF_NCK_SYN			= SyntaxStringBuilder.binaryFunction(BINOM_COEFF_NCK_STR, SyntaxStringBuilder.n, SyntaxStringBuilder.k);
		public static readonly String PERMUTATIONS_SYN				= SyntaxStringBuilder.binaryFunction(PERMUTATIONS_STR, SyntaxStringBuilder.n, SyntaxStringBuilder.k);
		public static readonly String BETA_SYN						= SyntaxStringBuilder.binaryFunction(BETA_STR, SyntaxStringBuilder.x, SyntaxStringBuilder.y);
		public static readonly String LOG_BETA_SYN					= SyntaxStringBuilder.binaryFunction(LOG_BETA_STR, SyntaxStringBuilder.x, SyntaxStringBuilder.y);
		public static readonly String PDF_STUDENT_T_SYN				= SyntaxStringBuilder.binaryFunction(PDF_STUDENT_T_STR, SyntaxStringBuilder.x, SyntaxStringBuilder.v);
		public static readonly String CDF_STUDENT_T_SYN				= SyntaxStringBuilder.binaryFunction(CDF_STUDENT_T_STR, SyntaxStringBuilder.x, SyntaxStringBuilder.v);
		public static readonly String QNT_STUDENT_T_SYN				= SyntaxStringBuilder.binaryFunction(QNT_STUDENT_T_STR, SyntaxStringBuilder.p, SyntaxStringBuilder.v);
		/*
		 * BinaryFunction - tokens description.
		 */
		public const String LOG_DESC 						= "Logarithm function";
		public const String MOD_DESC						= "Modulo function";
		public const String BINOM_COEFF_DESC				= "Binomial coefficient function, number of k-combinations that can be drawn from n-elements set";
		public const String BERNOULLI_NUMBER_DESC			= "Bernoulli numbers";
		public const String STIRLING1_NUMBER_DESC			= "Stirling numbers of the first kind";
		public const String STIRLING2_NUMBER_DESC			= "Stirling numbers of the second kind";
		public const String WORPITZKY_NUMBER_DESC			= "Worpitzky number";
		public const String EULER_NUMBER_DESC				= "Euler number";
		public const String KRONECKER_DELTA_DESC			= "Kronecker delta";
		public const String EULER_POLYNOMIAL_DESC			= "EulerPol";
		public const String HARMONIC_NUMBER_DESC			= "Harmonic number";
		public const String RND_UNIFORM_CONT_DESC 			= "Random variable - Uniform continuous distribution U(a,b), usage example: 2*rUni(2,10)";
		public const String RND_UNIFORM_DISCR_DESC  		= "Random variable - Uniform discrete distribution U{a,b}, usage example: 2*rUnid(2,100)";
		public const String ROUND_DESC						= "Half-up rounding, usage examples: round(2.2, 0) = 2, round(2.6, 0) = 3, round(2.66,1) = 2.7";
		public const String RND_NORMAL_DESC					= "Random variable - Normal distribution N(m,s) m - mean, s - stddev, usage example: 3*rNor(0,1)";
		public const String NDIG_DESC						= "Number of digits representing the number in numeral system with given base";
		public const String DIGIT10_DESC					= "Digit at position 1 ... n (left -> right) or 0 ... -(n-1) (right -> left) - base 10 numeral system";
		public const String FACTVAL_DESC					= "Prime decomposition - factor value at position between 1 ... nfact(n) - ascending order by factor value";
		public const String FACTEXP_DESC					= "Prime decomposition - factor exponent / multiplicity at position between 1 ... nfact(n) - ascending order by factor value";
		public const String ROOT_DESC						= "N-th order root of a number";
		public const String INC_GAMMA_LOWER_DESC			= "Lower incomplete gamma special function";
		public const String INC_GAMMA_UPPER_DESC			= "Upper incomplete Gamma special function";
		public const String REG_GAMMA_LOWER_DESC			= "Lower regularized P gamma special function";
		public const String REG_GAMMA_UPPER_DESC			= "Upper regularized Q Gamma special function";
		public const String PERMUTATIONS_DESC				= "Number of k-permutations that can be drawn from n-elements set";
		public const String BETA_DESC						= "The Beta special function B(x,y), also called the Euler integral of the first kind";
		public const String LOG_BETA_DESC					= "The Log Beta special function ln B(x,y), also called the Log Euler integral of the first kind, ln B(x,y)";
		public const String PDF_STUDENT_T_DESC				= "Probability distribution function - Student's t-distribution";
		public const String CDF_STUDENT_T_DESC				= "Cumulative distribution function - Student's t-distribution";
		public const String QNT_STUDENT_T_DESC				= "Quantile function (inverse cumulative distribution function) - Student's t-distribution";
		/*
		 * BinaryFunction - since.
		 */
		public const String LOG_SINCE 						= mXparser.NAMEv10;
		public const String MOD_SINCE						= mXparser.NAMEv10;
		public const String BINOM_COEFF_SINCE				= mXparser.NAMEv10;
		public const String BINOM_COEFF_NCK_SINCE			= mXparser.NAMEv42;
		public const String BERNOULLI_NUMBER_SINCE			= mXparser.NAMEv10;
		public const String STIRLING1_NUMBER_SINCE			= mXparser.NAMEv10;
		public const String STIRLING2_NUMBER_SINCE			= mXparser.NAMEv10;
		public const String WORPITZKY_NUMBER_SINCE			= mXparser.NAMEv10;
		public const String EULER_NUMBER_SINCE				= mXparser.NAMEv10;
		public const String KRONECKER_DELTA_SINCE			= mXparser.NAMEv10;
		public const String EULER_POLYNOMIAL_SINCE			= mXparser.NAMEv10;
		public const String HARMONIC_NUMBER_SINCE			= mXparser.NAMEv10;
		public const String RND_UNIFORM_CONT_SINCE 			= mXparser.NAMEv30;
		public const String RND_UNIFORM_DISCR_SINCE  		= mXparser.NAMEv30;
		public const String ROUND_SINCE						= mXparser.NAMEv30;
		public const String RND_NORMAL_SINCE				= mXparser.NAMEv30;
		public const String NDIG_SINCE						= mXparser.NAMEv41;
		public const String DIGIT10_SINCE					= mXparser.NAMEv41;
		public const String FACTVAL_SINCE					= mXparser.NAMEv41;
		public const String FACTEXP_SINCE					= mXparser.NAMEv41;
		public const String ROOT_SINCE						= mXparser.NAMEv41;
		public const String INC_GAMMA_LOWER_SINCE			= mXparser.NAMEv42;
		public const String INC_GAMMA_UPPER_SINCE			= mXparser.NAMEv42;
		public const String REG_GAMMA_LOWER_SINCE			= mXparser.NAMEv42;
		public const String REG_GAMMA_UPPER_SINCE			= mXparser.NAMEv42;
		public const String PERMUTATIONS_SINCE				= mXparser.NAMEv42;
		public const String BETA_SINCE						= mXparser.NAMEv42;
		public const String LOG_BETA_SINCE					= mXparser.NAMEv42;
		public const String PDF_STUDENT_T_SINCE				= mXparser.NAMEv50;
		public const String CDF_STUDENT_T_SINCE				= mXparser.NAMEv50;
		public const String QNT_STUDENT_T_SINCE				= mXparser.NAMEv50;
	}
}
