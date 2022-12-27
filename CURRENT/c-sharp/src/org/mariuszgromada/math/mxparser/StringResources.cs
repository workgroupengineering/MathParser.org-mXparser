/*
 * @(#)StringResources.cs        5.2.0    2022-12-27
 *
 * MathParser.org-mXparser DUAL LICENSE AGREEMENT as of date 2022-05-22
 * The most up-to-date license is available at the below link:
 * - https://mathparser.org/mxparser-license
 *
 * AUTHOR: Copyright 2010 - 2022 Mariusz Gromada - All rights reserved
 * PUBLISHER: INFIMA - https://payhip.com/infima
 *
 * SOFTWARE means source code and/or binary form and/or documentation.
 * PRODUCT: MathParser.org-mXparser SOFTWARE
 * LICENSE: DUAL LICENSE AGREEMENT
 *
 * BY INSTALLING, COPYING, OR OTHERWISE USING THE PRODUCT, YOU AGREE TO BE
 * BOUND BY ALL OF THE TERMS AND CONDITIONS OF THE DUAL LICENSE AGREEMENT.
 *
 * AUTHOR & PUBLISHER provide the PRODUCT under the DUAL LICENSE AGREEMENT
 * model designed to meet the needs of both non-commercial use as well as
 * commercial use.
 *
 * NON-COMMERCIAL USE means any use or activity where a fee is not charged
 * and the purpose is not the sale of a good or service, and the use or
 * activity is not intended to produce a profit. NON-COMMERCIAL USE examples:
 *
 * 1. Free Open-Source Software ("FOSS").
 * 2. Non-commercial use in research, scholarly and education.
 *
 * COMMERCIAL USE means any use or activity where a fee is charged or the
 * purpose is the sale of a good or service, or the use or activity is
 * intended to produce a profit. COMMERCIAL USE examples:
 *
 * 1. OEMs (Original Equipment Manufacturers).
 * 2. ISVs (Independent Software Vendors).
 * 3. VARs (Value Added Resellers).
 * 4. Other distributors that combine and distribute commercially licensed
 *    software.
 *
 * IN CASE YOU WANT TO USE THE PRODUCT COMMERCIALLY, YOU MUST PURCHASE THE
 * APPROPRIATE LICENSE FROM "INFIMA" ONLINE STORE, STORE ADDRESS:
 *
 * 1. https://mathparser.org/order-commercial-license
 * 2. https://payhip.com/infima
 *
 * NON-COMMERCIAL LICENSE
 *
 * Redistribution and use of the PRODUCT in source and/or binary forms,
 * with or without modification, are permitted provided that the following
 * conditions are met:
 *
 * 1. Redistributions of source code must retain unmodified content of the
 *    entire MathParser.org-mXparser DUAL LICENSE AGREEMENT, including
 *    definition of NON-COMMERCIAL USE, definition of COMMERCIAL USE,
 *    NON-COMMERCIAL LICENSE conditions, COMMERCIAL LICENSE conditions, and
 *    the following DISCLAIMER.
 * 2. Redistributions in binary form must reproduce the entire content of
 *    MathParser.org-mXparser DUAL LICENSE AGREEMENT in the documentation
 *    and/or other materials provided with the distribution, including
 *    definition of NON-COMMERCIAL USE, definition of COMMERCIAL USE,
 *    NON-COMMERCIAL LICENSE conditions, COMMERCIAL LICENSE conditions, and
 *    the following DISCLAIMER.
 * 3. Any form of redistribution requires confirmation and signature of
 *    the NON-COMMERCIAL USE by successfully calling the method:
 *       License.iConfirmNonCommercialUse(...)
 *    The method call takes place only internally for logging purposes and
 *    there is no connection with other external services and no data is
 *    sent or collected. The lack of a method call (or its successful call)
 *    does not affect the operation of the PRODUCT in any way. Please see
 *    the API documentation.
 *
 * COMMERCIAL LICENSE
 *
 *  1. Before purchasing a commercial license, AUTHOR & PUBLISHER allow you
 *     to download, install and use up to three copies of the PRODUCT to
 *     perform integration tests, confirm the quality of the PRODUCT and
 *     its suitability. The testing period should be limited to fourteen
 *     days. Tests should be performed under the conditions of test
 *     environments. The purpose of the tests must not be to generate profit.
 *  2. Provided that you purchased a license from "INFIMA" online store
 *     (store address: https://mathparser.org/order-commercial-license or
 *     https://payhip.com/infima), and you comply with all below terms and
 *     conditions, and you have acknowledged and understood the following
 *     DISCLAIMER, AUTHOR & PUBLISHER grant you a nonexclusive license
 *     including the following rights:
 *  3. The license has been granted only to you, i.e., the person or entity
 *     that made the purchase, who is identified and confirmed by the data
 *     provided during the purchase.
 *  4. In case you purchased a license in the "ONE-TIME PURCHASE" model,
 *     the license has been granted only for the PRODUCT version specified
 *     in the purchase. The upgrade policy gives you additional rights and
 *     is described in the dedicated section below.
 *  5. In case you purchased a license in the "SUBSCRIPTION" model, you can
 *     install and use any version of the PRODUCT, but only during the
 *     subscription validity period.
 *  6. In case you purchased a "SINGLE LICENSE" you can install and use the
 *     PRODUCT from one workstation.
 *  7. Additional copies of the PRODUCT can be installed and used from more
 *     than one workstation; however, this number is limited to the number
 *     of workstations purchased as per order.
 *  8. In case you purchased a "SITE LICENSE ", the PRODUCT can be installed
 *     and used from all workstations located at your premises.
 *  9. You may incorporate the unmodified PRODUCT into your own products
 *     and software.
 * 10. If you purchased a license with the "SOURCE CODE" option, you may
 *     modify the PRODUCT's source code and incorporate the modified source
 *     code into your own products and/or software.
 * 11. Provided that the license validity period has not expired, you may
 *     distribute your product and/or software with the incorporated
 *     PRODUCT royalty-free.
 * 12. You may make copies of the PRODUCT for backup and archival purposes.
 * 13. Any form of redistribution requires confirmation and signature of
 *     the COMMERCIAL USE by successfully calling the method:
 *        License.iConfirmCommercialUse(...)
 *     The method call takes place only internally for logging purposes and
 *     there is no connection with other external services and no data is
 *     sent or collected. The lack of a method call (or its successful call)
 *     does not affect the operation of the PRODUCT in any way. Please see
 *     the API documentation.
 * 14. AUTHOR & PUBLISHER reserve all rights not expressly granted to you
 *     in this agreement.
 *
 * ADDITIONAL CLARIFICATION ON WORKSTATION
 *
 * A workstation is a device, a remote device, or a virtual device, used by
 * you, your employees, or other entities to whom you have commissioned the
 * tasks. For example, the number of workstations may refer to the number
 * of software developers, engineers, architects, scientists, and other
 * professionals who use the PRODUCT on your behalf. The number of
 * workstations is not the number of copies of your end-product that you
 * distribute to your end-users.
 *
 * By purchasing the COMMERCIAL LICENSE, you only pay for the number of
 * workstations, while the number of copies of your final product
 * (delivered to your end-users) is not limited.
 *
 * UPGRADE POLICY
 *
 * The PRODUCT is versioned according to the following convention:
 *
 *    [MAJOR].[MINOR].[PATCH]
 *
 * 1. COMMERCIAL LICENSE holders can install and use the updated version
 *    for bug fixes free of charge, i.e. if you have purchased a license
 *    for the [MAJOR].[MINOR] version (e.g.: 5.0), you can freely install
 *    all the various releases specified in the [PATCH] version (e.g.: 5.0.2).
 *    The license terms remain unchanged after the update.
 * 2. COMMERCIAL LICENSE holders for [MAJOR].[MINOR] version (e.g.: 5.0)
 *    can install and use the updated version [MAJOR].[MINOR + 1] free of
 *    charge, i.e., plus one release in the [MINOR] range (e.g.: 5.1). The
 *    license terms remain unchanged after the update.
 * 3. COMMERCIAL LICENSE holders who wish to upgrade their version, but are
 *    not eligible for the free upgrade, can claim a discount when
 *    purchasing the upgrade. For this purpose, please contact us via e-mail.
 *
 * DISCLAIMER
 *
 * THIS PRODUCT IS PROVIDED BY AUTHOR & PUBLISHER "AS IS" AND ANY EXPRESS
 * OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED
 * WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE
 * DISCLAIMED. IN NO EVENT SHALL AUTHOR OR PUBLISHER OR CONTRIBUTORS BE
 * LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR
 * CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF
 * SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS
 * INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN
 * CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE)
 * ARISING IN ANY WAY OUT OF THE USE OF THIS PRODUCT, EVEN IF ADVISED OF
 * THE POSSIBILITY OF SUCH DAMAGE.
 *
 * THE VIEWS AND CONCLUSIONS CONTAINED IN THE PRODUCT AND DOCUMENTATION ARE
 * THOSE OF THE AUTHORS AND SHOULD NOT BE INTERPRETED AS REPRESENTING
 * OFFICIAL POLICIES, EITHER EXPRESSED OR IMPLIED, OF AUTHOR OR PUBLISHER.
 *
 * CONTACT
 *
 * - e-mail: info@mathparser.org
 * - website: https://mathparser.org
 * - source code: https://github.com/mariuszgromada/MathParser.org-mXparser
 * - online store: https://mathparser.org/order-commercial-license
 * - online store: https://payhip.com/infima
 */
using System;

namespace org.mariuszgromada.math.mxparser {
    /**
     * A class containing definition of default user language
     * and allowing new user language definition - for instance translation.
     * Translation can be done via extending this class.
     *
     * @author         <b>Mariusz Gromada</b><br>
     *                 <a href="https://mathparser.org" target="_blank">MathParser.org - mXparser project page</a><br>
     *                 <a href="https://github.com/mariuszgromada/MathParser.org-mXparser" target="_blank">mXparser on GitHub</a><br>
     *                 <a href="https://payhip.com/INFIMA" target="_blank">INFIMA place to purchase a commercial MathParser.org-mXparser software license</a><br>
     *                 <a href="mailto:info@mathparser.org">info@mathparser.org</a><br>
     *                 <a href="https://scalarmath.org/" target="_blank">ScalarMath.org - a powerful math engine and math scripting language</a><br>
     *                 <a href="https://play.google.com/store/apps/details?id=org.mathparser.scalar.lite" target="_blank">Scalar Lite</a><br>
     *                 <a href="https://play.google.com/store/apps/details?id=org.mathparser.scalar.pro" target="_blank">Scalar Pro</a><br>
     *                 <a href="https://mathspace.pl" target="_blank">MathSpace.pl</a><br>
     *
     * @version        5.2.0
     *
     * @see StringModel
     * @see StringModel#setUserLanguage(UserLanguage)
     * @see StringModel#getUserLanguage()
     */
    public class StringResources {
        internal const String DEFAULT_USER_LANGUAGE = "English";
        // -------------------------------------------------
        internal const String DEFAULT_STARTING_SYNTAX_CHECK = "Starting syntax check...";
        internal const String DEFAULT_NO_ERRORS_DETECTED = "No errors detected.";
        internal const String DEFAULT_LEXICAL_ERROR_HAS_BEEN_FOUND = "A lexical error has been found.";
        internal const String DEFAULT_ERRORS_HAVE_BEEN_FOUND = "Errors have been found.";
        internal const String DEFAULT_ALREADY_CHECKED_NO_ERRORS = "The syntax has already been checked - no errors detected.";
        internal const String DEFAULT_SYNTAX_STATUS_UNKNOWN = "The syntax status is unknown.";
        internal const String DEFAULT_PROBLEM_WITH_EXPRESSION_SYNTAX = "There is a problem with expression syntax.";
        // -------------------------------------------------
        internal const String DEFAULT_AT_INDEX = "at index";
        internal const String DEFAULT_ENCOUNTERED = "Encountered";
        internal const String DEFAULT_WAS_EXPECTING = "Was expecting";
        internal const String DEFAULT_WAS_EXPECTING_ONE_OF = "Was expecting one of";
        internal const String DEFAULT_UNEXPECTED_EXCEPTION_WAS_ENCOUNTERED = "An unexpected exception was encountered. Probably a parser error - please report it.";
        internal const String DEFAULT_UNEXPECTED_TOKEN_MANAGER_ERROR_WAS_ENCOUNTERED = "An unexpected token manager error was encountered. Probably a parser error - please report it.";
        // -------------------------------------------------
        internal const String DEFAULT_EXPRESSION_STRING_IS_EMPTY = "The expression string is empty.";
        internal const String DEFAULT_EXPRESSION_DOES_NOT_CONTAIN_ANY_TOKENS = "The expression does not contain any tokens.";
        internal const String DEFAULT_DUPLICATED_KEYWORD = "Duplicated keywords were found. Check user-defined items. Consider using option to override built-in tokens.";
        internal const String DEFAULT_ELEMENT = "Element";
        internal const String DEFAULT_ERROR = "Error";
        internal const String DEFAULT_EXCEPTION = "Exception";
        internal const String DEFAULT_TOKEN = "Token";
        internal const String DEFAULT_INDEX = "index";
        internal const String DEFAULT_INVALID_TOKEN = "Invalid token.";
        internal const String DEFAULT_INVALID_TOKEN_POSSIBLY_MISSING_MULTIPLICATION_OPERATOR = "Invalid token. Possibly missing multiplication operator - try implied multiplication mode.";
        internal const String DEFAULT_EXPRESSION_TOKENS = "Expression tokens";
        internal const String DEFAULT_NULL_TOKENS_LIST = "NULL tokens list";
        // -------------------------------------------------
        internal const String DEFAULT_FUNCTION_WITH_EXTENDED_BODY_NO_ERRORS = "User-defined function with extended body - no errors by assumption.";
        internal const String DEFAULT_ARGUMENT_WITH_EXTENDED_BODY_NO_ERRORS = "User-defined argument with extended body - no errors by assumption.";
        internal const String DEFAULT_MULTIPLICATION_OPERATOR_MISSING_TRY_IMPLIED_MULTIPLICATION_MODE = "Possibly missing multiplication operator - try implied multiplication mode.";
        // -------------------------------------------------
        internal const String DEFAULT_STARTING_SYNTAX_CHECK_DEPENDENT_ARGUMENT = "Starting syntax check of the dependent user-defined argument.";
        internal const String DEFAULT_STARTING_SYNTAX_CHECK_RECURSIVE_ARGUMENT = "Starting syntax check of the user-defined recursive argument.";
        internal const String DEFAULT_STARTING_SYNTAX_CHECK_USER_DEFINED_FUNCTION = "Starting syntax check of the user-defined function.";
        internal const String DEFAULT_STARTING_SYNTAX_CHECK_VARIADIC_USER_DEFINED_FUNCTION = "Starting syntax check of the variadic user-defined function.";
        // -------------------------------------------------
        internal const String DEFAULT_ARGUMENT_WAS_EXPECTED = "User-defined argument was expected.";
        internal const String DEFAULT_RECURSIVE_ARGUMENT_EXPECTING_1_PARAMETER = "A recursive user-defined argument requires one parameter.";
        // -------------------------------------------------
        internal const String DEFAULT_INCORRECT_NUMBER_OF_PARAMETERS_IN_USER_DEFINED_FUNCTION = "Incorrect number of parameters in user-defined function.";
        // -------------------------------------------------
        internal const String DEFAULT_INCORRECT_NUMBER_OF_FUNCTION_PARAMETERS = "Incorrect number of function parameters.";
        internal const String DEFAULT_EXPECTED = "Expected";
        internal const String DEFAULT_PROVIDED = "provided";
        internal const String DEFAULT_USER_DEFINED_FUNCTION_EXPECTING_AT_LEAST_ONE_ARGUMENT = "Incorrect number of parameters in user-defined function - at least one argument is expected.";
        internal const String DEFAULT_EXPECTED_EVEN_NUMBER_OF_ARGUMENTS = "Even number of arguments was expected.";
        // -------------------------------------------------
        internal const String DEFAULT_INVALID_FUNCTION_NAME = "Invalid function name.";
        internal const String DEFAULT_INVALID_ARGUMENT_NAME = "Invalid argument name.";
        internal const String DEFAULT_INVALID_CONSTANT_NAME = "Invalid constant name.";
        internal const String DEFAULT_INVALID_FUNCTION_DEFINITION = "Invalid function definition.";
        internal const String DEFAULT_INVALID_ARGUMENT_DEFINITION = "Invalid argument definition.";
        internal const String DEFAULT_INVALID_CONSTANT_DEFINITION = "Invalid constant definition.";
        internal const String DEFAULT_PATTERN_DOES_NOT_MATCH = "Pattern does not match.";
        internal const String DEFAULT_PATTERN_EXAMPLES = "Pattern examples";
        // -------------------------------------------------
        internal const String DEFAULT_CONSTANT_WAS_EXPECTED = "Constant value was expected.";
        internal const String DEFAULT_USER_CONSTANT_WAS_EXPECTED = "User-defined constant was expected.";
        // -------------------------------------------------
        internal const String DEFAULT_UNARY_FUNCTION_EXPECTS_1_PARAMETER = "A unary function expects 1 parameter.";
        internal const String DEFAULT_BINARY_FUNCTION_EXPECTS_2_PARAMETERS = "A binary function expects 2 parameters.";
        internal const String DEFAULT_TERNARY_FUNCTION_EXPECTS_3_PARAMETERS = "A ternary function expects 3 parameters.";
        // -------------------------------------------------
        internal const String DEFAULT_DERIVATIVE_OPERATOR_EXPECTS_2_OR_3_OR_4_OR_5_CALCULUS_PARAMETERS = "A derivative operator expects 2 or 3 or 4 or 5 calculus parameters.";
        internal const String DEFAULT_ARGUMENT_WAS_EXPECTED_IN_A_DERIVATIVE_OPERATOR_INVOCATION = "An argument was expected in a derivative operator invocation.";
        internal const String DEFAULT_DUPLICATED_KEYWORDS_WERE_FOUND_IN_THE_CALCULUS_OPERATOR_INVOCATION = "Duplicated keywords were found in the calculus operator invocation, check calculus parameters.";
        internal const String DEFAULT_ONE_TOKEN_WAS_EXPECTED_IN_THE_CALCULUS_OPERATOR_INVOCATION = "One token (argument or unknown) was expected in the calculus operator invocation.";
        internal const String DEFAULT_NTH_ORDER_DERIVATIVE_OPERATOR_EXPECTS_3_OR_5_CALCULUS_PARAMETERS = "N-th order derivative operator expects 3 or 5 calculus parameters.";
        internal const String DEFAULT_INTEGRAL_SOLVE_OPERATOR_EXPECTS_4_CALCULUS_PARAMETERS = "The integral / solve operator expects 4 calculus parameters.";
        internal const String DEFAULT_ITERATED_OPERATOR_EXPECTS_4_OR_5_CALCULUS_PARAMETERS = "The iterated operator expects 4 or 5 calculus parameters.";
        internal const String DEFAULT_FORWARD_BACKWARD_DIFFERENCE_EXPECTS_2_OR_3_PARAMETERS = "The forward / backward difference operator expects 2 or 3 calculus parameters.";
        internal const String DEFAULT_FORWARD_BACKWARD_DIFFERENCE_ARGUMENT_WAS_EXPECTED = "An argument was expected in the forward / backward difference operator invocation.";
        internal const String DEFAULT_AT_LEAST_ONE_ARGUMENT_WAS_EXPECTED = "At least one argument was expected.";
        // -------------------------------------------------
        internal const String DEFAULT_ERROR_WHILE_EXECUTING_THE_CALCULATE = "Error while executing the calculate.";
        internal const String DEFAULT_RECURSION_CALLS_COUNTER_EXCEEDED = "Recursion calls counter exceeded maximum calls allowed.";
        internal const String DEFAULT_RECURSION_CALLS_COUNTER = "Recursion calls counter";
        internal const String DEFAULT_STARTING_CALCULATION_LOOP = "Starting calculation loop.";
        internal const String DEFAULT_CANCEL_REQUEST_FINISHING = "Cancel request encountered - finishing.";
        internal const String DEFAULT_INTERNAL_ERROR_STRANGE_TOKEN_LEVEL_FINISHING = "Internal error / strange token level - finishing. Probably a parser error - please report it.";
        internal const String DEFAULT_FATAL_ERROR_DO_NOT_KNOW_WHAT_TO_DO_WITH_THE_ENCOUNTERED_TOKEN = "Fatal error, do not know what to do with the encountered token. Probably a parser error - please report it.";
        internal const String DEFAULT_MAXIMUM_ERROR_MESSAGE_LENGTH_EXCEEDED = "The maximum error message length has been exceeded.";
        // -------------------------------------------------
        internal const String DEFAULT_STARTING = "Starting...";
        internal const String DEFAULT_PARSING = "Parsing";
        internal const String DEFAULT_CALCULATED_VALUE = "Calculated value";
        internal const String DEFAULT_EXITING = "Exiting.";
        internal const String DEFAULT_DONE = "done.";
        // -------------------------------------------------
        internal const String DEFAULT_HELP_CONTENT = "Help content";
        internal const String DEFAULT_KEYWORD = "Keyword";
        internal const String DEFAULT_SYNTAX = "Syntax";
        internal const String DEFAULT_NUMBER = "Number";
        internal const String DEFAULT_NUMBER_LITERAL = "Number literal";
        internal const String DEFAULT_TYPE = "Type";
        internal const String DEFAULT_SINCE = "Since";
        internal const String DEFAULT_DESCRIPTION = "Description";
        // -------------------------------------------------
        internal const String DEFAULT_CALC_STEPS_REGISTER_IS_EMPTY = "CalcStepsRegister is empty";
        internal const String DEFAULT_CALC_STEPS_REGISTER_FOR = "CalcStepsRegister for";
        internal const String DEFAULT_ARGUMENT = "Argument";
        internal const String DEFAULT_FUNCTION = "Function";
        internal const String DEFAULT_EXPRESSION = "Expression";
        internal const String DEFAULT_RESULT = "result";
        internal const String DEFAULT_COMPUTING_TIME = "Computing time";
        internal const String DEFAULT_GROUP_SHORT = "gr";
        internal const String DEFAULT_NUMBER_SHORT = "nr";
        internal const String DEFAULT_FIRST = "first";
        internal const String DEFAULT_LAST = "last";
        internal const String DEFAULT_DESCRIPTION_SHORT = "descr";
        internal const String DEFAULT_STEP = "step";
        // -------------------------------------------------
        internal const String DEFAULT_INFO_SERIALIZATION_PERFORMED = "Serialization has been performed:";
        internal const String DEFAULT_INFO_DESERIALIZATION_PERFORMED = "Deserialization has been performed:";
        internal const String DEFAULT_ERROR_NULL_OBJECT = "Null object passed in the parameter.";
        internal const String DEFAULT_ERROR_NULL_FILE_PATH = "Null file passed in the parameter.";
        internal const String DEFAULT_ERROR_FILE_PATH_ZERO_LENGTH = "The file path does not contain any characters.";
        internal const String DEFAULT_ERROR_IS_NOT_A_FILE = "The file path is not a file:";
        internal const String DEFAULT_ERROR_FILE_NOT_EXISTS = "The file path does not exits:";
        internal const String DEFAULT_ERROR_NULL_DATA = "Null data passed in the parameter.";
        internal const String DEFAULT_INFO_EXCEPTION = "Exception: ";
        internal const String DEFAULT_INFO_BINARY_SERIALIZATION_ENABLED = "Binary serialization is enabled. Use it only in a conscious and limited way.";
        internal const String DEFAULT_INFO_BINARY_SERIALIZATION_DISABLED = "Binary serialization is disabled. You can enable it if you are aware of security risks.";
        // -------------------------------------------------
        internal const String DEFAULT_USER_DEFINED_EXPRESSION = "User defined expression";
        internal const String DEFAULT_USER_DEFINED_ARGUMENT = "User defined argument";
        internal const String DEFAULT_USER_DEFINED_CONSTANT = "User defined constant";
        internal const String DEFAULT_USER_DEFINED_FUNCTION = "User defined function";
        internal const String DEFAULT_USER_DEFINED_RECURSIVE_ARGUMENT = "User defined recursive argument";
        // -------------------------------------------------
        internal static readonly String DEFAULT_WARNING_BINARY_SERIALIZATION_SECURITY_RISKS = "SECURITY WARNING:" + StringInvariant.NEW_LINE
                        + "Deserializing data from an untrusted source can introduce security vulnerabilities" + StringInvariant.NEW_LINE
                        + "to your application. Depending on the settings used during deserialization," + StringInvariant.NEW_LINE
                        + "untrusted data may be able to execute arbitrary code or cause a denial of service" + StringInvariant.NEW_LINE
                        + "attack. Untrusted data can come from over the network from an untrusted source" + StringInvariant.NEW_LINE
                        + "(e.g. any network client), or it can be manipulated/tampered by an intermediary while" + StringInvariant.NEW_LINE
                        + "in transit over an unauthenticated connection, or from local storage where it may" + StringInvariant.NEW_LINE
                        + "have been compromised/tampered, or from many other sources. MathParser.org-mXparser" + StringInvariant.NEW_LINE
                        + "does not provide any means to authenticate data or secure it from tampering. Use an" + StringInvariant.NEW_LINE
                        + "appropriate data authentication method before deserializing. Be very mindful of these" + StringInvariant.NEW_LINE
                        + "attack scenarios; many projects and companies and users of serialization libraries in" + StringInvariant.NEW_LINE
                        + "general have been bitten by untrusted deserialization of user data in the past." + StringInvariant.NEW_LINE
                ;
        // -------------------------------------------------
        internal const String DEFAULT_BINARY_RELATION = "Binary relation";
        internal const String DEFAULT_BITWISE_OPERATOR = "Bitwise operator";
        internal const String DEFAULT_BOOLEAN_OPERATOR = "Boolean operator";
        internal const String DEFAULT_CALCULUS_OPERATOR = "Calculus operator";
        internal const String DEFAULT_CONSTANT_VALUE = "Constant value";
        internal const String DEFAULT_FUNCTION_1_ARG = "Unary function";
        internal const String DEFAULT_FUNCTION_2_ARG = "Binary function";
        internal const String DEFAULT_FUNCTION_3_ARG = "Ternary function";
        internal const String DEFAULT_FUNCTION_VARIADIC = "Variadic function";
        internal const String DEFAULT_OPERATOR = "Operator";
        internal const String DEFAULT_PARSER_SYMBOL = "Parser symbol";
        internal const String DEFAULT_RANDOM_VARIABLE = "Random variable";
        internal const String DEFAULT_UNIT = "Unit";
        internal const String DEFAULT_DIMENSIONLESS_UNIT = "Dimensionless unit";
        internal const String DEFAULT_ITERATED_OPERATOR = "Iterated operator";
        // -------------------------------------------------
        internal const String DEFAULT_RATIO_FRACTION = "Ratio / Fraction";
        internal const String DEFAULT_METRIC_PREFIX = "Metric prefix";
        internal const String DEFAULT_UNIT_OF_LENGTH = "Unit of length";
        internal const String DEFAULT_UNIT_OF_AREA = "Unit of area";
        internal const String DEFAULT_UNIT_OF_VOLUME = "Unit of volume";
        internal const String DEFAULT_UNIT_OF_TIME = "Unit of time";
        internal const String DEFAULT_UNIT_OF_MASS = "Unit of mass";
        internal const String DEFAULT_UNIT_OF_INFORMATION = "Unit of information";
        internal const String DEFAULT_UNIT_OF_ENERGY = "Unit of energy";
        internal const String DEFAULT_UNIT_OF_SPEED = "Unit of speed";
        internal const String DEFAULT_UNIT_OF_ACCELERATION = "Unit of acceleration";
        internal const String DEFAULT_UNIT_OF_ANGLE = "Unit of angle";
        // -------------------------------------------------
        internal const String DEFAULT_PHYSICAL_CONSTANT = "Physical constant";
        internal const String DEFAULT_ASTRONOMICAL_CONSTANT = "Astronomical constant";
        internal const String DEFAULT_MATHEMATICAL_CONSTANT = "Mathematical constant";
        // -------------------------------------------------
        internal const String DEFAULT_PROBABILITY_DISTRIBUTION_FUNCTION = "Probability distribution function";
        internal const String DEFAULT_CUMULATIVE_DISTRIBUTION_FUNCTION = "Cumulative distribution function";
        internal const String DEFAULT_QUANTILE_FUNCTION = "Quantile function (inverse cumulative distribution function)";
        // -------------------------------------------------
        internal const String DEFAULT_STUDENTS_T_DISTRIBUTION = "Student's t-distribution";
        internal const String DEFAULT_CHI_SQUARED_DISTRIBUTION = "Chi-squared distribution";
        internal const String DEFAULT_SNEDECORS_F_DISTRIBUTION = "Snedecor's F distribution (F-distribution or F-ratio, also known as Fisher–Snedecor distribution)";
        internal const String DEFAULT_UNIFORM_CONTINUOUS_DISTRIBUTION = "Uniform continuous distribution";
        internal const String DEFAULT_UNIFORM_DISCRETE_DISTRIBUTION = "Uniform discrete distribution";
        internal const String DEFAULT_NORMAL_DISTRIBUTION = "Normal distribution";
        // -------------------------------------------------
        internal const String DEFAULT_RANDOM_INTEGER = "Random integer";
        internal const String DEFAULT_RANDOM_NATURAL_NUMBER = "Random natural number";
        internal const String DEFAULT_RANDOM_NATURAL_NUMBER_INCLUDING_0 = "Random natural number including 0";
        // -------------------------------------------------
        internal const String DEFAULT_SPECIAL_FUNCTION = "Special function";
        // -------------------------------------------------
        internal const String DEFAULT_SEMI_MAJOR_AXIS = "Semi major axis";
        // -------------------------------------------------
        internal const String DEFAULT_BINARY_RELATION_EQ = "Equality";
        internal const String DEFAULT_BINARY_RELATION_NEQ = "Inequation";
        internal const String DEFAULT_BINARY_RELATION_LT = "Lower than";
        internal const String DEFAULT_BINARY_RELATION_GT = "Greater than";
        internal const String DEFAULT_BINARY_RELATION_LEQ = "Lower or equal";
        internal const String DEFAULT_BINARY_RELATION_GEQ = "Greater or equal";
        // -------------------------------------------------
        internal const String DEFAULT_BITWISE_OPERATOR_COMPL = "Bitwise unary complement";
        internal const String DEFAULT_BITWISE_OPERATOR_AND = "Bitwise and";
        internal const String DEFAULT_BITWISE_OPERATOR_XOR = "Bitwise exclusive or";
        internal const String DEFAULT_BITWISE_OPERATOR_OR = "Bitwise inclusive or";
        internal const String DEFAULT_BITWISE_OPERATOR_LEFT_SHIFT = "Signed left shift";
        internal const String DEFAULT_BITWISE_OPERATOR_RIGHT_SHIFT = "Signed right shift";
        // -------------------------------------------------
        internal const String DEFAULT_BOOLEAN_OPERATOR_AND = "Logical conjunction";
        internal const String DEFAULT_BOOLEAN_OPERATOR_OR = "Logical disjunction";
        internal const String DEFAULT_BOOLEAN_OPERATOR_NEG = "Negation";
        internal const String DEFAULT_BOOLEAN_OPERATOR_NAND = "Sheffer stroke";
        internal const String DEFAULT_BOOLEAN_OPERATOR_NOR = "Logical not or (joint denial)";
        internal const String DEFAULT_BOOLEAN_OPERATOR_XOR = "Exclusive or";
        internal const String DEFAULT_BOOLEAN_OPERATOR_IMP = "Implication";
        internal const String DEFAULT_BOOLEAN_OPERATOR_CIMP = "Converse implication";
        internal const String DEFAULT_BOOLEAN_OPERATOR_NIMP = "Material nonimplication";
        internal const String DEFAULT_BOOLEAN_OPERATOR_CNIMP = "Converse nonimplication";
        internal const String DEFAULT_BOOLEAN_OPERATOR_EQV = "Logical biconditional";
        // -------------------------------------------------
        internal const String DEFAULT_CALCULUS_OPERATOR_SUM = "Summation SIGMA";
        internal const String DEFAULT_CALCULUS_OPERATOR_PROD = "Product PI";
        internal const String DEFAULT_CALCULUS_OPERATOR_INT = "Definite integral";
        internal const String DEFAULT_CALCULUS_OPERATOR_DER = "Derivative";
        internal const String DEFAULT_CALCULUS_OPERATOR_DER_LEFT = "Left derivative";
        internal const String DEFAULT_CALCULUS_OPERATOR_DER_RIGHT = "Right derivative";
        internal const String DEFAULT_CALCULUS_OPERATOR_DERN = "n-th derivative";
        internal const String DEFAULT_CALCULUS_OPERATOR_FORW_DIFF = "Forward difference";
        internal const String DEFAULT_CALCULUS_OPERATOR_BACKW_DIFF = "Backward difference";
        internal const String DEFAULT_CALCULUS_OPERATOR_AVG = "Average";
        internal const String DEFAULT_CALCULUS_OPERATOR_VAR = "Bias-corrected sample variance";
        internal const String DEFAULT_CALCULUS_OPERATOR_STD = "Bias-corrected sample standard deviation";
        internal const String DEFAULT_CALCULUS_OPERATOR_MIN = "Minimum value";
        internal const String DEFAULT_CALCULUS_OPERATOR_MAX = "Maximum value";
        internal const String DEFAULT_CALCULUS_OPERATOR_SOLVE = "Equation solving (root finding)";
        // -------------------------------------------------
        internal const String DEFAULT_CONSTANT_VALUE_PI = "Pi, Archimedes' or Ludolph's number";
        internal const String DEFAULT_CONSTANT_VALUE_EULER = "Napier's or Euler's number (base of Natural logarithm)";
        internal const String DEFAULT_CONSTANT_VALUE_EULER_MASCHERONI = "Euler-Mascheroni constant";
        internal const String DEFAULT_CONSTANT_VALUE_GOLDEN_RATIO = "Golden ratio";
        internal const String DEFAULT_CONSTANT_VALUE_PLASTIC = "Plastic constant";
        internal const String DEFAULT_CONSTANT_VALUE_EMBREE_TREFETHEN = "Embree-Trefethen constant";
        internal const String DEFAULT_CONSTANT_VALUE_FEIGENBAUM_DELTA = "Feigenbaum delta constant";
        internal const String DEFAULT_CONSTANT_VALUE_FEIGENBAUM_ALPHA = "Feigenbaum alpha constant";
        internal const String DEFAULT_CONSTANT_VALUE_TWIN_PRIME = "Twin prime constant";
        internal const String DEFAULT_CONSTANT_VALUE_MEISSEL_MERTEENS = "Meissel-Mertens constant";
        internal const String DEFAULT_CONSTANT_VALUE_BRAUN_TWIN_PRIME = "Brun's constant for twin primes";
        internal const String DEFAULT_CONSTANT_VALUE_BRAUN_PRIME_QUADR = "Brun's constant for prime quadruplets";
        internal const String DEFAULT_CONSTANT_VALUE_BRUIJN_NEWMAN = "de Bruijn-Newman constant";
        internal const String DEFAULT_CONSTANT_VALUE_CATALAN = "Catalan's constant";
        internal const String DEFAULT_CONSTANT_VALUE_LANDAU_RAMANUJAN = "Landau-Ramanujan constant";
        internal const String DEFAULT_CONSTANT_VALUE_VISWANATH = "Viswanath's constant";
        internal const String DEFAULT_CONSTANT_VALUE_LEGENDRE = "Legendre's constant";
        internal const String DEFAULT_CONSTANT_VALUE_RAMANUJAN_SOLDNER = "Ramanujan-Soldner constant";
        internal const String DEFAULT_CONSTANT_VALUE_ERDOS_BORWEIN = "Erdos-Borwein constant";
        internal const String DEFAULT_CONSTANT_VALUE_BERNSTEIN = "Bernstein's constant";
        internal const String DEFAULT_CONSTANT_VALUE_GAUSS_KUZMIN_WIRSING = "Gauss-Kuzmin-Wirsing constant";
        internal const String DEFAULT_CONSTANT_VALUE_HAFNER_SARNAK_MCCURLEY = "Hafner-Sarnak-McCurley constant";
        internal const String DEFAULT_CONSTANT_VALUE_GOLOMB_DICKMAN = "Golomb-Dickman constant";
        internal const String DEFAULT_CONSTANT_VALUE_CAHEN = "Cahen's constant";
        internal const String DEFAULT_CONSTANT_VALUE_LAPLACE_LIMIT = "Laplace limit constant";
        internal const String DEFAULT_CONSTANT_VALUE_ALLADI_GRINSTEAD = "Alladi-Grinstead constant";
        internal const String DEFAULT_CONSTANT_VALUE_LENGYEL = "Lengyel's constant";
        internal const String DEFAULT_CONSTANT_VALUE_LEVY = "Levy's constant";
        internal const String DEFAULT_CONSTANT_VALUE_APERY = "Apery's constant";
        internal const String DEFAULT_CONSTANT_VALUE_MILLS = "Mills' constant";
        internal const String DEFAULT_CONSTANT_VALUE_BACKHOUSE = "Backhouse's constant";
        internal const String DEFAULT_CONSTANT_VALUE_PORTER = "Porter's constant";
        internal const String DEFAULT_CONSTANT_VALUE_LIEB_QUARE_ICE = "Lieb's square ice constant";
        internal const String DEFAULT_CONSTANT_VALUE_NIVEN = "Niven's constant";
        internal const String DEFAULT_CONSTANT_VALUE_SIERPINSKI = "Sierpinski's constant";
        internal const String DEFAULT_CONSTANT_VALUE_KHINCHIN = "Khinchin's constant";
        internal const String DEFAULT_CONSTANT_VALUE_FRANSEN_ROBINSON = "Fransen-Robinson constant";
        internal const String DEFAULT_CONSTANT_VALUE_LANDAU = "Landau's constant";
        internal const String DEFAULT_CONSTANT_VALUE_PARABOLIC = "Parabolic constant";
        internal const String DEFAULT_CONSTANT_VALUE_OMEGA = "Omega constant";
        internal const String DEFAULT_CONSTANT_VALUE_MRB = "MRB constant";
        internal const String DEFAULT_CONSTANT_VALUE_LI2 = "Logarithmic integral at point 2";
        internal const String DEFAULT_CONSTANT_VALUE_GOMPERTZ = "Gompertz constant";
        internal const String DEFAULT_CONSTANT_VALUE_LIGHT_SPEED = "Light speed in vacuum";
        internal const String DEFAULT_CONSTANT_VALUE_GRAVITATIONAL_CONSTANT = "Gravitational constant";
        internal const String DEFAULT_CONSTANT_VALUE_GRAVIT_ACC_EARTH = "Gravitational acceleration on Earth";
        internal const String DEFAULT_CONSTANT_VALUE_PLANCK_CONSTANT = "Planck constant";
        internal const String DEFAULT_CONSTANT_VALUE_PLANCK_CONSTANT_REDUCED = "Reduced Planck constant (Dirac constant)";
        internal const String DEFAULT_CONSTANT_VALUE_PLANCK_LENGTH = "Planck length";
        internal const String DEFAULT_CONSTANT_VALUE_PLANCK_MASS = "Planck mass";
        internal const String DEFAULT_CONSTANT_VALUE_PLANCK_TIME = "Planck time";
        internal const String DEFAULT_CONSTANT_VALUE_LIGHT_YEAR = "Light year";
        internal const String DEFAULT_CONSTANT_VALUE_ASTRONOMICAL_UNIT = "Astronomical unit";
        internal const String DEFAULT_CONSTANT_VALUE_PARSEC = "Parsec";
        internal const String DEFAULT_CONSTANT_VALUE_KILOPARSEC = "Kiloparsec";
        internal const String DEFAULT_CONSTANT_VALUE_EARTH_RADIUS_EQUATORIAL = "Earth equatorial radius";
        internal const String DEFAULT_CONSTANT_VALUE_EARTH_RADIUS_POLAR = "Earth polar radius";
        internal const String DEFAULT_CONSTANT_VALUE_EARTH_RADIUS_MEAN = "Earth mean radius";
        internal const String DEFAULT_CONSTANT_VALUE_EARTH_MASS = "Earth mass";
        internal const String DEFAULT_CONSTANT_VALUE_EARTH_SEMI_MAJOR_AXIS = "Earth-Sun distance";
        internal const String DEFAULT_CONSTANT_VALUE_MOON_RADIUS_MEAN = "Moon mean radius";
        internal const String DEFAULT_CONSTANT_VALUE_MOON_MASS = "Moon mass";
        internal const String DEFAULT_CONSTANT_VALUE_MONN_SEMI_MAJOR_AXIS = "Moon-Earth distance";
        internal const String DEFAULT_CONSTANT_VALUE_SOLAR_RADIUS = "Solar mean radius";
        internal const String DEFAULT_CONSTANT_VALUE_SOLAR_MASS = "Solar mass";
        internal const String DEFAULT_CONSTANT_VALUE_MERCURY_RADIUS_MEAN = "Mercury mean radius";
        internal const String DEFAULT_CONSTANT_VALUE_MERCURY_MASS = "Mercury mass";
        internal const String DEFAULT_CONSTANT_VALUE_MERCURY_SEMI_MAJOR_AXIS = "Mercury-Sun distance";
        internal const String DEFAULT_CONSTANT_VALUE_VENUS_RADIUS_MEAN = "Venus mean radius";
        internal const String DEFAULT_CONSTANT_VALUE_VENUS_MASS = "Venus mass";
        internal const String DEFAULT_CONSTANT_VALUE_VENUS_SEMI_MAJOR_AXIS = "Venus-Sun distance";
        internal const String DEFAULT_CONSTANT_VALUE_MARS_RADIUS_MEAN = "Mars mean radius";
        internal const String DEFAULT_CONSTANT_VALUE_MARS_MASS = "Mars mass";
        internal const String DEFAULT_CONSTANT_VALUE_MARS_SEMI_MAJOR_AXIS = "Mars-Sun distance";
        internal const String DEFAULT_CONSTANT_VALUE_JUPITER_RADIUS_MEAN = "Jupiter mean radius";
        internal const String DEFAULT_CONSTANT_VALUE_JUPITER_MASS = "Jupiter mass";
        internal const String DEFAULT_CONSTANT_VALUE_JUPITER_SEMI_MAJOR_AXIS = "Jupiter-Sun distance";
        internal const String DEFAULT_CONSTANT_VALUE_SATURN_RADIUS_MEAN = "Saturn mean radius";
        internal const String DEFAULT_CONSTANT_VALUE_SATURN_MASS = "Saturn mass";
        internal const String DEFAULT_CONSTANT_VALUE_SATURN_SEMI_MAJOR_AXIS = "Saturn-Sun distance";
        internal const String DEFAULT_CONSTANT_VALUE_URANUS_RADIUS_MEAN = "Uranus mean radius";
        internal const String DEFAULT_CONSTANT_VALUE_URANUS_MASS = "Uranus mass";
        internal const String DEFAULT_CONSTANT_VALUE_URANUS_SEMI_MAJOR_AXIS = "Uranus-Sun distance";
        internal const String DEFAULT_CONSTANT_VALUE_NEPTUNE_RADIUS_MEAN = "Neptune mean radius";
        internal const String DEFAULT_CONSTANT_VALUE_NEPTUNE_MASS = "Neptune mass";
        internal const String DEFAULT_CONSTANT_VALUE_NEPTUNE_SEMI_MAJOR_AXIS = "Neptune-Sun distance";
        internal const String DEFAULT_CONSTANT_VALUE_TRUE = "Boolean True represented as 1";
        internal const String DEFAULT_CONSTANT_VALUE_FALSE = "Boolean False represented as 0";
        internal const String DEFAULT_CONSTANT_VALUE_NPAR = "Automatically generated constant for user defined functions, returns number of given function parameters";
        internal const String DEFAULT_CONSTANT_VALUE_NAN = "Not-a-Number";
        // -------------------------------------------------
        internal const String DEFAULT_FUNCTION_1_ARG_SIN = "Trigonometric sine";
        internal const String DEFAULT_FUNCTION_1_ARG_COS = "Trigonometric cosine";
        internal const String DEFAULT_FUNCTION_1_ARG_TAN = "Trigonometric tangent";
        internal const String DEFAULT_FUNCTION_1_ARG_CTAN = "Trigonometric cotangent";
        internal const String DEFAULT_FUNCTION_1_ARG_SEC = "Trigonometric secant";
        internal const String DEFAULT_FUNCTION_1_ARG_COSEC = "Trigonometric cosecant";
        internal const String DEFAULT_FUNCTION_1_ARG_ASIN = "Inverse trigonometric sine";
        internal const String DEFAULT_FUNCTION_1_ARG_ACOS = "Inverse trigonometric cosine";
        internal const String DEFAULT_FUNCTION_1_ARG_ATAN = "Inverse trigonometric tangent";
        internal const String DEFAULT_FUNCTION_1_ARG_ACTAN = "Inverse trigonometric cotangent";
        internal const String DEFAULT_FUNCTION_1_ARG_LN = "Natural logarithm (base e)";
        internal const String DEFAULT_FUNCTION_1_ARG_LOG2 = "Binary logarithm (base 2)";
        internal const String DEFAULT_FUNCTION_1_ARG_LOG10 = "Common logarithm (base 10)";
        internal const String DEFAULT_FUNCTION_1_ARG_RAD = "Degrees to radians";
        internal const String DEFAULT_FUNCTION_1_ARG_EXP = "Exponential";
        internal const String DEFAULT_FUNCTION_1_ARG_SQRT = "Squre root";
        internal const String DEFAULT_FUNCTION_1_ARG_SINH = "Hyperbolic sine";
        internal const String DEFAULT_FUNCTION_1_ARG_COSH = "Hyperbolic cosine";
        internal const String DEFAULT_FUNCTION_1_ARG_TANH = "Hyperbolic tangent";
        internal const String DEFAULT_FUNCTION_1_ARG_COTH = "Hyperbolic cotangent";
        internal const String DEFAULT_FUNCTION_1_ARG_SECH = "Hyperbolic secant";
        internal const String DEFAULT_FUNCTION_1_ARG_CSCH = "Hyperbolic cosecant";
        internal const String DEFAULT_FUNCTION_1_ARG_DEG = "Radians to degrees";
        internal const String DEFAULT_FUNCTION_1_ARG_ABS = "Absolut value";
        internal const String DEFAULT_FUNCTION_1_ARG_SGN = "Signum";
        internal const String DEFAULT_FUNCTION_1_ARG_FLOOR = "Floor";
        internal const String DEFAULT_FUNCTION_1_ARG_CEIL = "Ceiling";
        internal const String DEFAULT_FUNCTION_1_ARG_NOT = "Negation";
        internal const String DEFAULT_FUNCTION_1_ARG_ARSINH = "Inverse hyperbolic sine";
        internal const String DEFAULT_FUNCTION_1_ARG_ARCOSH = "Inverse hyperbolic cosine";
        internal const String DEFAULT_FUNCTION_1_ARG_ARTANH = "Inverse hyperbolic tangent";
        internal const String DEFAULT_FUNCTION_1_ARG_ARCOTH = "Inverse hyperbolic cotangent";
        internal const String DEFAULT_FUNCTION_1_ARG_ARSECH = "Inverse hyperbolic secant";
        internal const String DEFAULT_FUNCTION_1_ARG_ARCSCH = "Inverse hyperbolic cosecant";
        internal const String DEFAULT_FUNCTION_1_ARG_SA = "Sinc (normalized)";
        internal const String DEFAULT_FUNCTION_1_ARG_SINC = "Sinc (unnormalized)";
        internal const String DEFAULT_FUNCTION_1_ARG_BELL_NUMBER = "Bell number";
        internal const String DEFAULT_FUNCTION_1_ARG_LUCAS_NUMBER = "Lucas number";
        internal const String DEFAULT_FUNCTION_1_ARG_FIBONACCI_NUMBER = "Fibonacci number";
        internal const String DEFAULT_FUNCTION_1_ARG_HARMONIC_NUMBER = "Harmonic number";
        internal const String DEFAULT_FUNCTION_1_ARG_IS_PRIME = "Prime number test (is number a prime?)";
        internal const String DEFAULT_FUNCTION_1_ARG_PRIME_COUNT = "Prime-counting";
        internal const String DEFAULT_FUNCTION_1_ARG_EXP_INT = "Exponential integral";
        internal const String DEFAULT_FUNCTION_1_ARG_LOG_INT = "Logarithmic integral";
        internal const String DEFAULT_FUNCTION_1_ARG_OFF_LOG_INT = "Offset logarithmic integral";
        internal const String DEFAULT_FUNCTION_1_ARG_GAUSS_ERF = "Gauss error";
        internal const String DEFAULT_FUNCTION_1_ARG_GAUSS_ERFC = "Gauss complementary error";
        internal const String DEFAULT_FUNCTION_1_ARG_GAUSS_ERF_INV = "Inverse Gauss error";
        internal const String DEFAULT_FUNCTION_1_ARG_GAUSS_ERFC_INV = "Inverse Gauss complementary error";
        internal const String DEFAULT_FUNCTION_1_ARG_ULP = "Unit in The Last Place";
        internal const String DEFAULT_FUNCTION_1_ARG_ISNAN = "Returns true if value is a Not-a-Number (NaN), false otherwise";
        internal const String DEFAULT_FUNCTION_1_ARG_NDIG10 = "Number of digits in numeral system with base 10";
        internal const String DEFAULT_FUNCTION_1_ARG_NFACT = "Prime decomposition - number of distinct prime factors";
        internal const String DEFAULT_FUNCTION_1_ARG_ARCSEC = "Inverse trigonometric secant";
        internal const String DEFAULT_FUNCTION_1_ARG_ARCCSC = "Inverse trigonometric cosecant";
        internal const String DEFAULT_FUNCTION_1_ARG_GAMMA = "Gamma";
        internal const String DEFAULT_FUNCTION_1_ARG_LAMBERT_W0 = "Lambert-W, principal branch 0, also called the omega or product logarithm";
        internal const String DEFAULT_FUNCTION_1_ARG_LAMBERT_W1 = "Lambert-W, branch -1, also called the omega or product logarithm";
        internal const String DEFAULT_FUNCTION_1_ARG_SGN_GAMMA = "Signum of Gamma";
        internal const String DEFAULT_FUNCTION_1_ARG_LOG_GAMMA = "Log Gamma";
        internal const String DEFAULT_FUNCTION_1_ARG_DI_GAMMA = "Digamma as the logarithmic derivative of the Gamma";
        internal const String DEFAULT_FUNCTION_1_ARG_PARAM = "Automatically generated function for user defined functions, returns function parameter value at index 'i'";
        // -------------------------------------------------
        internal const String DEFAULT_FUNCTION_2_ARG_LOG = "Logarithm";
        internal const String DEFAULT_FUNCTION_2_ARG_MOD = "Modulo";
        internal const String DEFAULT_FUNCTION_2_ARG_BINOM_COEFF = "Binomial coefficient, number of k-combinations that can be drawn from n-elements set";
        internal const String DEFAULT_FUNCTION_2_ARG_BERNOULLI_NUMBER = "Bernoulli numbers";
        internal const String DEFAULT_FUNCTION_2_ARG_STIRLING1_NUMBER = "Stirling numbers of the first kind";
        internal const String DEFAULT_FUNCTION_2_ARG_STIRLING2_NUMBER = "Stirling numbers of the second kind";
        internal const String DEFAULT_FUNCTION_2_ARG_WORPITZKY_NUMBER = "Worpitzky number";
        internal const String DEFAULT_FUNCTION_2_ARG_EULER_NUMBER = "Euler number";
        internal const String DEFAULT_FUNCTION_2_ARG_KRONECKER_DELTA = "Kronecker delta";
        internal const String DEFAULT_FUNCTION_2_ARG_EULER_POLYNOMIAL = "EulerPol";
        internal const String DEFAULT_FUNCTION_2_ARG_HARMONIC_NUMBER = "Harmonic number";
        internal const String DEFAULT_FUNCTION_2_ARG_ROUND = "Half-up rounding";
        internal const String DEFAULT_FUNCTION_2_ARG_NDIG = "Number of digits representing the number in numeral system with given base";
        internal const String DEFAULT_FUNCTION_2_ARG_DIGIT10 = "Digit at position 1 ... n (left -> right) or 0 ... -(n-1) (right -> left) - base 10 numeral system";
        internal const String DEFAULT_FUNCTION_2_ARG_FACTVAL = "Prime decomposition - factor value at position between 1 ... nfact(n) - ascending order by factor value";
        internal const String DEFAULT_FUNCTION_2_ARG_FACTEXP = "Prime decomposition - factor exponent / multiplicity at position between 1 ... nfact(n) - ascending order by factor value";
        internal const String DEFAULT_FUNCTION_2_ARG_ROOT = "N-th order root of a number";
        internal const String DEFAULT_FUNCTION_2_ARG_INC_GAMMA_LOWER = "Lower incomplete gamma";
        internal const String DEFAULT_FUNCTION_2_ARG_INC_GAMMA_UPPER = "Upper incomplete Gamma";
        internal const String DEFAULT_FUNCTION_2_ARG_REG_GAMMA_LOWER = "Lower regularized P gamma";
        internal const String DEFAULT_FUNCTION_2_ARG_REG_GAMMA_UPPER = "Upper regularized Q Gamma";
        internal const String DEFAULT_FUNCTION_2_ARG_PERMUTATIONS = "Number of k-permutations that can be drawn from n-elements set";
        internal const String DEFAULT_FUNCTION_2_ARG_BETA = "The Beta, also called the Euler integral of the first kind";
        internal const String DEFAULT_FUNCTION_2_ARG_LOG_BETA = "The Log Beta, also called the Log Euler integral of the first kind";
        // -------------------------------------------------
        internal const String DEFAULT_FUNCTION_3_ARG_IF = "If";
        internal const String DEFAULT_FUNCTION_3_ARG_CHI = "Characteristic function for x in (a,b)";
        internal const String DEFAULT_FUNCTION_3_ARG_CHI_LR = "Characteristic function for x in [a,b]";
        internal const String DEFAULT_FUNCTION_3_ARG_CHI_L = "Characteristic function for x in [a,b)";
        internal const String DEFAULT_FUNCTION_3_ARG_CHI_R = "Characteristic function for x in (a,b]";
        internal const String DEFAULT_FUNCTION_3_ARG_DIGIT = "Digit at position 1 ... n (left -> right) or 0 ... -(n-1) (right -> left) - numeral system with given base";
        internal const String DEFAULT_FUNCTION_3_ARG_INC_BETA = "The incomplete Beta, also called the incomplete Euler integral of the first kind";
        internal const String DEFAULT_FUNCTION_3_ARG_REG_BETA = "The regularized incomplete Beta (or regularized beta), also called the regularized incomplete Euler integral of the first kind";
        // -------------------------------------------------
        internal const String DEFAULT_FUNCTION_VARIADIC_IFF = "If function";
        internal const String DEFAULT_FUNCTION_VARIADIC_MIN = "Minimum";
        internal const String DEFAULT_FUNCTION_VARIADIC_MAX = "Maximum";
        internal const String DEFAULT_FUNCTION_VARIADIC_CONT_FRAC = "Continued fraction";
        internal const String DEFAULT_FUNCTION_VARIADIC_CONT_POL = "Continued polynomial";
        internal const String DEFAULT_FUNCTION_VARIADIC_GCD = "Greatest common divisor";
        internal const String DEFAULT_FUNCTION_VARIADIC_LCM = "Least common multiple";
        internal const String DEFAULT_FUNCTION_VARIADIC_SUM = "Summation";
        internal const String DEFAULT_FUNCTION_VARIADIC_PROD = "Multiplication";
        internal const String DEFAULT_FUNCTION_VARIADIC_AVG = "Mean / average value";
        internal const String DEFAULT_FUNCTION_VARIADIC_VAR = "Bias-corrected sample variance";
        internal const String DEFAULT_FUNCTION_VARIADIC_STD = "Bias-corrected sample standard deviation";
        internal const String DEFAULT_FUNCTION_VARIADIC_RND_LIST = "Random number from a given list of numbers";
        internal const String DEFAULT_FUNCTION_VARIADIC_COALESCE = "Returns the first non-NaN value";
        internal const String DEFAULT_FUNCTION_VARIADIC_OR = "Logical disjunction (OR) - variadic";
        internal const String DEFAULT_FUNCTION_VARIADIC_AND = "Logical conjunction (AND) - variadic";
        internal const String DEFAULT_FUNCTION_VARIADIC_XOR = "Exclusive or (XOR) - variadic";
        internal const String DEFAULT_FUNCTION_VARIADIC_ARGMIN = "Arguments / indices of the minima";
        internal const String DEFAULT_FUNCTION_VARIADIC_ARGMAX = "Arguments / indices of the maxima";
        internal const String DEFAULT_FUNCTION_VARIADIC_MEDIAN = "The sample median";
        internal const String DEFAULT_FUNCTION_VARIADIC_MODE = "Mode - the value that appears most often";
        internal const String DEFAULT_FUNCTION_VARIADIC_BASE = "Returns number in given numeral system base represented by list of digits";
        internal const String DEFAULT_FUNCTION_VARIADIC_NDIST = "Number of distinct values";
        // -------------------------------------------------
        internal const String DEFAULT_OPERATOR_PLUS = "Addition";
        internal const String DEFAULT_OPERATOR_MINUS = "Subtraction";
        internal const String DEFAULT_OPERATOR_MULTIPLY = "Multiplication";
        internal const String DEFAULT_OPERATOR_DIVIDE = "Division";
        internal const String DEFAULT_OPERATOR_POWER = "Exponentiation";
        internal const String DEFAULT_OPERATOR_FACT = "Factorial";
        internal const String DEFAULT_OPERATOR_MOD = "Modulo";
        internal const String DEFAULT_OPERATOR_PERC = "Percentage";
        internal const String DEFAULT_OPERATOR_TETRATION = "Tetration (hyper-4, power tower, exponential tower)";
        internal const String DEFAULT_OPERATOR_SQUARE_ROOT = "Square root";
        internal const String DEFAULT_OPERATOR_CUBE_ROOT = "Cube root";
        internal const String DEFAULT_OPERATOR_FOURTH_ROOT = "Fourth root";
        // -------------------------------------------------
        internal const String DEFAULT_PARSER_SYMBOL_LEFT_PARENTHESES = "Left parentheses";
        internal const String DEFAULT_PARSER_SYMBOL_RIGHT_PARENTHESES = "Right parentheses";
        internal const String DEFAULT_PARSER_SYMBOL_COMMA = "Comma (function parameters)";
        internal const String DEFAULT_PARSER_SYMBOL_SEMI = "Semicolon (function parameters)";
        internal const String DEFAULT_PARSER_SYMBOL_BLANK = "Blank (whitespace) character";
        internal const String DEFAULT_PARSER_SYMBOL_NUMBER_INTEGER = "Integer";
        internal const String DEFAULT_PARSER_SYMBOL_NUMBER_DECIMAL = "Decimal";
        internal const String DEFAULT_PARSER_SYMBOL_NUMBER_LEADING_ZERO = "Leading zero";
        internal const String DEFAULT_PARSER_SYMBOL_NUMBER_SCI_NOTATION = "Scientific notation";
        internal const String DEFAULT_PARSER_SYMBOL_NUMBER_NO_LEADING_ZERO = "No leading zero";
        internal const String DEFAULT_PARSER_SYMBOL_NUMBER_FRACTIONS = "Fractions";
        internal const String DEFAULT_PARSER_SYMBOL_NUMBER_OTHER_NUMERAL_SYSTEMS = "Other numeral systems";
        internal const String DEFAULT_PARSER_SYMBOL_UNICODE_MATH = " - Unicode math symbol";
        // -------------------------------------------------
        internal const String DEFAULT_DIMENSIONLESS_UNIT_PERC = "Percentage";
        internal const String DEFAULT_DIMENSIONLESS_UNIT_PROMIL = "Promil, Per mille";
        internal const String DEFAULT_DIMENSIONLESS_UNIT_YOTTA = "Septillion / Yotta";
        internal const String DEFAULT_DIMENSIONLESS_UNIT_ZETTA = "Sextillion / Zetta";
        internal const String DEFAULT_DIMENSIONLESS_UNIT_EXA = "Quintillion / Exa";
        internal const String DEFAULT_DIMENSIONLESS_UNIT_PETA = "Quadrillion / Peta";
        internal const String DEFAULT_DIMENSIONLESS_UNIT_TERA = "Trillion / Tera";
        internal const String DEFAULT_DIMENSIONLESS_UNIT_GIGA = "Billion / Giga";
        internal const String DEFAULT_DIMENSIONLESS_UNIT_MEGA = "Million / Mega";
        internal const String DEFAULT_DIMENSIONLESS_UNIT_KILO = "Thousand / Kilo";
        internal const String DEFAULT_DIMENSIONLESS_UNIT_HECTO = "Hundred / Hecto";
        internal const String DEFAULT_DIMENSIONLESS_UNIT_DECA = "Ten / Deca";
        internal const String DEFAULT_DIMENSIONLESS_UNIT_DECI = "Tenth / Deci";
        internal const String DEFAULT_DIMENSIONLESS_UNIT_CENTI = "Hundredth / Centi";
        internal const String DEFAULT_DIMENSIONLESS_UNIT_MILLI = "Thousandth / Milli";
        internal const String DEFAULT_DIMENSIONLESS_UNIT_MICRO = "Millionth / Micro";
        internal const String DEFAULT_DIMENSIONLESS_UNIT_NANO = "Billionth / Nano";
        internal const String DEFAULT_DIMENSIONLESS_UNIT_PICO = "Trillionth / Pico";
        internal const String DEFAULT_DIMENSIONLESS_UNIT_FEMTO = "Quadrillionth / Femto";
        internal const String DEFAULT_DIMENSIONLESS_UNIT_ATTO = "Quintillionth / Atoo";
        internal const String DEFAULT_DIMENSIONLESS_UNIT_ZEPTO = "Sextillionth / Zepto";
        internal const String DEFAULT_DIMENSIONLESS_UNIT_YOCTO = "Septillionth / Yocto";
        // -------------------------------------------------
        internal const String DEFAULT_UNIT_METRE = "Meter";
        internal const String DEFAULT_UNIT_KILOMETRE = "Kilometer";
        internal const String DEFAULT_UNIT_CENTIMETRE = "Centimeter";
        internal const String DEFAULT_UNIT_MILLIMETRE = "Millimeter";
        internal const String DEFAULT_UNIT_INCH = "Inch";
        internal const String DEFAULT_UNIT_YARD = "Yard";
        internal const String DEFAULT_UNIT_FEET = "Feet";
        internal const String DEFAULT_UNIT_MILE = "Mile";
        internal const String DEFAULT_UNIT_NAUTICAL_MILE = "Nautical mile";
        internal const String DEFAULT_UNIT_METRE2 = "Square meter";
        internal const String DEFAULT_UNIT_CENTIMETRE2 = "Square centimeter";
        internal const String DEFAULT_UNIT_MILLIMETRE2 = "Square millimeter";
        internal const String DEFAULT_UNIT_ARE = "Are";
        internal const String DEFAULT_UNIT_HECTARE = "Hectare";
        internal const String DEFAULT_UNIT_ACRE = "Acre";
        internal const String DEFAULT_UNIT_KILOMETRE2 = "Square kilometer";
        internal const String DEFAULT_UNIT_MILLIMETRE3 = "Cubic millimeter";
        internal const String DEFAULT_UNIT_CENTIMETRE3 = "Cubic centimeter";
        internal const String DEFAULT_UNIT_METRE3 = "Cubic meter";
        internal const String DEFAULT_UNIT_KILOMETRE3 = "Cubic kilometer";
        internal const String DEFAULT_UNIT_MILLILITRE = "Milliliter";
        internal const String DEFAULT_UNIT_LITRE = "Liter";
        internal const String DEFAULT_UNIT_GALLON = "Gallon";
        internal const String DEFAULT_UNIT_PINT = "Pint";
        internal const String DEFAULT_UNIT_SECOND = "Second";
        internal const String DEFAULT_UNIT_MILLISECOND = "Millisecond";
        internal const String DEFAULT_UNIT_MINUTE = "Minute";
        internal const String DEFAULT_UNIT_HOUR = "Hour";
        internal const String DEFAULT_UNIT_DAY = "Day";
        internal const String DEFAULT_UNIT_WEEK = "Week";
        internal const String DEFAULT_UNIT_JULIAN_YEAR = "Julian year = 365.25 days";
        internal const String DEFAULT_UNIT_KILOGRAM = "Kilogram";
        internal const String DEFAULT_UNIT_GRAM = "Gram";
        internal const String DEFAULT_UNIT_MILLIGRAM = "Milligram";
        internal const String DEFAULT_UNIT_DECAGRAM = "Decagram";
        internal const String DEFAULT_UNIT_TONNE = "Tonne";
        internal const String DEFAULT_UNIT_OUNCE = "Ounce";
        internal const String DEFAULT_UNIT_POUND = "Pound";
        internal const String DEFAULT_UNIT_BIT = "Bit";
        internal const String DEFAULT_UNIT_KILOBIT = "Kilobit";
        internal const String DEFAULT_UNIT_MEGABIT = "Megabit";
        internal const String DEFAULT_UNIT_GIGABIT = "Gigabit";
        internal const String DEFAULT_UNIT_TERABIT = "Terabit";
        internal const String DEFAULT_UNIT_PETABIT = "Petabit";
        internal const String DEFAULT_UNIT_EXABIT = "Exabit";
        internal const String DEFAULT_UNIT_ZETTABIT = "Zettabit";
        internal const String DEFAULT_UNIT_YOTTABIT = "Yottabit";
        internal const String DEFAULT_UNIT_BYTE = "Byte";
        internal const String DEFAULT_UNIT_KILOBYTE = "Kilobyte";
        internal const String DEFAULT_UNIT_MEGABYTE = "Megabyte";
        internal const String DEFAULT_UNIT_GIGABYTE = "Gigabyte";
        internal const String DEFAULT_UNIT_TERABYTE = "Terabyte";
        internal const String DEFAULT_UNIT_PETABYTE = "Petabyte";
        internal const String DEFAULT_UNIT_EXABYTE = "Exabyte";
        internal const String DEFAULT_UNIT_ZETTABYTE = "Zettabyte";
        internal const String DEFAULT_UNIT_YOTTABYTE = "Yottabyte";
        internal const String DEFAULT_UNIT_JOULE = "Joule";
        internal const String DEFAULT_UNIT_ELECTRONO_VOLT = "Electronovolt";
        internal const String DEFAULT_UNIT_KILO_ELECTRONO_VOLT = "Kiloelectronovolt";
        internal const String DEFAULT_UNIT_MEGA_ELECTRONO_VOLT = "Megaelectronovolt";
        internal const String DEFAULT_UNIT_GIGA_ELECTRONO_VOLT = "Gigaelectronovolt";
        internal const String DEFAULT_UNIT_TERA_ELECTRONO_VOLT = "Teraelectronovolt";
        internal const String DEFAULT_UNIT_METRE_PER_SECOND = "Meter per second";
        internal const String DEFAULT_UNIT_KILOMETRE_PER_HOUR = "Kilometer per hour";
        internal const String DEFAULT_UNIT_MILE_PER_HOUR = "Mile per hour";
        internal const String DEFAULT_UNIT_KNOT = "Knot";
        internal const String DEFAULT_UNIT_METRE_PER_SECOND2 = "Meter per square second";
        internal const String DEFAULT_UNIT_KILOMETRE_PER_HOUR2 = "Kilometer per square hour";
        internal const String DEFAULT_UNIT_MILE_PER_HOUR2 = "Mile per square hour";
        internal const String DEFAULT_UNIT_RADIAN_ARC = "Radian";
        internal const String DEFAULT_UNIT_DEGREE_ARC = "Degree of arc";
        internal const String DEFAULT_UNIT_MINUTE_ARC = "Minute of arc";
        internal const String DEFAULT_UNIT_SECOND_ARC = "Second of arc";

        /**
         * Default String = "English"
         */
        public String USER_LANGUAGE = DEFAULT_USER_LANGUAGE;
        // -------------------------------------------------
        /**
         * Default String = "Starting syntax check..."
         */
        public String STARTING_SYNTAX_CHECK = DEFAULT_STARTING_SYNTAX_CHECK;
        /**
         * Default String = "No errors detected."
         */
        public String NO_ERRORS_DETECTED = DEFAULT_NO_ERRORS_DETECTED;
        /**
         * Default String = "A lexical error has been found."
         */
        public String LEXICAL_ERROR_HAS_BEEN_FOUND = DEFAULT_LEXICAL_ERROR_HAS_BEEN_FOUND;
        /**
         * Default String = "Errors have been found."
         */
        public String ERRORS_HAVE_BEEN_FOUND = DEFAULT_ERRORS_HAVE_BEEN_FOUND;
        /**
         * Default String = "The syntax has already been checked - no errors detected."
         */
        public String ALREADY_CHECKED_NO_ERRORS = DEFAULT_ALREADY_CHECKED_NO_ERRORS;
        /**
         * Default String = "The syntax status is unknown."
         */
        public String SYNTAX_STATUS_UNKNOWN = DEFAULT_SYNTAX_STATUS_UNKNOWN;
        /**
         * Default String = "There is a problem with expression syntax."
         */
        public String PROBLEM_WITH_EXPRESSION_SYNTAX = DEFAULT_PROBLEM_WITH_EXPRESSION_SYNTAX;
        // -------------------------------------------------
        /**
         * Default String = "at index"
         */
        public String AT_INDEX = DEFAULT_AT_INDEX;
        /**
         * Default String = "Encountered"
         */
        public String ENCOUNTERED = DEFAULT_ENCOUNTERED;
        /**
         * Default String = "Was expecting"
         */
        public String WAS_EXPECTING = DEFAULT_WAS_EXPECTING;
        /**
         * Default String = "Was expecting one of"
         */
        public String WAS_EXPECTING_ONE_OF = DEFAULT_WAS_EXPECTING_ONE_OF;
        /**
         * Default String = "An unexpected exception was encountered. Probably a parser error - please report it."
         */
        public String UNEXPECTED_EXCEPTION_WAS_ENCOUNTERED = DEFAULT_UNEXPECTED_EXCEPTION_WAS_ENCOUNTERED;
        /**
         * Default String = "An unexpected token manager error was encountered. Probably a parser error - please report it."
         */
        public String UNEXPECTED_TOKEN_MANAGER_ERROR_WAS_ENCOUNTERED = DEFAULT_UNEXPECTED_TOKEN_MANAGER_ERROR_WAS_ENCOUNTERED;
        // -------------------------------------------------
        /**
         * Default String = "The expression string is empty."
         */
        public String EXPRESSION_STRING_IS_EMPTY = DEFAULT_EXPRESSION_STRING_IS_EMPTY;
        /**
         * Default String = "The expression does not contain any tokens."
         */
        public String EXPRESSION_DOES_NOT_CONTAIN_ANY_TOKENS = DEFAULT_EXPRESSION_DOES_NOT_CONTAIN_ANY_TOKENS;
        /**
         * Default String = "Duplicated keywords were found. Check user-defined items. Consider using option to override built-in tokens."
         */
        public String DUPLICATED_KEYWORD = DEFAULT_DUPLICATED_KEYWORD;
        /**
         * Default String = "Element"
         */
        public String ELEMENT = DEFAULT_ELEMENT;
        /**
         * Default String = "Error"
         */
        public String ERROR = DEFAULT_ERROR;
        /**
         * Default String = "Exception"
         */
        public String EXCEPTION = DEFAULT_EXCEPTION;
        /**
         * Default String = "Token"
         */
        public String TOKEN = DEFAULT_TOKEN;
        /**
         * Default String = "index"
         */
        public String INDEX = DEFAULT_INDEX;
        /**
         * Default String = "Invalid token."
         */
        public String INVALID_TOKEN = DEFAULT_INVALID_TOKEN;
        /**
         * Default String = "Invalid token. Possibly missing multiplication operator - try implied multiplication mode."
         */
        public String INVALID_TOKEN_POSSIBLY_MISSING_MULTIPLICATION_OPERATOR = DEFAULT_INVALID_TOKEN_POSSIBLY_MISSING_MULTIPLICATION_OPERATOR;
        /**
         * Default String = "Expression tokens"
         */
        public String EXPRESSION_TOKENS = DEFAULT_EXPRESSION_TOKENS;
        /**
         * Default String = "NULL tokens list"
         */
        public String NULL_TOKENS_LIST = DEFAULT_NULL_TOKENS_LIST;
        // -------------------------------------------------
        /**
         * Default String = "User-defined function with extended body - no errors by assumption."
         */
        public String FUNCTION_WITH_EXTENDED_BODY_NO_ERRORS = DEFAULT_FUNCTION_WITH_EXTENDED_BODY_NO_ERRORS;
        /**
         * Default String = "User-defined argument with extended body - no errors by assumption."
         */
        public String ARGUMENT_WITH_EXTENDED_BODY_NO_ERRORS = DEFAULT_ARGUMENT_WITH_EXTENDED_BODY_NO_ERRORS;
        /**
         * Default String = "Possibly missing multiplication operator - try implied multiplication mode."
         */
        public String MULTIPLICATION_OPERATOR_MISSING_TRY_IMPLIED_MULTIPLICATION_MODE = DEFAULT_MULTIPLICATION_OPERATOR_MISSING_TRY_IMPLIED_MULTIPLICATION_MODE;
        // -------------------------------------------------
        /**
         * Default String = "Starting syntax check of the dependent user-defined argument."
         */
        public String STARTING_SYNTAX_CHECK_DEPENDENT_ARGUMENT = DEFAULT_STARTING_SYNTAX_CHECK_DEPENDENT_ARGUMENT;
        /**
         * Default String = "Starting syntax check of the user-defined recursive argument."
         */
        public String STARTING_SYNTAX_CHECK_RECURSIVE_ARGUMENT = DEFAULT_STARTING_SYNTAX_CHECK_RECURSIVE_ARGUMENT;
        /**
         * Default String = "Starting syntax check of the user-defined function."
         */
        public String STARTING_SYNTAX_CHECK_USER_DEFINED_FUNCTION = DEFAULT_STARTING_SYNTAX_CHECK_USER_DEFINED_FUNCTION;
        /**
         * Default String = "Starting syntax check of the variadic user-defined function."
         */
        public String STARTING_SYNTAX_CHECK_VARIADIC_USER_DEFINED_FUNCTION = DEFAULT_STARTING_SYNTAX_CHECK_VARIADIC_USER_DEFINED_FUNCTION;
        // -------------------------------------------------
        /**
         * Default String = "User-defined argument was expected."
         */
        public String ARGUMENT_WAS_EXPECTED = DEFAULT_ARGUMENT_WAS_EXPECTED;
        /**
         * Default String = "A recursive user-defined argument requires one parameter."
         */
        public String RECURSIVE_ARGUMENT_EXPECTING_1_PARAMETER = DEFAULT_RECURSIVE_ARGUMENT_EXPECTING_1_PARAMETER;
        // -------------------------------------------------
        /**
         * Default String = "Incorrect number of parameters in user-defined function."
         */
        public String INCORRECT_NUMBER_OF_PARAMETERS_IN_USER_DEFINED_FUNCTION = DEFAULT_INCORRECT_NUMBER_OF_PARAMETERS_IN_USER_DEFINED_FUNCTION;
        // -------------------------------------------------
        /**
         * Default String = "Incorrect number of function parameters."
         */
        public String INCORRECT_NUMBER_OF_FUNCTION_PARAMETERS = DEFAULT_INCORRECT_NUMBER_OF_FUNCTION_PARAMETERS;
        /**
         * Default String = "Expected"
         */
        public String EXPECTED = DEFAULT_EXPECTED;
        /**
         * Default String = "provided"
         */
        public String PROVIDED = DEFAULT_PROVIDED;
        /**
         * Default String = "Incorrect number of parameters in user-defined function - at least one argument is expected."
         */
        public String USER_DEFINED_FUNCTION_EXPECTING_AT_LEAST_ONE_ARGUMENT = DEFAULT_USER_DEFINED_FUNCTION_EXPECTING_AT_LEAST_ONE_ARGUMENT;
        /**
         * Default String = "Even number of arguments was expected."
         */
        public String EXPECTED_EVEN_NUMBER_OF_ARGUMENTS = DEFAULT_EXPECTED_EVEN_NUMBER_OF_ARGUMENTS;
        // -------------------------------------------------
        /**
         * Default String = "Invalid function name."
         */
        public String INVALID_FUNCTION_NAME = DEFAULT_INVALID_FUNCTION_NAME;
        /**
         * Default String = "Invalid argument name."
         */
        public String INVALID_ARGUMENT_NAME = DEFAULT_INVALID_ARGUMENT_NAME;
        /**
         * Default String = "Invalid constant name."
         */
        public String INVALID_CONSTANT_NAME = DEFAULT_INVALID_CONSTANT_NAME;
        /**
         * Default String = "Invalid function definition."
         */
        public String INVALID_FUNCTION_DEFINITION = DEFAULT_INVALID_FUNCTION_DEFINITION;
        /**
         * Default String = "Invalid argument definition."
         */
        public String INVALID_ARGUMENT_DEFINITION = DEFAULT_INVALID_ARGUMENT_DEFINITION;
        /**
         * Default String = "Invalid constant definition."
         */
        public String INVALID_CONSTANT_DEFINITION = DEFAULT_INVALID_CONSTANT_DEFINITION;
        /**
         * Default String = "Pattern does not match."
         */
        public String PATTERN_DOES_NOT_MATCH = DEFAULT_PATTERN_DOES_NOT_MATCH;
        /**
         * Default String = "Pattern examples"
         */
        public String PATTERN_EXAMPLES = DEFAULT_PATTERN_EXAMPLES;
        // -------------------------------------------------
        /**
         * Default String = "Constant value was expected."
         */
        public String CONSTANT_WAS_EXPECTED = DEFAULT_CONSTANT_WAS_EXPECTED;
        /**
         * Default String = "User-defined constant was expected."
         */
        public String USER_CONSTANT_WAS_EXPECTED = DEFAULT_USER_CONSTANT_WAS_EXPECTED;
        // -------------------------------------------------
        /**
         * Default String = "A unary function expects 1 parameter."
         */
        public String UNARY_FUNCTION_EXPECTS_1_PARAMETER = DEFAULT_UNARY_FUNCTION_EXPECTS_1_PARAMETER;
        /**
         * Default String = "A binary function expects 2 parameters."
         */
        public String BINARY_FUNCTION_EXPECTS_2_PARAMETERS = DEFAULT_BINARY_FUNCTION_EXPECTS_2_PARAMETERS;
        /**
         * Default String = "A ternary function expects 3 parameters."
         */
        public String TERNARY_FUNCTION_EXPECTS_3_PARAMETERS = DEFAULT_TERNARY_FUNCTION_EXPECTS_3_PARAMETERS;
        // -------------------------------------------------
        /**
         * Default String = "A derivative operator expects 2 or 3 or 4 or 5 calculus parameters."
         */
        public String DERIVATIVE_OPERATOR_EXPECTS_2_OR_3_OR_4_OR_5_CALCULUS_PARAMETERS = DEFAULT_DERIVATIVE_OPERATOR_EXPECTS_2_OR_3_OR_4_OR_5_CALCULUS_PARAMETERS;
        /**
         * Default String = "An argument was expected in a derivative operator invocation."
         */
        public String ARGUMENT_WAS_EXPECTED_IN_A_DERIVATIVE_OPERATOR_INVOCATION = DEFAULT_ARGUMENT_WAS_EXPECTED_IN_A_DERIVATIVE_OPERATOR_INVOCATION;
        /**
         * Default String = "Duplicated keywords were found in the calculus operator invocation, check calculus parameters."
         */
        public String DUPLICATED_KEYWORDS_WERE_FOUND_IN_THE_CALCULUS_OPERATOR_INVOCATION = DEFAULT_DUPLICATED_KEYWORDS_WERE_FOUND_IN_THE_CALCULUS_OPERATOR_INVOCATION;
        /**
         * Default String = "One token (argument or unknown) was expected in the calculus operator invocation."
         */
        public String ONE_TOKEN_WAS_EXPECTED_IN_THE_CALCULUS_OPERATOR_INVOCATION = DEFAULT_ONE_TOKEN_WAS_EXPECTED_IN_THE_CALCULUS_OPERATOR_INVOCATION;
        /**
         * Default String = "N-th order derivative operator expects 3 or 5 calculus parameters."
         */
        public String NTH_ORDER_DERIVATIVE_OPERATOR_EXPECTS_3_OR_5_CALCULUS_PARAMETERS = DEFAULT_NTH_ORDER_DERIVATIVE_OPERATOR_EXPECTS_3_OR_5_CALCULUS_PARAMETERS;
        /**
         * Default String = "The integral / solve operator expects 4 calculus parameters."
         */
        public String INTEGRAL_SOLVE_OPERATOR_EXPECTS_4_CALCULUS_PARAMETERS = DEFAULT_INTEGRAL_SOLVE_OPERATOR_EXPECTS_4_CALCULUS_PARAMETERS;
        /**
         * Default String = "The iterated operator expects 4 or 5 calculus parameters."
         */
        public String ITERATED_OPERATOR_EXPECTS_4_OR_5_CALCULUS_PARAMETERS = DEFAULT_ITERATED_OPERATOR_EXPECTS_4_OR_5_CALCULUS_PARAMETERS;
        /**
         * Default String = "The forward / backward difference operator expects 2 or 3 calculus parameters."
         */
        public String FORWARD_BACKWARD_DIFFERENCE_EXPECTS_2_OR_3_PARAMETERS = DEFAULT_FORWARD_BACKWARD_DIFFERENCE_EXPECTS_2_OR_3_PARAMETERS;
        /**
         * Default String = "An argument was expected in the forward / backward difference operator invocation."
         */
        public String FORWARD_BACKWARD_DIFFERENCE_ARGUMENT_WAS_EXPECTED = DEFAULT_FORWARD_BACKWARD_DIFFERENCE_ARGUMENT_WAS_EXPECTED;
        /**
         * Default String = "At least one argument was expected."
         */
        public String AT_LEAST_ONE_ARGUMENT_WAS_EXPECTED = DEFAULT_AT_LEAST_ONE_ARGUMENT_WAS_EXPECTED;
        // -------------------------------------------------
        /**
         * Default String = "Error while executing the calculate."
         */
        public String ERROR_WHILE_EXECUTING_THE_CALCULATE = DEFAULT_ERROR_WHILE_EXECUTING_THE_CALCULATE;
        /**
         * Default String = "Recursion calls counter exceeded maximum calls allowed."
         */
        public String RECURSION_CALLS_COUNTER_EXCEEDED = DEFAULT_RECURSION_CALLS_COUNTER_EXCEEDED;
        /**
         * Default String = "Recursion calls counter"
         */
        public String RECURSION_CALLS_COUNTER = DEFAULT_RECURSION_CALLS_COUNTER;
        /**
         * Default String = "Starting calculation loop."
         */
        public String STARTING_CALCULATION_LOOP = DEFAULT_STARTING_CALCULATION_LOOP;
        /**
         * Default String = "Cancel request encountered - finishing."
         */
        public String CANCEL_REQUEST_FINISHING = DEFAULT_CANCEL_REQUEST_FINISHING;
        /**
         * Default String = "Internal error / strange token level - finishing. Probably a parser error - please report it."
         */
        public String INTERNAL_ERROR_STRANGE_TOKEN_LEVEL_FINISHING = DEFAULT_INTERNAL_ERROR_STRANGE_TOKEN_LEVEL_FINISHING;
        /**
         * Default String = "Fatal error, do not know what to do with the encountered token. Probably a parser error - please report it."
         */
        public String FATAL_ERROR_DO_NOT_KNOW_WHAT_TO_DO_WITH_THE_ENCOUNTERED_TOKEN = DEFAULT_FATAL_ERROR_DO_NOT_KNOW_WHAT_TO_DO_WITH_THE_ENCOUNTERED_TOKEN;
        /**
         * Default String = "The maximum error message length has been exceeded."
         */
        public String MAXIMUM_ERROR_MESSAGE_LENGTH_EXCEEDED = DEFAULT_MAXIMUM_ERROR_MESSAGE_LENGTH_EXCEEDED;
        // -------------------------------------------------
        /**
         * Default String = "Starting..."
         */
        public String STARTING = DEFAULT_STARTING;
        /**
         * Default String = "Parsing"
         */
        public String PARSING = DEFAULT_PARSING;
        /**
         * Default String = "Calculated value"
         */
        public String CALCULATED_VALUE = DEFAULT_CALCULATED_VALUE;
        /**
         * Default String = "Exiting."
         */
        public String EXITING = DEFAULT_EXITING;
        /**
         * Default String = "done."
         */
        public String DONE = DEFAULT_DONE;
        // -------------------------------------------------
        /**
         * Default String = "Help content"
         */
        public String HELP_CONTENT = DEFAULT_HELP_CONTENT;
        /**
         * Default String = "Keyword"
         */
        public String KEYWORD = DEFAULT_KEYWORD;
        /**
         * Default String = "Syntax"
         */
        public String SYNTAX = DEFAULT_SYNTAX;
        /**
         * Default String = "Number"
         */
        public String NUMBER = DEFAULT_NUMBER;
        /**
         * Default String = "Number literal"
         */
        public String NUMBER_LITERAL = DEFAULT_NUMBER_LITERAL;
        /**
         * Default String = "Type"
         */
        public String TYPE = DEFAULT_TYPE;
        /**
         * Default String = "Since"
         */
        public String SINCE = DEFAULT_SINCE;
        /**
         * Default String = "Description"
         */
        public String DESCRIPTION = DEFAULT_DESCRIPTION;
        // -------------------------------------------------
        /**
         * Default String = "CalcStepsRegister is empty"
         */
        public String CALC_STEPS_REGISTER_IS_EMPTY = DEFAULT_CALC_STEPS_REGISTER_IS_EMPTY;
        /**
         * Default String = "CalcStepsRegister for"
         */
        public String CALC_STEPS_REGISTER_FOR = DEFAULT_CALC_STEPS_REGISTER_FOR;
        /**
         * Default String = "Argument"
         */
        public String ARGUMENT = DEFAULT_ARGUMENT;
        /**
         * Default String = "Function"
         */
        public String FUNCTION = DEFAULT_FUNCTION;
        /**
         * Default String = "Expression"
         */
        public String EXPRESSION = DEFAULT_EXPRESSION;
        /**
         * Default String = "result"
         */
        public String RESULT = DEFAULT_RESULT;
        /**
         * Default String = "Computing time"
         */
        public String COMPUTING_TIME = DEFAULT_COMPUTING_TIME;
        /**
         * Default String = "gr"
         */
        public String GROUP_SHORT = DEFAULT_GROUP_SHORT;
        /**
         * Default String = "nr"
         */
        public String NUMBER_SHORT = DEFAULT_NUMBER_SHORT;
        /**
         * Default String = "first"
         */
        public String FIRST = DEFAULT_FIRST;
        /**
         * Default String = "last"
         */
        public String LAST = DEFAULT_LAST;
        /**
         * Default String = "descr"
         */
        public String DESCRIPTION_SHORT = DEFAULT_DESCRIPTION_SHORT;
        /**
         * Default String = "step"
         */
        public String STEP = DEFAULT_STEP;
        // -------------------------------------------------
        /**
         * Default String = "Serialization has been performed:"
         */
        public String INFO_SERIALIZATION_PERFORMED = DEFAULT_INFO_SERIALIZATION_PERFORMED;
        /**
         * Default String = "Deserialization has been performed:"
         */
        public String INFO_DESERIALIZATION_PERFORMED = DEFAULT_INFO_DESERIALIZATION_PERFORMED;
        /**
         * Default String = "Null object passed in the parameter."
         */
        public String ERROR_NULL_OBJECT = DEFAULT_ERROR_NULL_OBJECT;
        /**
         * Default String = "Null file passed in the parameter."
         */
        public String ERROR_NULL_FILE_PATH = DEFAULT_ERROR_NULL_FILE_PATH;
        /**
         * Default String = "The file path does not contain any characters."
         */
        public String ERROR_FILE_PATH_ZERO_LENGTH = DEFAULT_ERROR_FILE_PATH_ZERO_LENGTH;
        /**
         * Default String = "The file path is not a file:"
         */
        public String ERROR_IS_NOT_A_FILE = DEFAULT_ERROR_IS_NOT_A_FILE;
        /**
         * Default String = "The file path does not exits:"
         */
        public String ERROR_FILE_NOT_EXISTS = DEFAULT_ERROR_FILE_NOT_EXISTS;
        /**
         * Default String = "Null data passed in the parameter."
         */
        public String ERROR_NULL_DATA = DEFAULT_ERROR_NULL_DATA;
        /**
         * Default String = "Exception: "
         */
        public String INFO_EXCEPTION = DEFAULT_INFO_EXCEPTION;
        /**
         * Default String = "Binary serialization is enabled. Use it only in a conscious and limited way."
         */
        public String INFO_BINARY_SERIALIZATION_ENABLED = DEFAULT_INFO_BINARY_SERIALIZATION_ENABLED;
        /**
         * Default String = "Binary serialization is disabled. You can enable it if you are aware of security risks."
         */
        public String INFO_BINARY_SERIALIZATION_DISABLED = DEFAULT_INFO_BINARY_SERIALIZATION_DISABLED;
        // -------------------------------------------------
        /**
         * Default String = "User defined expression"
         */
        public String USER_DEFINED_EXPRESSION = DEFAULT_USER_DEFINED_EXPRESSION;
        /**
         * Default String = "User defined argument"
         */
        public String USER_DEFINED_ARGUMENT = DEFAULT_USER_DEFINED_ARGUMENT;
        /**
         * Default String = "User defined constant"
         */
        public String USER_DEFINED_CONSTANT = DEFAULT_USER_DEFINED_CONSTANT;
        /**
         * Default String = "User defined function"
         */
        public String USER_DEFINED_FUNCTION = DEFAULT_USER_DEFINED_FUNCTION;
        /**
         * Default String = "User defined recursive argument"
         */
        public String USER_DEFINED_RECURSIVE_ARGUMENT = DEFAULT_USER_DEFINED_RECURSIVE_ARGUMENT;
        // -------------------------------------------------
        /**
         * Default String = "Deserializing data from an untrusted source can introduce security vulnerabilities to your application."
         */
        public String WARNING_BINARY_SERIALIZATION_SECURITY_RISKS = DEFAULT_WARNING_BINARY_SERIALIZATION_SECURITY_RISKS;
        // -------------------------------------------------
        /**
         * Default String = "Binary relation"
         */
        public String BINARY_RELATION = DEFAULT_BINARY_RELATION;
        /**
         * Default String = "Bitwise operator"
         */
        public String BITWISE_OPERATOR = DEFAULT_BITWISE_OPERATOR;
        /**
         * Default String = "Boolean operator"
         */
        public String BOOLEAN_OPERATOR = DEFAULT_BOOLEAN_OPERATOR;
        /**
         * Default String = "Calculus operator"
         */
        public String CALCULUS_OPERATOR = DEFAULT_CALCULUS_OPERATOR;
        /**
         * Default String = "Constant value"
         */
        public String CONSTANT_VALUE = DEFAULT_CONSTANT_VALUE;
        /**
         * Default String = "Unary function"
         */
        public String FUNCTION_1_ARG = DEFAULT_FUNCTION_1_ARG;
        /**
         * Default String = "Binary function"
         */
        public String FUNCTION_2_ARG = DEFAULT_FUNCTION_2_ARG;
        /**
         * Default String = "Ternary function"
         */
        public String FUNCTION_3_ARG = DEFAULT_FUNCTION_3_ARG;
        /**
         * Default String = "Variadic function"
         */
        public String FUNCTION_VARIADIC = DEFAULT_FUNCTION_VARIADIC;
        /**
         * Default String = "Operator"
         */
        public String OPERATOR = DEFAULT_OPERATOR;
        /**
         * Default String = "Parser symbol"
         */
        public String PARSER_SYMBOL = DEFAULT_PARSER_SYMBOL;
        /**
         * Default String = "Random variable"
         */
        public String RANDOM_VARIABLE = DEFAULT_RANDOM_VARIABLE;
        /**
         * Default String = "Unit"
         */
        public String UNIT = DEFAULT_UNIT;
        /**
         * Default String = "Dimensionless unit"
         */
        public String DIMENSIONLESS_UNIT = DEFAULT_DIMENSIONLESS_UNIT;
        /**
         * Default String = "Iterated operator"
         */
        public String ITERATED_OPERATOR = DEFAULT_ITERATED_OPERATOR;
        // -------------------------------------------------
        /**
         * Default String = "Ratio / Fraction"
         */
        public String RATIO_FRACTION = DEFAULT_RATIO_FRACTION;
        /**
         * Default String = "Metric prefix"
         */
        public String METRIC_PREFIX = DEFAULT_METRIC_PREFIX;
        /**
         * Default String = "Unit of length"
         */
        public String UNIT_OF_LENGTH = DEFAULT_UNIT_OF_LENGTH;
        /**
         * Default String = "Unit of area"
         */
        public String UNIT_OF_AREA = DEFAULT_UNIT_OF_AREA;
        /**
         * Default String = "Unit of volume"
         */
        public String UNIT_OF_VOLUME = DEFAULT_UNIT_OF_VOLUME;
        /**
         * Default String = "Unit of time"
         */
        public String UNIT_OF_TIME = DEFAULT_UNIT_OF_TIME;
        /**
         * Default String = "Unit of mass"
         */
        public String UNIT_OF_MASS = DEFAULT_UNIT_OF_MASS;
        /**
         * Default String = "Unit of information"
         */
        public String UNIT_OF_INFORMATION = DEFAULT_UNIT_OF_INFORMATION;
        /**
         * Default String = "Unit of energy"
         */
        public String UNIT_OF_ENERGY = DEFAULT_UNIT_OF_ENERGY;
        /**
         * Default String = "Unit of speed"
         */
        public String UNIT_OF_SPEED = DEFAULT_UNIT_OF_SPEED;
        /**
         * Default String = "Unit of acceleration"
         */
        public String UNIT_OF_ACCELERATION = DEFAULT_UNIT_OF_ACCELERATION;
        /**
         * Default String = "Unit of angle"
         */
        public String UNIT_OF_ANGLE = DEFAULT_UNIT_OF_ANGLE;
        // -------------------------------------------------
        /**
         * Default String = "Physical constant"
         */
        public String PHYSICAL_CONSTANT = DEFAULT_PHYSICAL_CONSTANT;
        /**
         * Default String = "Astronomical constant"
         */
        public String ASTRONOMICAL_CONSTANT = DEFAULT_ASTRONOMICAL_CONSTANT;
        /**
         * Default String = "Mathematical constant"
         */
        public String MATHEMATICAL_CONSTANT = DEFAULT_MATHEMATICAL_CONSTANT;
        // -------------------------------------------------
        /**
         * Default String = "Probability distribution function"
         */
        public String PROBABILITY_DISTRIBUTION_FUNCTION = DEFAULT_PROBABILITY_DISTRIBUTION_FUNCTION;
        /**
         * Default String = "Cumulative distribution function"
         */
        public String CUMULATIVE_DISTRIBUTION_FUNCTION = DEFAULT_CUMULATIVE_DISTRIBUTION_FUNCTION;
        /**
         * Default String = "Quantile function (inverse cumulative distribution function)"
         */
        public String QUANTILE_FUNCTION = DEFAULT_QUANTILE_FUNCTION;
        // -------------------------------------------------
        /**
         * Default String = "Student's t-distribution"
         */
        public String STUDENTS_T_DISTRIBUTION = DEFAULT_STUDENTS_T_DISTRIBUTION;
        /**
         * Default String = "Chi-squared distribution"
         */
        public String CHI_SQUARED_DISTRIBUTION = DEFAULT_CHI_SQUARED_DISTRIBUTION;
        /**
         * Default String = "Snedecor's F distribution (F-distribution or F-ratio, also known as Fisher–Snedecor distribution)"
         */
        public String SNEDECORS_F_DISTRIBUTION = DEFAULT_SNEDECORS_F_DISTRIBUTION;
        /**
         * Default String = "Uniform continuous distribution"
         */
        public String UNIFORM_CONTINUOUS_DISTRIBUTION = DEFAULT_UNIFORM_CONTINUOUS_DISTRIBUTION;
        /**
         * Default String = "Uniform discrete distribution"
         */
        public String UNIFORM_DISCRETE_DISTRIBUTION = DEFAULT_UNIFORM_DISCRETE_DISTRIBUTION;
        /**
         * Default String = "Normal distribution"
         */
        public String NORMAL_DISTRIBUTION = DEFAULT_NORMAL_DISTRIBUTION;
        // -------------------------------------------------
        /**
         * Default String = "Random integer"
         */
        public String RANDOM_INTEGER = DEFAULT_RANDOM_INTEGER;
        /**
         * Default String = "Random natural number"
         */
        public String RANDOM_NATURAL_NUMBER = DEFAULT_RANDOM_NATURAL_NUMBER;
        /**
         * Default String = "Random natural number including 0"
         */
        public String RANDOM_NATURAL_NUMBER_INCLUDING_0 = DEFAULT_RANDOM_NATURAL_NUMBER_INCLUDING_0;
        // -------------------------------------------------
        /**
         * Default String = "Special function"
         */
        public String SPECIAL_FUNCTION = DEFAULT_SPECIAL_FUNCTION;
        // -------------------------------------------------
        /**
         * Default String = "Semi major axis"
         */
        public String SEMI_MAJOR_AXIS = DEFAULT_SEMI_MAJOR_AXIS;
        // -------------------------------------------------
        /**
         * Default String = "Equality"
         */
        public String BINARY_RELATION_EQ = DEFAULT_BINARY_RELATION_EQ;
        /**
         * Default String = "Inequation"
         */
        public String BINARY_RELATION_NEQ = DEFAULT_BINARY_RELATION_NEQ;
        /**
         * Default String = "Lower than"
         */
        public String BINARY_RELATION_LT = DEFAULT_BINARY_RELATION_LT;
        /**
         * Default String = "Greater than"
         */
        public String BINARY_RELATION_GT = DEFAULT_BINARY_RELATION_GT;
        /**
         * Default String = "Lower or equal"
         */
        public String BINARY_RELATION_LEQ = DEFAULT_BINARY_RELATION_LEQ;
        /**
         * Default String = "Greater or equal"
         */
        public String BINARY_RELATION_GEQ = DEFAULT_BINARY_RELATION_GEQ;
        // -------------------------------------------------
        /**
         * Default String = "Bitwise unary complement"
         */
        public String BITWISE_OPERATOR_COMPL = DEFAULT_BITWISE_OPERATOR_COMPL;
        /**
         * Default String = "Bitwise and"
         */
        public String BITWISE_OPERATOR_AND = DEFAULT_BITWISE_OPERATOR_AND;
        /**
         * Default String = "Bitwise exclusive or"
         */
        public String BITWISE_OPERATOR_XOR = DEFAULT_BITWISE_OPERATOR_XOR;
        /**
         * Default String = "Bitwise inclusive or"
         */
        public String BITWISE_OPERATOR_OR = DEFAULT_BITWISE_OPERATOR_OR;
        /**
         * Default String = "Signed left shift"
         */
        public String BITWISE_OPERATOR_LEFT_SHIFT = DEFAULT_BITWISE_OPERATOR_LEFT_SHIFT;
        /**
         * Default String = "Signed right shift"
         */
        public String BITWISE_OPERATOR_RIGHT_SHIFT = DEFAULT_BITWISE_OPERATOR_RIGHT_SHIFT;
        // -------------------------------------------------
        /**
         * Default String = "Logical conjunction"
         */
        public String BOOLEAN_OPERATOR_AND = DEFAULT_BOOLEAN_OPERATOR_AND;
        /**
         * Default String = "Logical disjunction"
         */
        public String BOOLEAN_OPERATOR_OR = DEFAULT_BOOLEAN_OPERATOR_OR;
        /**
         * Default String = "Negation"
         */
        public String BOOLEAN_OPERATOR_NEG = DEFAULT_BOOLEAN_OPERATOR_NEG;
        /**
         * Default String = "Sheffer stroke"
         */
        public String BOOLEAN_OPERATOR_NAND = DEFAULT_BOOLEAN_OPERATOR_NAND;
        /**
         * Default String = "Logical not or (joint denial)"
         */
        public String BOOLEAN_OPERATOR_NOR = DEFAULT_BOOLEAN_OPERATOR_NOR;
        /**
         * Default String = "Exclusive or"
         */
        public String BOOLEAN_OPERATOR_XOR = DEFAULT_BOOLEAN_OPERATOR_XOR;
        /**
         * Default String = "Implication"
         */
        public String BOOLEAN_OPERATOR_IMP = DEFAULT_BOOLEAN_OPERATOR_IMP;
        /**
         * Default String = "Converse implication"
         */
        public String BOOLEAN_OPERATOR_CIMP = DEFAULT_BOOLEAN_OPERATOR_CIMP;
        /**
         * Default String = "Material nonimplication"
         */
        public String BOOLEAN_OPERATOR_NIMP = DEFAULT_BOOLEAN_OPERATOR_NIMP;
        /**
         * Default String = "Converse nonimplication"
         */
        public String BOOLEAN_OPERATOR_CNIMP = DEFAULT_BOOLEAN_OPERATOR_CNIMP;
        /**
         * Default String = "Logical biconditional"
         */
        public String BOOLEAN_OPERATOR_EQV = DEFAULT_BOOLEAN_OPERATOR_EQV;
        // -------------------------------------------------
        /**
         * Default String = "Summation SIGMA"
         */
        public String CALCULUS_OPERATOR_SUM = DEFAULT_CALCULUS_OPERATOR_SUM;
        /**
         * Default String = "Product PI"
         */
        public String CALCULUS_OPERATOR_PROD = DEFAULT_CALCULUS_OPERATOR_PROD;
        /**
         * Default String = "Definite integral"
         */
        public String CALCULUS_OPERATOR_INT = DEFAULT_CALCULUS_OPERATOR_INT;
        /**
         * Default String = "Derivative"
         */
        public String CALCULUS_OPERATOR_DER = DEFAULT_CALCULUS_OPERATOR_DER;
        /**
         * Default String = "Left derivative"
         */
        public String CALCULUS_OPERATOR_DER_LEFT = DEFAULT_CALCULUS_OPERATOR_DER_LEFT;
        /**
         * Default String = "Right derivative"
         */
        public String CALCULUS_OPERATOR_DER_RIGHT = DEFAULT_CALCULUS_OPERATOR_DER_RIGHT;
        /**
         * Default String = "n-th derivative"
         */
        public String CALCULUS_OPERATOR_DERN = DEFAULT_CALCULUS_OPERATOR_DERN;
        /**
         * Default String = "Forward difference"
         */
        public String CALCULUS_OPERATOR_FORW_DIFF = DEFAULT_CALCULUS_OPERATOR_FORW_DIFF;
        /**
         * Default String = "Backward difference"
         */
        public String CALCULUS_OPERATOR_BACKW_DIFF = DEFAULT_CALCULUS_OPERATOR_BACKW_DIFF;
        /**
         * Default String = "Average"
         */
        public String CALCULUS_OPERATOR_AVG = DEFAULT_CALCULUS_OPERATOR_AVG;
        /**
         * Default String = "Bias-corrected sample variance"
         */
        public String CALCULUS_OPERATOR_VAR = DEFAULT_CALCULUS_OPERATOR_VAR;
        /**
         * Default String = "Bias-corrected sample standard deviation"
         */
        public String CALCULUS_OPERATOR_STD = DEFAULT_CALCULUS_OPERATOR_STD;
        /**
         * Default String = "Minimum value"
         */
        public String CALCULUS_OPERATOR_MIN = DEFAULT_CALCULUS_OPERATOR_MIN;
        /**
         * Default String = "Maximum value"
         */
        public String CALCULUS_OPERATOR_MAX = DEFAULT_CALCULUS_OPERATOR_MAX;
        /**
         * Default String = "Equation solving (root finding)"
         */
        public String CALCULUS_OPERATOR_SOLVE = DEFAULT_CALCULUS_OPERATOR_SOLVE;
        // -------------------------------------------------
        /**
         * Default String = "Pi, Archimedes' or Ludolph's number"
         */
        public String CONSTANT_VALUE_PI = DEFAULT_CONSTANT_VALUE_PI;
        /**
         * Default String = "Napier's or Euler's number (base of Natural logarithm)"
         */
        public String CONSTANT_VALUE_EULER = DEFAULT_CONSTANT_VALUE_EULER;
        /**
         * Default String = "Euler-Mascheroni constant"
         */
        public String CONSTANT_VALUE_EULER_MASCHERONI = DEFAULT_CONSTANT_VALUE_EULER_MASCHERONI;
        /**
         * Default String = "Golden ratio"
         */
        public String CONSTANT_VALUE_GOLDEN_RATIO = DEFAULT_CONSTANT_VALUE_GOLDEN_RATIO;
        /**
         * Default String = "Plastic constant"
         */
        public String CONSTANT_VALUE_PLASTIC = DEFAULT_CONSTANT_VALUE_PLASTIC;
        /**
         * Default String = "Embree-Trefethen constant"
         */
        public String CONSTANT_VALUE_EMBREE_TREFETHEN = DEFAULT_CONSTANT_VALUE_EMBREE_TREFETHEN;
        /**
         * Default String = "Feigenbaum delta constant"
         */
        public String CONSTANT_VALUE_FEIGENBAUM_DELTA = DEFAULT_CONSTANT_VALUE_FEIGENBAUM_DELTA;
        /**
         * Default String = "Feigenbaum alpha constant"
         */
        public String CONSTANT_VALUE_FEIGENBAUM_ALPHA = DEFAULT_CONSTANT_VALUE_FEIGENBAUM_ALPHA;
        /**
         * Default String = "Twin prime constant"
         */
        public String CONSTANT_VALUE_TWIN_PRIME = DEFAULT_CONSTANT_VALUE_TWIN_PRIME;
        /**
         * Default String = "Meissel-Mertens constant"
         */
        public String CONSTANT_VALUE_MEISSEL_MERTEENS = DEFAULT_CONSTANT_VALUE_MEISSEL_MERTEENS;
        /**
         * Default String = "Brun's constant for twin primes"
         */
        public String CONSTANT_VALUE_BRAUN_TWIN_PRIME = DEFAULT_CONSTANT_VALUE_BRAUN_TWIN_PRIME;
        /**
         * Default String = "Brun's constant for prime quadruplets"
         */
        public String CONSTANT_VALUE_BRAUN_PRIME_QUADR = DEFAULT_CONSTANT_VALUE_BRAUN_PRIME_QUADR;
        /**
         * Default String = "de Bruijn-Newman constant"
         */
        public String CONSTANT_VALUE_BRUIJN_NEWMAN = DEFAULT_CONSTANT_VALUE_BRUIJN_NEWMAN;
        /**
         * Default String = "Catalan's constant"
         */
        public String CONSTANT_VALUE_CATALAN = DEFAULT_CONSTANT_VALUE_CATALAN;
        /**
         * Default String = "Landau-Ramanujan constant"
         */
        public String CONSTANT_VALUE_LANDAU_RAMANUJAN = DEFAULT_CONSTANT_VALUE_LANDAU_RAMANUJAN;
        /**
         * Default String = "Viswanath's constant"
         */
        public String CONSTANT_VALUE_VISWANATH = DEFAULT_CONSTANT_VALUE_VISWANATH;
        /**
         * Default String = "Legendre's constant"
         */
        public String CONSTANT_VALUE_LEGENDRE = DEFAULT_CONSTANT_VALUE_LEGENDRE;
        /**
         * Default String = "Ramanujan-Soldner constant"
         */
        public String CONSTANT_VALUE_RAMANUJAN_SOLDNER = DEFAULT_CONSTANT_VALUE_RAMANUJAN_SOLDNER;
        /**
         * Default String = "Erdos-Borwein constant"
         */
        public String CONSTANT_VALUE_ERDOS_BORWEIN = DEFAULT_CONSTANT_VALUE_ERDOS_BORWEIN;
        /**
         * Default String = "Bernstein's constant"
         */
        public String CONSTANT_VALUE_BERNSTEIN = DEFAULT_CONSTANT_VALUE_BERNSTEIN;
        /**
         * Default String = "Gauss-Kuzmin-Wirsing constant"
         */
        public String CONSTANT_VALUE_GAUSS_KUZMIN_WIRSING = DEFAULT_CONSTANT_VALUE_GAUSS_KUZMIN_WIRSING;
        /**
         * Default String = "Hafner-Sarnak-McCurley constant"
         */
        public String CONSTANT_VALUE_HAFNER_SARNAK_MCCURLEY = DEFAULT_CONSTANT_VALUE_HAFNER_SARNAK_MCCURLEY;
        /**
         * Default String = "Golomb-Dickman constant"
         */
        public String CONSTANT_VALUE_GOLOMB_DICKMAN = DEFAULT_CONSTANT_VALUE_GOLOMB_DICKMAN;
        /**
         * Default String = "Cahen's constant"
         */
        public String CONSTANT_VALUE_CAHEN = DEFAULT_CONSTANT_VALUE_CAHEN;
        /**
         * Default String = "Laplace limit constant"
         */
        public String CONSTANT_VALUE_LAPLACE_LIMIT = DEFAULT_CONSTANT_VALUE_LAPLACE_LIMIT;
        /**
         * Default String = "Alladi-Grinstead constant"
         */
        public String CONSTANT_VALUE_ALLADI_GRINSTEAD = DEFAULT_CONSTANT_VALUE_ALLADI_GRINSTEAD;
        /**
         * Default String = "Lengyel's constant"
         */
        public String CONSTANT_VALUE_LENGYEL = DEFAULT_CONSTANT_VALUE_LENGYEL;
        /**
         * Default String = "Levy's constant"
         */
        public String CONSTANT_VALUE_LEVY = DEFAULT_CONSTANT_VALUE_LEVY;
        /**
         * Default String = "Apery's constant"
         */
        public String CONSTANT_VALUE_APERY = DEFAULT_CONSTANT_VALUE_APERY;
        /**
         * Default String = "Mills' constant"
         */
        public String CONSTANT_VALUE_MILLS = DEFAULT_CONSTANT_VALUE_MILLS;
        /**
         * Default String = "Backhouse's constant"
         */
        public String CONSTANT_VALUE_BACKHOUSE = DEFAULT_CONSTANT_VALUE_BACKHOUSE;
        /**
         * Default String = "Porter's constant"
         */
        public String CONSTANT_VALUE_PORTER = DEFAULT_CONSTANT_VALUE_PORTER;
        /**
         * Default String = "Lieb's square ice constant"
         */
        public String CONSTANT_VALUE_LIEB_QUARE_ICE = DEFAULT_CONSTANT_VALUE_LIEB_QUARE_ICE;
        /**
         * Default String = "Niven's constant"
         */
        public String CONSTANT_VALUE_NIVEN = DEFAULT_CONSTANT_VALUE_NIVEN;
        /**
         * Default String = "Sierpinski's constant"
         */
        public String CONSTANT_VALUE_SIERPINSKI = DEFAULT_CONSTANT_VALUE_SIERPINSKI;
        /**
         * Default String = "Khinchin's constant"
         */
        public String CONSTANT_VALUE_KHINCHIN = DEFAULT_CONSTANT_VALUE_KHINCHIN;
        /**
         * Default String = "Fransen-Robinson constant"
         */
        public String CONSTANT_VALUE_FRANSEN_ROBINSON = DEFAULT_CONSTANT_VALUE_FRANSEN_ROBINSON;
        /**
         * Default String = "Landau's constant"
         */
        public String CONSTANT_VALUE_LANDAU = DEFAULT_CONSTANT_VALUE_LANDAU;
        /**
         * Default String = "Parabolic constant"
         */
        public String CONSTANT_VALUE_PARABOLIC = DEFAULT_CONSTANT_VALUE_PARABOLIC;
        /**
         * Default String = "Omega constant"
         */
        public String CONSTANT_VALUE_OMEGA = DEFAULT_CONSTANT_VALUE_OMEGA;
        /**
         * Default String = "MRB constant"
         */
        public String CONSTANT_VALUE_MRB = DEFAULT_CONSTANT_VALUE_MRB;
        /**
         * Default String = "Logarithmic integral at point 2"
         */
        public String CONSTANT_VALUE_LI2 = DEFAULT_CONSTANT_VALUE_LI2;
        /**
         * Default String = "Gompertz constant"
         */
        public String CONSTANT_VALUE_GOMPERTZ = DEFAULT_CONSTANT_VALUE_GOMPERTZ;
        /**
         * Default String = "Light speed in vacuum"
         */
        public String CONSTANT_VALUE_LIGHT_SPEED = DEFAULT_CONSTANT_VALUE_LIGHT_SPEED;
        /**
         * Default String = "Gravitational constant"
         */
        public String CONSTANT_VALUE_GRAVITATIONAL_CONSTANT = DEFAULT_CONSTANT_VALUE_GRAVITATIONAL_CONSTANT;
        /**
         * Default String = "Gravitational acceleration on Earth"
         */
        public String CONSTANT_VALUE_GRAVIT_ACC_EARTH = DEFAULT_CONSTANT_VALUE_GRAVIT_ACC_EARTH;
        /**
         * Default String = "Planck constant"
         */
        public String CONSTANT_VALUE_PLANCK_CONSTANT = DEFAULT_CONSTANT_VALUE_PLANCK_CONSTANT;
        /**
         * Default String = "Reduced Planck constant (Dirac constant)"
         */
        public String CONSTANT_VALUE_PLANCK_CONSTANT_REDUCED = DEFAULT_CONSTANT_VALUE_PLANCK_CONSTANT_REDUCED;
        /**
         * Default String = "Planck length"
         */
        public String CONSTANT_VALUE_PLANCK_LENGTH = DEFAULT_CONSTANT_VALUE_PLANCK_LENGTH;
        /**
         * Default String = "Planck mass"
         */
        public String CONSTANT_VALUE_PLANCK_MASS = DEFAULT_CONSTANT_VALUE_PLANCK_MASS;
        /**
         * Default String = "Planck time"
         */
        public String CONSTANT_VALUE_PLANCK_TIME = DEFAULT_CONSTANT_VALUE_PLANCK_TIME;
        /**
         * Default String = "Light year"
         */
        public String CONSTANT_VALUE_LIGHT_YEAR = DEFAULT_CONSTANT_VALUE_LIGHT_YEAR;
        /**
         * Default String = "Astronomical unit"
         */
        public String CONSTANT_VALUE_ASTRONOMICAL_UNIT = DEFAULT_CONSTANT_VALUE_ASTRONOMICAL_UNIT;
        /**
         * Default String = "Parsec"
         */
        public String CONSTANT_VALUE_PARSEC = DEFAULT_CONSTANT_VALUE_PARSEC;
        /**
         * Default String = "Kiloparsec"
         */
        public String CONSTANT_VALUE_KILOPARSEC = DEFAULT_CONSTANT_VALUE_KILOPARSEC;
        /**
         * Default String = "Earth equatorial radius"
         */
        public String CONSTANT_VALUE_EARTH_RADIUS_EQUATORIAL = DEFAULT_CONSTANT_VALUE_EARTH_RADIUS_EQUATORIAL;
        /**
         * Default String = "Earth polar radius"
         */
        public String CONSTANT_VALUE_EARTH_RADIUS_POLAR = DEFAULT_CONSTANT_VALUE_EARTH_RADIUS_POLAR;
        /**
         * Default String = "Earth mean radius"
         */
        public String CONSTANT_VALUE_EARTH_RADIUS_MEAN = DEFAULT_CONSTANT_VALUE_EARTH_RADIUS_MEAN;
        /**
         * Default String = "Earth mass"
         */
        public String CONSTANT_VALUE_EARTH_MASS = DEFAULT_CONSTANT_VALUE_EARTH_MASS;
        /**
         * Default String = "Earth-Sun distance"
         */
        public String CONSTANT_VALUE_EARTH_SEMI_MAJOR_AXIS = DEFAULT_CONSTANT_VALUE_EARTH_SEMI_MAJOR_AXIS;
        /**
         * Default String = "Moon mean radius"
         */
        public String CONSTANT_VALUE_MOON_RADIUS_MEAN = DEFAULT_CONSTANT_VALUE_MOON_RADIUS_MEAN;
        /**
         * Default String = "Moon mass"
         */
        public String CONSTANT_VALUE_MOON_MASS = DEFAULT_CONSTANT_VALUE_MOON_MASS;
        /**
         * Default String = "Moon-Earth distance"
         */
        public String CONSTANT_VALUE_MONN_SEMI_MAJOR_AXIS = DEFAULT_CONSTANT_VALUE_MONN_SEMI_MAJOR_AXIS;
        /**
         * Default String = "Solar mean radius"
         */
        public String CONSTANT_VALUE_SOLAR_RADIUS = DEFAULT_CONSTANT_VALUE_SOLAR_RADIUS;
        /**
         * Default String = "Solar mass"
         */
        public String CONSTANT_VALUE_SOLAR_MASS = DEFAULT_CONSTANT_VALUE_SOLAR_MASS;
        /**
         * Default String = "Mercury mean radius"
         */
        public String CONSTANT_VALUE_MERCURY_RADIUS_MEAN = DEFAULT_CONSTANT_VALUE_MERCURY_RADIUS_MEAN;
        /**
         * Default String = "Mercury mass"
         */
        public String CONSTANT_VALUE_MERCURY_MASS = DEFAULT_CONSTANT_VALUE_MERCURY_MASS;
        /**
         * Default String = "Mercury-Sun distance"
         */
        public String CONSTANT_VALUE_MERCURY_SEMI_MAJOR_AXIS = DEFAULT_CONSTANT_VALUE_MERCURY_SEMI_MAJOR_AXIS;
        /**
         * Default String = "Venus mean radius"
         */
        public String CONSTANT_VALUE_VENUS_RADIUS_MEAN = DEFAULT_CONSTANT_VALUE_VENUS_RADIUS_MEAN;
        /**
         * Default String = "Venus mass"
         */
        public String CONSTANT_VALUE_VENUS_MASS = DEFAULT_CONSTANT_VALUE_VENUS_MASS;
        /**
         * Default String = "Venus-Sun distance"
         */
        public String CONSTANT_VALUE_VENUS_SEMI_MAJOR_AXIS = DEFAULT_CONSTANT_VALUE_VENUS_SEMI_MAJOR_AXIS;
        /**
         * Default String = "Mars mean radius"
         */
        public String CONSTANT_VALUE_MARS_RADIUS_MEAN = DEFAULT_CONSTANT_VALUE_MARS_RADIUS_MEAN;
        /**
         * Default String = "Mars mass"
         */
        public String CONSTANT_VALUE_MARS_MASS = DEFAULT_CONSTANT_VALUE_MARS_MASS;
        /**
         * Default String = "Mars-Sun distance"
         */
        public String CONSTANT_VALUE_MARS_SEMI_MAJOR_AXIS = DEFAULT_CONSTANT_VALUE_MARS_SEMI_MAJOR_AXIS;
        /**
         * Default String = "Jupiter mean radius"
         */
        public String CONSTANT_VALUE_JUPITER_RADIUS_MEAN = DEFAULT_CONSTANT_VALUE_JUPITER_RADIUS_MEAN;
        /**
         * Default String = "Jupiter mass"
         */
        public String CONSTANT_VALUE_JUPITER_MASS = DEFAULT_CONSTANT_VALUE_JUPITER_MASS;
        /**
         * Default String = "Jupiter-Sun distance"
         */
        public String CONSTANT_VALUE_JUPITER_SEMI_MAJOR_AXIS = DEFAULT_CONSTANT_VALUE_JUPITER_SEMI_MAJOR_AXIS;
        /**
         * Default String = "Saturn mean radius"
         */
        public String CONSTANT_VALUE_SATURN_RADIUS_MEAN = DEFAULT_CONSTANT_VALUE_SATURN_RADIUS_MEAN;
        /**
         * Default String = "Saturn mass"
         */
        public String CONSTANT_VALUE_SATURN_MASS = DEFAULT_CONSTANT_VALUE_SATURN_MASS;
        /**
         * Default String = "Saturn-Sun distance"
         */
        public String CONSTANT_VALUE_SATURN_SEMI_MAJOR_AXIS = DEFAULT_CONSTANT_VALUE_SATURN_SEMI_MAJOR_AXIS;
        /**
         * Default String = "Uranus mean radius"
         */
        public String CONSTANT_VALUE_URANUS_RADIUS_MEAN = DEFAULT_CONSTANT_VALUE_URANUS_RADIUS_MEAN;
        /**
         * Default String = "Uranus mass"
         */
        public String CONSTANT_VALUE_URANUS_MASS = DEFAULT_CONSTANT_VALUE_URANUS_MASS;
        /**
         * Default String = "Uranus-Sun distance"
         */
        public String CONSTANT_VALUE_URANUS_SEMI_MAJOR_AXIS = DEFAULT_CONSTANT_VALUE_URANUS_SEMI_MAJOR_AXIS;
        /**
         * Default String = "Neptune mean radius"
         */
        public String CONSTANT_VALUE_NEPTUNE_RADIUS_MEAN = DEFAULT_CONSTANT_VALUE_NEPTUNE_RADIUS_MEAN;
        /**
         * Default String = "Neptune mass"
         */
        public String CONSTANT_VALUE_NEPTUNE_MASS = DEFAULT_CONSTANT_VALUE_NEPTUNE_MASS;
        /**
         * Default String = "Neptune-Sun distance"
         */
        public String CONSTANT_VALUE_NEPTUNE_SEMI_MAJOR_AXIS = DEFAULT_CONSTANT_VALUE_NEPTUNE_SEMI_MAJOR_AXIS;
        /**
         * Default String = "Boolean True represented as 1"
         */
        public String CONSTANT_VALUE_TRUE = DEFAULT_CONSTANT_VALUE_TRUE;
        /**
         * Default String = "Boolean False represented as 0"
         */
        public String CONSTANT_VALUE_FALSE = DEFAULT_CONSTANT_VALUE_FALSE;
        /**
         * Default String = "Automatically generated constant for user defined functions, returns number of given function parameters"
         */
        public String CONSTANT_VALUE_NPAR = DEFAULT_CONSTANT_VALUE_NPAR;
        /**
         * Default String = "Not-a-Number"
         */
        public String CONSTANT_VALUE_NAN = DEFAULT_CONSTANT_VALUE_NAN;
        // -------------------------------------------------
        /**
         * Default String = "Trigonometric sine"
         */
        public String FUNCTION_1_ARG_SIN = DEFAULT_FUNCTION_1_ARG_SIN;
        /**
         * Default String = "Trigonometric cosine"
         */
        public String FUNCTION_1_ARG_COS = DEFAULT_FUNCTION_1_ARG_COS;
        /**
         * Default String = "Trigonometric tangent"
         */
        public String FUNCTION_1_ARG_TAN = DEFAULT_FUNCTION_1_ARG_TAN;
        /**
         * Default String = "Trigonometric cotangent"
         */
        public String FUNCTION_1_ARG_CTAN = DEFAULT_FUNCTION_1_ARG_CTAN;
        /**
         * Default String = "Trigonometric secant"
         */
        public String FUNCTION_1_ARG_SEC = DEFAULT_FUNCTION_1_ARG_SEC;
        /**
         * Default String = "Trigonometric cosecant"
         */
        public String FUNCTION_1_ARG_COSEC = DEFAULT_FUNCTION_1_ARG_COSEC;
        /**
         * Default String = "Inverse trigonometric sine"
         */
        public String FUNCTION_1_ARG_ASIN = DEFAULT_FUNCTION_1_ARG_ASIN;
        /**
         * Default String = "Inverse trigonometric cosine"
         */
        public String FUNCTION_1_ARG_ACOS = DEFAULT_FUNCTION_1_ARG_ACOS;
        /**
         * Default String = "Inverse trigonometric tangent"
         */
        public String FUNCTION_1_ARG_ATAN = DEFAULT_FUNCTION_1_ARG_ATAN;
        /**
         * Default String = "Inverse trigonometric cotangent"
         */
        public String FUNCTION_1_ARG_ACTAN = DEFAULT_FUNCTION_1_ARG_ACTAN;
        /**
         * Default String = "Natural logarithm (base e)"
         */
        public String FUNCTION_1_ARG_LN = DEFAULT_FUNCTION_1_ARG_LN;
        /**
         * Default String = "Binary logarithm (base 2)"
         */
        public String FUNCTION_1_ARG_LOG2 = DEFAULT_FUNCTION_1_ARG_LOG2;
        /**
         * Default String = "Common logarithm (base 10)"
         */
        public String FUNCTION_1_ARG_LOG10 = DEFAULT_FUNCTION_1_ARG_LOG10;
        /**
         * Default String = "Degrees to radians"
         */
        public String FUNCTION_1_ARG_RAD = DEFAULT_FUNCTION_1_ARG_RAD;
        /**
         * Default String = "Exponential"
         */
        public String FUNCTION_1_ARG_EXP = DEFAULT_FUNCTION_1_ARG_EXP;
        /**
         * Default String = "Squre root"
         */
        public String FUNCTION_1_ARG_SQRT = DEFAULT_FUNCTION_1_ARG_SQRT;
        /**
         * Default String = "Hyperbolic sine"
         */
        public String FUNCTION_1_ARG_SINH = DEFAULT_FUNCTION_1_ARG_SINH;
        /**
         * Default String = "Hyperbolic cosine"
         */
        public String FUNCTION_1_ARG_COSH = DEFAULT_FUNCTION_1_ARG_COSH;
        /**
         * Default String = "Hyperbolic tangent"
         */
        public String FUNCTION_1_ARG_TANH = DEFAULT_FUNCTION_1_ARG_TANH;
        /**
         * Default String = "Hyperbolic cotangent"
         */
        public String FUNCTION_1_ARG_COTH = DEFAULT_FUNCTION_1_ARG_COTH;
        /**
         * Default String = "Hyperbolic secant"
         */
        public String FUNCTION_1_ARG_SECH = DEFAULT_FUNCTION_1_ARG_SECH;
        /**
         * Default String = "Hyperbolic cosecant"
         */
        public String FUNCTION_1_ARG_CSCH = DEFAULT_FUNCTION_1_ARG_CSCH;
        /**
         * Default String = "Radians to degrees"
         */
        public String FUNCTION_1_ARG_DEG = DEFAULT_FUNCTION_1_ARG_DEG;
        /**
         * Default String = "Absolut value"
         */
        public String FUNCTION_1_ARG_ABS = DEFAULT_FUNCTION_1_ARG_ABS;
        /**
         * Default String = "Signum"
         */
        public String FUNCTION_1_ARG_SGN = DEFAULT_FUNCTION_1_ARG_SGN;
        /**
         * Default String = "Floor"
         */
        public String FUNCTION_1_ARG_FLOOR = DEFAULT_FUNCTION_1_ARG_FLOOR;
        /**
         * Default String = "Ceiling"
         */
        public String FUNCTION_1_ARG_CEIL = DEFAULT_FUNCTION_1_ARG_CEIL;
        /**
         * Default String = "Negation"
         */
        public String FUNCTION_1_ARG_NOT = DEFAULT_FUNCTION_1_ARG_NOT;
        /**
         * Default String = "Inverse hyperbolic sine"
         */
        public String FUNCTION_1_ARG_ARSINH = DEFAULT_FUNCTION_1_ARG_ARSINH;
        /**
         * Default String = "Inverse hyperbolic cosine"
         */
        public String FUNCTION_1_ARG_ARCOSH = DEFAULT_FUNCTION_1_ARG_ARCOSH;
        /**
         * Default String = "Inverse hyperbolic tangent"
         */
        public String FUNCTION_1_ARG_ARTANH = DEFAULT_FUNCTION_1_ARG_ARTANH;
        /**
         * Default String = "Inverse hyperbolic cotangent"
         */
        public String FUNCTION_1_ARG_ARCOTH = DEFAULT_FUNCTION_1_ARG_ARCOTH;
        /**
         * Default String = "Inverse hyperbolic secant"
         */
        public String FUNCTION_1_ARG_ARSECH = DEFAULT_FUNCTION_1_ARG_ARSECH;
        /**
         * Default String = "Inverse hyperbolic cosecant"
         */
        public String FUNCTION_1_ARG_ARCSCH = DEFAULT_FUNCTION_1_ARG_ARCSCH;
        /**
         * Default String = "Sinc (normalized)"
         */
        public String FUNCTION_1_ARG_SA = DEFAULT_FUNCTION_1_ARG_SA;
        /**
         * Default String = "Sinc (unnormalized)"
         */
        public String FUNCTION_1_ARG_SINC = DEFAULT_FUNCTION_1_ARG_SINC;
        /**
         * Default String = "Bell number"
         */
        public String FUNCTION_1_ARG_BELL_NUMBER = DEFAULT_FUNCTION_1_ARG_BELL_NUMBER;
        /**
         * Default String = "Lucas number"
         */
        public String FUNCTION_1_ARG_LUCAS_NUMBER = DEFAULT_FUNCTION_1_ARG_LUCAS_NUMBER;
        /**
         * Default String = "Fibonacci number"
         */
        public String FUNCTION_1_ARG_FIBONACCI_NUMBER = DEFAULT_FUNCTION_1_ARG_FIBONACCI_NUMBER;
        /**
         * Default String = "Harmonic number"
         */
        public String FUNCTION_1_ARG_HARMONIC_NUMBER = DEFAULT_FUNCTION_1_ARG_HARMONIC_NUMBER;
        /**
         * Default String = "Prime number test (is number a prime?)"
         */
        public String FUNCTION_1_ARG_IS_PRIME = DEFAULT_FUNCTION_1_ARG_IS_PRIME;
        /**
         * Default String = "Prime-counting"
         */
        public String FUNCTION_1_ARG_PRIME_COUNT = DEFAULT_FUNCTION_1_ARG_PRIME_COUNT;
        /**
         * Default String = "Exponential integral"
         */
        public String FUNCTION_1_ARG_EXP_INT = DEFAULT_FUNCTION_1_ARG_EXP_INT;
        /**
         * Default String = "Logarithmic integral"
         */
        public String FUNCTION_1_ARG_LOG_INT = DEFAULT_FUNCTION_1_ARG_LOG_INT;
        /**
         * Default String = "Offset logarithmic integral"
         */
        public String FUNCTION_1_ARG_OFF_LOG_INT = DEFAULT_FUNCTION_1_ARG_OFF_LOG_INT;
        /**
         * Default String = "Gauss error"
         */
        public String FUNCTION_1_ARG_GAUSS_ERF = DEFAULT_FUNCTION_1_ARG_GAUSS_ERF;
        /**
         * Default String = "Gauss complementary error"
         */
        public String FUNCTION_1_ARG_GAUSS_ERFC = DEFAULT_FUNCTION_1_ARG_GAUSS_ERFC;
        /**
         * Default String = "Inverse Gauss error"
         */
        public String FUNCTION_1_ARG_GAUSS_ERF_INV = DEFAULT_FUNCTION_1_ARG_GAUSS_ERF_INV;
        /**
         * Default String = "Inverse Gauss complementary error"
         */
        public String FUNCTION_1_ARG_GAUSS_ERFC_INV = DEFAULT_FUNCTION_1_ARG_GAUSS_ERFC_INV;
        /**
         * Default String = "Unit in The Last Place"
         */
        public String FUNCTION_1_ARG_ULP = DEFAULT_FUNCTION_1_ARG_ULP;
        /**
         * Default String = "Returns true if value is a Not-a-Number (NaN), false otherwise"
         */
        public String FUNCTION_1_ARG_ISNAN = DEFAULT_FUNCTION_1_ARG_ISNAN;
        /**
         * Default String = "Number of digits in numeral system with base 10"
         */
        public String FUNCTION_1_ARG_NDIG10 = DEFAULT_FUNCTION_1_ARG_NDIG10;
        /**
         * Default String = "Prime decomposition - number of distinct prime factors"
         */
        public String FUNCTION_1_ARG_NFACT = DEFAULT_FUNCTION_1_ARG_NFACT;
        /**
         * Default String = "Inverse trigonometric secant"
         */
        public String FUNCTION_1_ARG_ARCSEC = DEFAULT_FUNCTION_1_ARG_ARCSEC;
        /**
         * Default String = "Inverse trigonometric cosecant"
         */
        public String FUNCTION_1_ARG_ARCCSC = DEFAULT_FUNCTION_1_ARG_ARCCSC;
        /**
         * Default String = "Gamma"
         */
        public String FUNCTION_1_ARG_GAMMA = DEFAULT_FUNCTION_1_ARG_GAMMA;
        /**
         * Default String = "Lambert-W, principal branch 0, also called the omega or product logarithm"
         */
        public String FUNCTION_1_ARG_LAMBERT_W0 = DEFAULT_FUNCTION_1_ARG_LAMBERT_W0;
        /**
         * Default String = "Lambert-W, branch -1, also called the omega or product logarithm"
         */
        public String FUNCTION_1_ARG_LAMBERT_W1 = DEFAULT_FUNCTION_1_ARG_LAMBERT_W1;
        /**
         * Default String = "Signum of Gamma"
         */
        public String FUNCTION_1_ARG_SGN_GAMMA = DEFAULT_FUNCTION_1_ARG_SGN_GAMMA;
        /**
         * Default String = "Log Gamma"
         */
        public String FUNCTION_1_ARG_LOG_GAMMA = DEFAULT_FUNCTION_1_ARG_LOG_GAMMA;
        /**
         * Default String = "Digamma as the logarithmic derivative of the Gamma"
         */
        public String FUNCTION_1_ARG_DI_GAMMA = DEFAULT_FUNCTION_1_ARG_DI_GAMMA;
        /**
         * Default String = "Automatically generated function for user defined functions, returns function parameter value at index 'i'"
         */
        public String FUNCTION_1_ARG_PARAM = DEFAULT_FUNCTION_1_ARG_PARAM;
        // -------------------------------------------------
        /**
         * Default String = "Logarithm"
         */
        public String FUNCTION_2_ARG_LOG = DEFAULT_FUNCTION_2_ARG_LOG;
        /**
         * Default String = "Modulo"
         */
        public String FUNCTION_2_ARG_MOD = DEFAULT_FUNCTION_2_ARG_MOD;
        /**
         * Default String = "Binomial coefficient, number of k-combinations that can be drawn from n-elements set"
         */
        public String FUNCTION_2_ARG_BINOM_COEFF = DEFAULT_FUNCTION_2_ARG_BINOM_COEFF;
        /**
         * Default String = "Bernoulli numbers"
         */
        public String FUNCTION_2_ARG_BERNOULLI_NUMBER = DEFAULT_FUNCTION_2_ARG_BERNOULLI_NUMBER;
        /**
         * Default String = "Stirling numbers of the first kind"
         */
        public String FUNCTION_2_ARG_STIRLING1_NUMBER = DEFAULT_FUNCTION_2_ARG_STIRLING1_NUMBER;
        /**
         * Default String = "Stirling numbers of the second kind"
         */
        public String FUNCTION_2_ARG_STIRLING2_NUMBER = DEFAULT_FUNCTION_2_ARG_STIRLING2_NUMBER;
        /**
         * Default String = "Worpitzky number"
         */
        public String FUNCTION_2_ARG_WORPITZKY_NUMBER = DEFAULT_FUNCTION_2_ARG_WORPITZKY_NUMBER;
        /**
         * Default String = "Euler number"
         */
        public String FUNCTION_2_ARG_EULER_NUMBER = DEFAULT_FUNCTION_2_ARG_EULER_NUMBER;
        /**
         * Default String = "Kronecker delta"
         */
        public String FUNCTION_2_ARG_KRONECKER_DELTA = DEFAULT_FUNCTION_2_ARG_KRONECKER_DELTA;
        /**
         * Default String = "EulerPol"
         */
        public String FUNCTION_2_ARG_EULER_POLYNOMIAL = DEFAULT_FUNCTION_2_ARG_EULER_POLYNOMIAL;
        /**
         * Default String = "Harmonic number"
         */
        public String FUNCTION_2_ARG_HARMONIC_NUMBER = DEFAULT_FUNCTION_2_ARG_HARMONIC_NUMBER;
        /**
         * Default String = "Half-up rounding"
         */
        public String FUNCTION_2_ARG_ROUND = DEFAULT_FUNCTION_2_ARG_ROUND;
        /**
         * Default String = "Number of digits representing the number in numeral system with given base"
         */
        public String FUNCTION_2_ARG_NDIG = DEFAULT_FUNCTION_2_ARG_NDIG;
        /**
         * Default String = "Digit at position 1 ... n (left -> right) or 0 ... -(n-1) (right -> left) - base 10 numeral system"
         */
        public String FUNCTION_2_ARG_DIGIT10 = DEFAULT_FUNCTION_2_ARG_DIGIT10;
        /**
         * Default String = "Prime decomposition - factor value at position between 1 ... nfact(n) - ascending order by factor value"
         */
        public String FUNCTION_2_ARG_FACTVAL = DEFAULT_FUNCTION_2_ARG_FACTVAL;
        /**
         * Default String = "Prime decomposition - factor exponent / multiplicity at position between 1 ... nfact(n) - ascending order by factor value"
         */
        public String FUNCTION_2_ARG_FACTEXP = DEFAULT_FUNCTION_2_ARG_FACTEXP;
        /**
         * Default String = "N-th order root of a number"
         */
        public String FUNCTION_2_ARG_ROOT = DEFAULT_FUNCTION_2_ARG_ROOT;
        /**
         * Default String = "Lower incomplete gamma"
         */
        public String FUNCTION_2_ARG_INC_GAMMA_LOWER = DEFAULT_FUNCTION_2_ARG_INC_GAMMA_LOWER;
        /**
         * Default String = "Upper incomplete Gamma"
         */
        public String FUNCTION_2_ARG_INC_GAMMA_UPPER = DEFAULT_FUNCTION_2_ARG_INC_GAMMA_UPPER;
        /**
         * Default String = "Lower regularized P gamma"
         */
        public String FUNCTION_2_ARG_REG_GAMMA_LOWER = DEFAULT_FUNCTION_2_ARG_REG_GAMMA_LOWER;
        /**
         * Default String = "Upper regularized Q Gamma"
         */
        public String FUNCTION_2_ARG_REG_GAMMA_UPPER = DEFAULT_FUNCTION_2_ARG_REG_GAMMA_UPPER;
        /**
         * Default String = "Number of k-permutations that can be drawn from n-elements set"
         */
        public String FUNCTION_2_ARG_PERMUTATIONS = DEFAULT_FUNCTION_2_ARG_PERMUTATIONS;
        /**
         * Default String = "The Beta, also called the Euler integral of the first kind"
         */
        public String FUNCTION_2_ARG_BETA = DEFAULT_FUNCTION_2_ARG_BETA;
        /**
         * Default String = "The Log Beta, also called the Log Euler integral of the first kind"
         */
        public String FUNCTION_2_ARG_LOG_BETA = DEFAULT_FUNCTION_2_ARG_LOG_BETA;
        // -------------------------------------------------
        /**
         * Default String = "If"
         */
        public String FUNCTION_3_ARG_IF = DEFAULT_FUNCTION_3_ARG_IF;
        /**
         * Default String = "Characteristic function for x in (a,b)"
         */
        public String FUNCTION_3_ARG_CHI = DEFAULT_FUNCTION_3_ARG_CHI;
        /**
         * Default String = "Characteristic function for x in [a,b]"
         */
        public String FUNCTION_3_ARG_CHI_LR = DEFAULT_FUNCTION_3_ARG_CHI_LR;
        /**
         * Default String = "Characteristic function for x in [a,b)"
         */
        public String FUNCTION_3_ARG_CHI_L = DEFAULT_FUNCTION_3_ARG_CHI_L;
        /**
         * Default String = "Characteristic function for x in (a,b]"
         */
        public String FUNCTION_3_ARG_CHI_R = DEFAULT_FUNCTION_3_ARG_CHI_R;
        /**
         * Default String = "Digit at position 1 ... n (left -> right) or 0 ... -(n-1) (right -> left) - numeral system with given base"
         */
        public String FUNCTION_3_ARG_DIGIT = DEFAULT_FUNCTION_3_ARG_DIGIT;
        /**
         * Default String = "The incomplete Beta, also called the incomplete Euler integral of the first kind"
         */
        public String FUNCTION_3_ARG_INC_BETA = DEFAULT_FUNCTION_3_ARG_INC_BETA;
        /**
         * Default String = "The regularized incomplete Beta (or regularized beta), also called the regularized incomplete Euler integral of the first kind"
         */
        public String FUNCTION_3_ARG_REG_BETA = DEFAULT_FUNCTION_3_ARG_REG_BETA;
        // -------------------------------------------------
        /**
         * Default String = "If function"
         */
        public String FUNCTION_VARIADIC_IFF = DEFAULT_FUNCTION_VARIADIC_IFF;
        /**
         * Default String = "Minimum"
         */
        public String FUNCTION_VARIADIC_MIN = DEFAULT_FUNCTION_VARIADIC_MIN;
        /**
         * Default String = "Maximum"
         */
        public String FUNCTION_VARIADIC_MAX = DEFAULT_FUNCTION_VARIADIC_MAX;
        /**
         * Default String = "Continued fraction"
         */
        public String FUNCTION_VARIADIC_CONT_FRAC = DEFAULT_FUNCTION_VARIADIC_CONT_FRAC;
        /**
         * Default String = "Continued polynomial"
         */
        public String FUNCTION_VARIADIC_CONT_POL = DEFAULT_FUNCTION_VARIADIC_CONT_POL;
        /**
         * Default String = "Greatest common divisor"
         */
        public String FUNCTION_VARIADIC_GCD = DEFAULT_FUNCTION_VARIADIC_GCD;
        /**
         * Default String = "Least common multiple"
         */
        public String FUNCTION_VARIADIC_LCM = DEFAULT_FUNCTION_VARIADIC_LCM;
        /**
         * Default String = "Summation"
         */
        public String FUNCTION_VARIADIC_SUM = DEFAULT_FUNCTION_VARIADIC_SUM;
        /**
         * Default String = "Multiplication"
         */
        public String FUNCTION_VARIADIC_PROD = DEFAULT_FUNCTION_VARIADIC_PROD;
        /**
         * Default String = "Mean / average value"
         */
        public String FUNCTION_VARIADIC_AVG = DEFAULT_FUNCTION_VARIADIC_AVG;
        /**
         * Default String = "Bias-corrected sample variance"
         */
        public String FUNCTION_VARIADIC_VAR = DEFAULT_FUNCTION_VARIADIC_VAR;
        /**
         * Default String = "Bias-corrected sample standard deviation"
         */
        public String FUNCTION_VARIADIC_STD = DEFAULT_FUNCTION_VARIADIC_STD;
        /**
         * Default String = "Random number from a given list of numbers"
         */
        public String FUNCTION_VARIADIC_RND_LIST = DEFAULT_FUNCTION_VARIADIC_RND_LIST;
        /**
         * Default String = "Returns the first non-NaN value"
         */
        public String FUNCTION_VARIADIC_COALESCE = DEFAULT_FUNCTION_VARIADIC_COALESCE;
        /**
         * Default String = "Logical disjunction (OR) - variadic"
         */
        public String FUNCTION_VARIADIC_OR = DEFAULT_FUNCTION_VARIADIC_OR;
        /**
         * Default String = "Logical conjunction (AND) - variadic"
         */
        public String FUNCTION_VARIADIC_AND = DEFAULT_FUNCTION_VARIADIC_AND;
        /**
         * Default String = "Exclusive or (XOR) - variadic"
         */
        public String FUNCTION_VARIADIC_XOR = DEFAULT_FUNCTION_VARIADIC_XOR;
        /**
         * Default String = "Arguments / indices of the minima"
         */
        public String FUNCTION_VARIADIC_ARGMIN = DEFAULT_FUNCTION_VARIADIC_ARGMIN;
        /**
         * Default String = "Arguments / indices of the maxima"
         */
        public String FUNCTION_VARIADIC_ARGMAX = DEFAULT_FUNCTION_VARIADIC_ARGMAX;
        /**
         * Default String = "The sample median"
         */
        public String FUNCTION_VARIADIC_MEDIAN = DEFAULT_FUNCTION_VARIADIC_MEDIAN;
        /**
         * Default String = "Mode - the value that appears most often"
         */
        public String FUNCTION_VARIADIC_MODE = DEFAULT_FUNCTION_VARIADIC_MODE;
        /**
         * Default String = "Returns number in given numeral system base represented by list of digits"
         */
        public String FUNCTION_VARIADIC_BASE = DEFAULT_FUNCTION_VARIADIC_BASE;
        /**
         * Default String = "Number of distinct values"
         */
        public String FUNCTION_VARIADIC_NDIST = DEFAULT_FUNCTION_VARIADIC_NDIST;
        // -------------------------------------------------
        /**
         * Default String = "Addition"
         */
        public String OPERATOR_PLUS = DEFAULT_OPERATOR_PLUS;
        /**
         * Default String = "Subtraction"
         */
        public String OPERATOR_MINUS = DEFAULT_OPERATOR_MINUS;
        /**
         * Default String = "Multiplication"
         */
        public String OPERATOR_MULTIPLY = DEFAULT_OPERATOR_MULTIPLY;
        /**
         * Default String = "Division"
         */
        public String OPERATOR_DIVIDE = DEFAULT_OPERATOR_DIVIDE;
        /**
         * Default String = "Exponentiation"
         */
        public String OPERATOR_POWER = DEFAULT_OPERATOR_POWER;
        /**
         * Default String = "Factorial"
         */
        public String OPERATOR_FACT = DEFAULT_OPERATOR_FACT;
        /**
         * Default String = "Modulo"
         */
        public String OPERATOR_MOD = DEFAULT_OPERATOR_MOD;
        /**
         * Default String = "Percentage"
         */
        public String OPERATOR_PERC = DEFAULT_OPERATOR_PERC;
        /**
         * Default String = "Tetration (hyper-4, power tower, exponential tower)"
         */
        public String OPERATOR_TETRATION = DEFAULT_OPERATOR_TETRATION;
        /**
         * Default String = "Square root"
         */
        public String OPERATOR_SQUARE_ROOT = DEFAULT_OPERATOR_SQUARE_ROOT;
        /**
         * Default String = "Cube root"
         */
        public String OPERATOR_CUBE_ROOT = DEFAULT_OPERATOR_CUBE_ROOT;
        /**
         * Default String = "Fourth root"
         */
        public String OPERATOR_FOURTH_ROOT = DEFAULT_OPERATOR_FOURTH_ROOT;
        // -------------------------------------------------
        /**
         * Default String = "Left parentheses"
         */
        public String PARSER_SYMBOL_LEFT_PARENTHESES = DEFAULT_PARSER_SYMBOL_LEFT_PARENTHESES;
        /**
         * Default String = "Right parentheses"
         */
        public String PARSER_SYMBOL_RIGHT_PARENTHESES = DEFAULT_PARSER_SYMBOL_RIGHT_PARENTHESES;
        /**
         * Default String = "Comma (function parameters)"
         */
        public String PARSER_SYMBOL_COMMA = DEFAULT_PARSER_SYMBOL_COMMA;
        /**
         * Default String = "Semicolon (function parameters)"
         */
        public String PARSER_SYMBOL_SEMI = DEFAULT_PARSER_SYMBOL_SEMI;
        /**
         * Default String = "Blank (whitespace) character"
         */
        public String PARSER_SYMBOL_BLANK = DEFAULT_PARSER_SYMBOL_BLANK;
        /**
         * Default String = "Integer"
         */
        public String PARSER_SYMBOL_NUMBER_INTEGER = DEFAULT_PARSER_SYMBOL_NUMBER_INTEGER;
        /**
         * Default String = "Decimal"
         */
        public String PARSER_SYMBOL_NUMBER_DECIMAL = DEFAULT_PARSER_SYMBOL_NUMBER_DECIMAL;
        /**
         * Default String = "Leading zero"
         */
        public String PARSER_SYMBOL_NUMBER_LEADING_ZERO = DEFAULT_PARSER_SYMBOL_NUMBER_LEADING_ZERO;
        /**
         * Default String = "Scientific notation"
         */
        public String PARSER_SYMBOL_NUMBER_SCI_NOTATION = DEFAULT_PARSER_SYMBOL_NUMBER_SCI_NOTATION;
        /**
         * Default String = "No leading zero"
         */
        public String PARSER_SYMBOL_NUMBER_NO_LEADING_ZERO = DEFAULT_PARSER_SYMBOL_NUMBER_NO_LEADING_ZERO;
        /**
         * Default String = "Fractions"
         */
        public String PARSER_SYMBOL_NUMBER_FRACTIONS = DEFAULT_PARSER_SYMBOL_NUMBER_FRACTIONS;
        /**
         * Default String = "Other numeral systems"
         */
        public String PARSER_SYMBOL_NUMBER_OTHER_NUMERAL_SYSTEMS = DEFAULT_PARSER_SYMBOL_NUMBER_OTHER_NUMERAL_SYSTEMS;
        /**
         * Default String = " - Unicode math symbol"
         */
        public String PARSER_SYMBOL_UNICODE_MATH = DEFAULT_PARSER_SYMBOL_UNICODE_MATH;
        // -------------------------------------------------
        /**
         * Default String = "Percentage"
         */
        public String DIMENSIONLESS_UNIT_PERC = DEFAULT_DIMENSIONLESS_UNIT_PERC;
        /**
         * Default String = "Promil, Per mille"
         */
        public String DIMENSIONLESS_UNIT_PROMIL = DEFAULT_DIMENSIONLESS_UNIT_PROMIL;
        /**
         * Default String = "Septillion / Yotta"
         */
        public String DIMENSIONLESS_UNIT_YOTTA = DEFAULT_DIMENSIONLESS_UNIT_YOTTA;
        /**
         * Default String = "Sextillion / Zetta"
         */
        public String DIMENSIONLESS_UNIT_ZETTA = DEFAULT_DIMENSIONLESS_UNIT_ZETTA;
        /**
         * Default String = "Quintillion / Exa"
         */
        public String DIMENSIONLESS_UNIT_EXA = DEFAULT_DIMENSIONLESS_UNIT_EXA;
        /**
         * Default String = "Quadrillion / Peta"
         */
        public String DIMENSIONLESS_UNIT_PETA = DEFAULT_DIMENSIONLESS_UNIT_PETA;
        /**
         * Default String = "Trillion / Tera"
         */
        public String DIMENSIONLESS_UNIT_TERA = DEFAULT_DIMENSIONLESS_UNIT_TERA;
        /**
         * Default String = "Billion / Giga"
         */
        public String DIMENSIONLESS_UNIT_GIGA = DEFAULT_DIMENSIONLESS_UNIT_GIGA;
        /**
         * Default String = "Million / Mega"
         */
        public String DIMENSIONLESS_UNIT_MEGA = DEFAULT_DIMENSIONLESS_UNIT_MEGA;
        /**
         * Default String = "Thousand / Kilo"
         */
        public String DIMENSIONLESS_UNIT_KILO = DEFAULT_DIMENSIONLESS_UNIT_KILO;
        /**
         * Default String = "Hundred / Hecto"
         */
        public String DIMENSIONLESS_UNIT_HECTO = DEFAULT_DIMENSIONLESS_UNIT_HECTO;
        /**
         * Default String = "Ten / Deca"
         */
        public String DIMENSIONLESS_UNIT_DECA = DEFAULT_DIMENSIONLESS_UNIT_DECA;
        /**
         * Default String = "Tenth / Deci"
         */
        public String DIMENSIONLESS_UNIT_DECI = DEFAULT_DIMENSIONLESS_UNIT_DECI;
        /**
         * Default String = "Hundredth / Centi"
         */
        public String DIMENSIONLESS_UNIT_CENTI = DEFAULT_DIMENSIONLESS_UNIT_CENTI;
        /**
         * Default String = "Thousandth / Milli"
         */
        public String DIMENSIONLESS_UNIT_MILLI = DEFAULT_DIMENSIONLESS_UNIT_MILLI;
        /**
         * Default String = "Millionth / Micro"
         */
        public String DIMENSIONLESS_UNIT_MICRO = DEFAULT_DIMENSIONLESS_UNIT_MICRO;
        /**
         * Default String = "Billionth / Nano"
         */
        public String DIMENSIONLESS_UNIT_NANO = DEFAULT_DIMENSIONLESS_UNIT_NANO;
        /**
         * Default String = "Trillionth / Pico"
         */
        public String DIMENSIONLESS_UNIT_PICO = DEFAULT_DIMENSIONLESS_UNIT_PICO;
        /**
         * Default String = "Quadrillionth / Femto"
         */
        public String DIMENSIONLESS_UNIT_FEMTO = DEFAULT_DIMENSIONLESS_UNIT_FEMTO;
        /**
         * Default String = "Quintillionth / Atoo"
         */
        public String DIMENSIONLESS_UNIT_ATTO = DEFAULT_DIMENSIONLESS_UNIT_ATTO;
        /**
         * Default String = "Sextillionth / Zepto"
         */
        public String DIMENSIONLESS_UNIT_ZEPTO = DEFAULT_DIMENSIONLESS_UNIT_ZEPTO;
        /**
         * Default String = "Septillionth / Yocto"
         */
        public String DIMENSIONLESS_UNIT_YOCTO = DEFAULT_DIMENSIONLESS_UNIT_YOCTO;
        // -------------------------------------------------
        /**
         * Default String = "Meter"
         */
        public String UNIT_METRE = DEFAULT_UNIT_METRE;
        /**
         * Default String = "Kilometer"
         */
        public String UNIT_KILOMETRE = DEFAULT_UNIT_KILOMETRE;
        /**
         * Default String = "Centimeter"
         */
        public String UNIT_CENTIMETRE = DEFAULT_UNIT_CENTIMETRE;
        /**
         * Default String = "Millimeter"
         */
        public String UNIT_MILLIMETRE = DEFAULT_UNIT_MILLIMETRE;
        /**
         * Default String = "Inch"
         */
        public String UNIT_INCH = DEFAULT_UNIT_INCH;
        /**
         * Default String = "Yard"
         */
        public String UNIT_YARD = DEFAULT_UNIT_YARD;
        /**
         * Default String = "Feet"
         */
        public String UNIT_FEET = DEFAULT_UNIT_FEET;
        /**
         * Default String = "Mile"
         */
        public String UNIT_MILE = DEFAULT_UNIT_MILE;
        /**
         * Default String = "Nautical mile"
         */
        public String UNIT_NAUTICAL_MILE = DEFAULT_UNIT_NAUTICAL_MILE;
        /**
         * Default String = "Square meter"
         */
        public String UNIT_METRE2 = DEFAULT_UNIT_METRE2;
        /**
         * Default String = "Square centimeter"
         */
        public String UNIT_CENTIMETRE2 = DEFAULT_UNIT_CENTIMETRE2;
        /**
         * Default String = "Square millimeter"
         */
        public String UNIT_MILLIMETRE2 = DEFAULT_UNIT_MILLIMETRE2;
        /**
         * Default String = "Are"
         */
        public String UNIT_ARE = DEFAULT_UNIT_ARE;
        /**
         * Default String = "Hectare"
         */
        public String UNIT_HECTARE = DEFAULT_UNIT_HECTARE;
        /**
         * Default String = "Acre"
         */
        public String UNIT_ACRE = DEFAULT_UNIT_ACRE;
        /**
         * Default String = "Square kilometer"
         */
        public String UNIT_KILOMETRE2 = DEFAULT_UNIT_KILOMETRE2;
        /**
         * Default String = "Cubic millimeter"
         */
        public String UNIT_MILLIMETRE3 = DEFAULT_UNIT_MILLIMETRE3;
        /**
         * Default String = "Cubic centimeter"
         */
        public String UNIT_CENTIMETRE3 = DEFAULT_UNIT_CENTIMETRE3;
        /**
         * Default String = "Cubic meter"
         */
        public String UNIT_METRE3 = DEFAULT_UNIT_METRE3;
        /**
         * Default String = "Cubic kilometer"
         */
        public String UNIT_KILOMETRE3 = DEFAULT_UNIT_KILOMETRE3;
        /**
         * Default String = "Milliliter"
         */
        public String UNIT_MILLILITRE = DEFAULT_UNIT_MILLILITRE;
        /**
         * Default String = "Liter"
         */
        public String UNIT_LITRE = DEFAULT_UNIT_LITRE;
        /**
         * Default String = "Gallon"
         */
        public String UNIT_GALLON = DEFAULT_UNIT_GALLON;
        /**
         * Default String = "Pint"
         */
        public String UNIT_PINT = DEFAULT_UNIT_PINT;
        /**
         * Default String = "Second"
         */
        public String UNIT_SECOND = DEFAULT_UNIT_SECOND;
        /**
         * Default String = "Millisecond"
         */
        public String UNIT_MILLISECOND = DEFAULT_UNIT_MILLISECOND;
        /**
         * Default String = "Minute"
         */
        public String UNIT_MINUTE = DEFAULT_UNIT_MINUTE;
        /**
         * Default String = "Hour"
         */
        public String UNIT_HOUR = DEFAULT_UNIT_HOUR;
        /**
         * Default String = "Day"
         */
        public String UNIT_DAY = DEFAULT_UNIT_DAY;
        /**
         * Default String = "Week"
         */
        public String UNIT_WEEK = DEFAULT_UNIT_WEEK;
        /**
         * Default String = "Julian year = 365.25 days"
         */
        public String UNIT_JULIAN_YEAR = DEFAULT_UNIT_JULIAN_YEAR;
        /**
         * Default String = "Kilogram"
         */
        public String UNIT_KILOGRAM = DEFAULT_UNIT_KILOGRAM;
        /**
         * Default String = "Gram"
         */
        public String UNIT_GRAM = DEFAULT_UNIT_GRAM;
        /**
         * Default String = "Milligram"
         */
        public String UNIT_MILLIGRAM = DEFAULT_UNIT_MILLIGRAM;
        /**
         * Default String = "Decagram"
         */
        public String UNIT_DECAGRAM = DEFAULT_UNIT_DECAGRAM;
        /**
         * Default String = "Tonne"
         */
        public String UNIT_TONNE = DEFAULT_UNIT_TONNE;
        /**
         * Default String = "Ounce"
         */
        public String UNIT_OUNCE = DEFAULT_UNIT_OUNCE;
        /**
         * Default String = "Pound"
         */
        public String UNIT_POUND = DEFAULT_UNIT_POUND;
        /**
         * Default String = "Bit"
         */
        public String UNIT_BIT = DEFAULT_UNIT_BIT;
        /**
         * Default String = "Kilobit"
         */
        public String UNIT_KILOBIT = DEFAULT_UNIT_KILOBIT;
        /**
         * Default String = "Megabit"
         */
        public String UNIT_MEGABIT = DEFAULT_UNIT_MEGABIT;
        /**
         * Default String = "Gigabit"
         */
        public String UNIT_GIGABIT = DEFAULT_UNIT_GIGABIT;
        /**
         * Default String = "Terabit"
         */
        public String UNIT_TERABIT = DEFAULT_UNIT_TERABIT;
        /**
         * Default String = "Petabit"
         */
        public String UNIT_PETABIT = DEFAULT_UNIT_PETABIT;
        /**
         * Default String = "Exabit"
         */
        public String UNIT_EXABIT = DEFAULT_UNIT_EXABIT;
        /**
         * Default String = "Zettabit"
         */
        public String UNIT_ZETTABIT = DEFAULT_UNIT_ZETTABIT;
        /**
         * Default String = "Yottabit"
         */
        public String UNIT_YOTTABIT = DEFAULT_UNIT_YOTTABIT;
        /**
         * Default String = "Byte"
         */
        public String UNIT_BYTE = DEFAULT_UNIT_BYTE;
        /**
         * Default String = "Kilobyte"
         */
        public String UNIT_KILOBYTE = DEFAULT_UNIT_KILOBYTE;
        /**
         * Default String = "Megabyte"
         */
        public String UNIT_MEGABYTE = DEFAULT_UNIT_MEGABYTE;
        /**
         * Default String = "Gigabyte"
         */
        public String UNIT_GIGABYTE = DEFAULT_UNIT_GIGABYTE;
        /**
         * Default String = "Terabyte"
         */
        public String UNIT_TERABYTE = DEFAULT_UNIT_TERABYTE;
        /**
         * Default String = "Petabyte"
         */
        public String UNIT_PETABYTE = DEFAULT_UNIT_PETABYTE;
        /**
         * Default String = "Exabyte"
         */
        public String UNIT_EXABYTE = DEFAULT_UNIT_EXABYTE;
        /**
         * Default String = "Zettabyte"
         */
        public String UNIT_ZETTABYTE = DEFAULT_UNIT_ZETTABYTE;
        /**
         * Default String = "Yottabyte"
         */
        public String UNIT_YOTTABYTE = DEFAULT_UNIT_YOTTABYTE;
        /**
         * Default String = "Joule"
         */
        public String UNIT_JOULE = DEFAULT_UNIT_JOULE;
        /**
         * Default String = "Electronovolt"
         */
        public String UNIT_ELECTRONO_VOLT = DEFAULT_UNIT_ELECTRONO_VOLT;
        /**
         * Default String = "Kiloelectronovolt"
         */
        public String UNIT_KILO_ELECTRONO_VOLT = DEFAULT_UNIT_KILO_ELECTRONO_VOLT;
        /**
         * Default String = "Megaelectronovolt"
         */
        public String UNIT_MEGA_ELECTRONO_VOLT = DEFAULT_UNIT_MEGA_ELECTRONO_VOLT;
        /**
         * Default String = "Gigaelectronovolt"
         */
        public String UNIT_GIGA_ELECTRONO_VOLT = DEFAULT_UNIT_GIGA_ELECTRONO_VOLT;
        /**
         * Default String = "Teraelectronovolt"
         */
        public String UNIT_TERA_ELECTRONO_VOLT = DEFAULT_UNIT_TERA_ELECTRONO_VOLT;
        /**
         * Default String = "Meter per second"
         */
        public String UNIT_METRE_PER_SECOND = DEFAULT_UNIT_METRE_PER_SECOND;
        /**
         * Default String = "Kilometer per hour"
         */
        public String UNIT_KILOMETRE_PER_HOUR = DEFAULT_UNIT_KILOMETRE_PER_HOUR;
        /**
         * Default String = "Mile per hour"
         */
        public String UNIT_MILE_PER_HOUR = DEFAULT_UNIT_MILE_PER_HOUR;
        /**
         * Default String = "Knot"
         */
        public String UNIT_KNOT = DEFAULT_UNIT_KNOT;
        /**
         * Default String = "Meter per square second"
         */
        public String UNIT_METRE_PER_SECOND2 = DEFAULT_UNIT_METRE_PER_SECOND2;
        /**
         * Default String = "Kilometer per square hour"
         */
        public String UNIT_KILOMETRE_PER_HOUR2 = DEFAULT_UNIT_KILOMETRE_PER_HOUR2;
        /**
         * Default String = "Mile per square hour"
         */
        public String UNIT_MILE_PER_HOUR2 = DEFAULT_UNIT_MILE_PER_HOUR2;
        /**
         * Default String = "Radian"
         */
        public String UNIT_RADIAN_ARC = DEFAULT_UNIT_RADIAN_ARC;
        /**
         * Default String = "Degree of arc"
         */
        public String UNIT_DEGREE_ARC = DEFAULT_UNIT_DEGREE_ARC;
        /**
         * Default String = "Minute of arc"
         */
        public String UNIT_MINUTE_ARC = DEFAULT_UNIT_MINUTE_ARC;
        /**
         * Default String = "Second of arc"
         */
        public String UNIT_SECOND_ARC = DEFAULT_UNIT_SECOND_ARC;
    }
}