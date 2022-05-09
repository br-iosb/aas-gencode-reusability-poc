/* 
 * DotAAS Part 2 | HTTP/REST | Entire Interface Collection
 *
 * The entire interface collection as part of Details of the Asset Administration Shell Part 2
 *
 * OpenAPI spec version: V1.0RC01
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = AAS.OpenApi.Client.Client.SwaggerDateConverter;

namespace AAS.OpenApi.Client.Model
{
    /// <summary>
    /// Defines ValueTypeEnum
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
        public enum ValueTypeEnum
    {
        /// <summary>
        /// Enum AnyUri for value: anyUri
        /// </summary>
        [EnumMember(Value = "anyUri")]
        AnyUri = 1,
        /// <summary>
        /// Enum Base64Binary for value: base64Binary
        /// </summary>
        [EnumMember(Value = "base64Binary")]
        Base64Binary = 2,
        /// <summary>
        /// Enum Boolean for value: boolean
        /// </summary>
        [EnumMember(Value = "boolean")]
        Boolean = 3,
        /// <summary>
        /// Enum Date for value: date
        /// </summary>
        [EnumMember(Value = "date")]
        Date = 4,
        /// <summary>
        /// Enum DateTime for value: dateTime
        /// </summary>
        [EnumMember(Value = "dateTime")]
        DateTime = 5,
        /// <summary>
        /// Enum DateTimeStamp for value: dateTimeStamp
        /// </summary>
        [EnumMember(Value = "dateTimeStamp")]
        DateTimeStamp = 6,
        /// <summary>
        /// Enum Decimal for value: decimal
        /// </summary>
        [EnumMember(Value = "decimal")]
        Decimal = 7,
        /// <summary>
        /// Enum Integer for value: integer
        /// </summary>
        [EnumMember(Value = "integer")]
        Integer = 8,
        /// <summary>
        /// Enum Long for value: long
        /// </summary>
        [EnumMember(Value = "long")]
        Long = 9,
        /// <summary>
        /// Enum Int for value: int
        /// </summary>
        [EnumMember(Value = "int")]
        Int = 10,
        /// <summary>
        /// Enum Short for value: short
        /// </summary>
        [EnumMember(Value = "short")]
        Short = 11,
        /// <summary>
        /// Enum Byte for value: byte
        /// </summary>
        [EnumMember(Value = "byte")]
        Byte = 12,
        /// <summary>
        /// Enum NonNegativeInteger for value: nonNegativeInteger
        /// </summary>
        [EnumMember(Value = "nonNegativeInteger")]
        NonNegativeInteger = 13,
        /// <summary>
        /// Enum PositiveInteger for value: positiveInteger
        /// </summary>
        [EnumMember(Value = "positiveInteger")]
        PositiveInteger = 14,
        /// <summary>
        /// Enum UnsignedLong for value: unsignedLong
        /// </summary>
        [EnumMember(Value = "unsignedLong")]
        UnsignedLong = 15,
        /// <summary>
        /// Enum UnsignedInt for value: unsignedInt
        /// </summary>
        [EnumMember(Value = "unsignedInt")]
        UnsignedInt = 16,
        /// <summary>
        /// Enum UnsignedShort for value: unsignedShort
        /// </summary>
        [EnumMember(Value = "unsignedShort")]
        UnsignedShort = 17,
        /// <summary>
        /// Enum UnsignedByte for value: unsignedByte
        /// </summary>
        [EnumMember(Value = "unsignedByte")]
        UnsignedByte = 18,
        /// <summary>
        /// Enum NonPositiveInteger for value: nonPositiveInteger
        /// </summary>
        [EnumMember(Value = "nonPositiveInteger")]
        NonPositiveInteger = 19,
        /// <summary>
        /// Enum NegativeInteger for value: negativeInteger
        /// </summary>
        [EnumMember(Value = "negativeInteger")]
        NegativeInteger = 20,
        /// <summary>
        /// Enum Double for value: double
        /// </summary>
        [EnumMember(Value = "double")]
        Double = 21,
        /// <summary>
        /// Enum Duration for value: duration
        /// </summary>
        [EnumMember(Value = "duration")]
        Duration = 22,
        /// <summary>
        /// Enum DayTimeDuration for value: dayTimeDuration
        /// </summary>
        [EnumMember(Value = "dayTimeDuration")]
        DayTimeDuration = 23,
        /// <summary>
        /// Enum YearMonthDuration for value: yearMonthDuration
        /// </summary>
        [EnumMember(Value = "yearMonthDuration")]
        YearMonthDuration = 24,
        /// <summary>
        /// Enum Float for value: float
        /// </summary>
        [EnumMember(Value = "float")]
        Float = 25,
        /// <summary>
        /// Enum GDay for value: gDay
        /// </summary>
        [EnumMember(Value = "gDay")]
        GDay = 26,
        /// <summary>
        /// Enum GMonth for value: gMonth
        /// </summary>
        [EnumMember(Value = "gMonth")]
        GMonth = 27,
        /// <summary>
        /// Enum GMonthDay for value: gMonthDay
        /// </summary>
        [EnumMember(Value = "gMonthDay")]
        GMonthDay = 28,
        /// <summary>
        /// Enum GYear for value: gYear
        /// </summary>
        [EnumMember(Value = "gYear")]
        GYear = 29,
        /// <summary>
        /// Enum GYearMonth for value: gYearMonth
        /// </summary>
        [EnumMember(Value = "gYearMonth")]
        GYearMonth = 30,
        /// <summary>
        /// Enum HexBinary for value: hexBinary
        /// </summary>
        [EnumMember(Value = "hexBinary")]
        HexBinary = 31,
        /// <summary>
        /// Enum NOTATION for value: NOTATION
        /// </summary>
        [EnumMember(Value = "NOTATION")]
        NOTATION = 32,
        /// <summary>
        /// Enum QName for value: QName
        /// </summary>
        [EnumMember(Value = "QName")]
        QName = 33,
        /// <summary>
        /// Enum String for value: string
        /// </summary>
        [EnumMember(Value = "string")]
        String = 34,
        /// <summary>
        /// Enum NormalizedString for value: normalizedString
        /// </summary>
        [EnumMember(Value = "normalizedString")]
        NormalizedString = 35,
        /// <summary>
        /// Enum Token for value: token
        /// </summary>
        [EnumMember(Value = "token")]
        Token = 36,
        /// <summary>
        /// Enum Language for value: language
        /// </summary>
        [EnumMember(Value = "language")]
        Language = 37,
        /// <summary>
        /// Enum Name for value: Name
        /// </summary>
        [EnumMember(Value = "Name")]
        Name = 38,
        /// <summary>
        /// Enum NCName for value: NCName
        /// </summary>
        [EnumMember(Value = "NCName")]
        NCName = 39,
        /// <summary>
        /// Enum ENTITY for value: ENTITY
        /// </summary>
        [EnumMember(Value = "ENTITY")]
        ENTITY = 40,
        /// <summary>
        /// Enum ID for value: ID
        /// </summary>
        [EnumMember(Value = "ID")]
        ID = 41,
        /// <summary>
        /// Enum IDREF for value: IDREF
        /// </summary>
        [EnumMember(Value = "IDREF")]
        IDREF = 42,
        /// <summary>
        /// Enum NMTOKEN for value: NMTOKEN
        /// </summary>
        [EnumMember(Value = "NMTOKEN")]
        NMTOKEN = 43,
        /// <summary>
        /// Enum Time for value: time
        /// </summary>
        [EnumMember(Value = "time")]
        Time = 44    }
}
