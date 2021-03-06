/*************************************************************************************************
  Required Notice: Copyright (C) EPPlus Software AB. 
  This software is licensed under PolyForm Noncommercial License 1.0.0 
  and may only be used for noncommercial purposes 
  https://polyformproject.org/licenses/noncommercial/1.0.0/

  A commercial license to use this software can be purchased at https://epplussoftware.com
 *************************************************************************************************
  Date               Author                       Change
 *************************************************************************************************
  01/27/2020         EPPlus Software AB       Initial release EPPlus 5
 *************************************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OfficeOpenXml.DataValidation.Formulas.Contracts;
using OfficeOpenXml.DataValidation.Formulas;
using System.Xml;
using OfficeOpenXml.DataValidation.Contracts;
using System.Runtime.CompilerServices;

namespace OfficeOpenXml.DataValidation
{
    /// <summary>
    /// Validation for times (<see cref="OfficeOpenXml.DataValidation.ExcelTime"/>).
    /// </summary>
    public class ExcelDataValidationTime : ExcelDataValidationWithFormula2<IExcelDataValidationFormulaTime>, IExcelDataValidationTime
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="worksheet"></param>
        /// <param name="uid">Uid of the data validation, format should be a Guid surrounded by curly braces.</param>
        /// <param name="address"></param>
        /// <param name="validationType"></param>
        internal ExcelDataValidationTime(ExcelWorksheet worksheet, string uid, string address, ExcelDataValidationType validationType)
            : base(worksheet, uid, address, validationType)
        {
            Formula = new ExcelDataValidationFormulaTime(NameSpaceManager, TopNode, GetFormula1Path(), uid);
            Formula2 = new ExcelDataValidationFormulaTime(NameSpaceManager, TopNode, GetFormula2Path(), uid);
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="worksheet"></param>
        /// <param name="uid">Uid of the data validation, format should be a Guid surrounded by curly braces.</param>
        /// <param name="address"></param>
        /// <param name="validationType"></param>
        /// <param name="itemElementNode"></param>
        internal ExcelDataValidationTime(ExcelWorksheet worksheet, string uid, string address, ExcelDataValidationType validationType, XmlNode itemElementNode)
            : base(worksheet, uid, address, validationType, itemElementNode)
        {
            Formula = new ExcelDataValidationFormulaTime(NameSpaceManager, TopNode, GetFormula1Path(), uid);
            Formula2 = new ExcelDataValidationFormulaTime(NameSpaceManager, TopNode, GetFormula2Path(), uid);
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="worksheet"></param>
        /// <param name="uid">Uid of the data validation, format should be a Guid surrounded by curly braces.</param>
        /// <param name="address"></param>
        /// <param name="validationType"></param>
        /// <param name="itemElementNode"></param>
        /// <param name="namespaceManager"></param>
        internal ExcelDataValidationTime(ExcelWorksheet worksheet, string uid, string address, ExcelDataValidationType validationType, XmlNode itemElementNode, XmlNamespaceManager namespaceManager)
            : base(worksheet, uid, address, validationType, itemElementNode, namespaceManager)
        {
            Formula = new ExcelDataValidationFormulaTime(NameSpaceManager, TopNode, GetFormula1Path(), uid);
            Formula2 = new ExcelDataValidationFormulaTime(NameSpaceManager, TopNode, GetFormula2Path(), uid);
        }
    }
}
