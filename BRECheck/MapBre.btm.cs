namespace BRECheck {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BRECheck.InputBre", typeof(global::BRECheck.InputBre))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BRECheck.OutputBre", typeof(global::BRECheck.OutputBre))]
    public sealed class MapBre : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:s0=""http://BRECheck.InputBre"" xmlns:ns0=""http://BRECheck.OutputBre"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:Root"" />
  </xsl:template>
  <xsl:template match=""/s0:Root"">
    <xsl:variable name=""var:v1"" select=""userCSharp:StringConcat(string(FirstName/text()) , string(Surname/text()))"" />
    <xsl:variable name=""var:v2"" select=""userCSharp:DateCurrentDate()"" />
    <ns0:Root>
      <FullName>
        <xsl:value-of select=""$var:v1"" />
      </FullName>
      <Date>
        <xsl:value-of select=""$var:v2"" />
      </Date>
      <Age>
        <xsl:value-of select=""Age/text()"" />
      </Age>
    </ns0:Root>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string DateCurrentDate()
{
	DateTime dt = DateTime.Now;
	return dt.ToString(""yyyy-MM-dd"", System.Globalization.CultureInfo.InvariantCulture);
}


public string StringConcat(string param0, string param1)
{
   return param0 + param1;
}



]]></msxsl:script>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"BRECheck.InputBre";
        
        private const global::BRECheck.InputBre _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"BRECheck.OutputBre";
        
        private const global::BRECheck.OutputBre _trgSchemaTypeReference0 = null;
        
        public override string XmlContent {
            get {
                return _strMap;
            }
        }
        
        public override int UseXSLTransform {
            get {
                return _useXSLTransform;
            }
        }
        
        public override string XsltArgumentListContent {
            get {
                return _strArgList;
            }
        }
        
        public override string[] SourceSchemas {
            get {
                string[] _SrcSchemas = new string [1];
                _SrcSchemas[0] = @"BRECheck.InputBre";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"BRECheck.OutputBre";
                return _TrgSchemas;
            }
        }
    }
}
