﻿// 
// This source code was auto-generated by wsdl, Version=2.0.50727.3038.
// PF - this is a subset of the auto-generated code
// 

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Serialization;

[System.Web.Services.WebServiceBindingAttribute(Name = "djSoap", Namespace = "http://www.residentadvisor.net/")]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public class dj : System.Web.Services.Protocols.SoapHttpClientProtocol
{
    public dj()
    {
        this.Url = "https://www.residentadvisor.net/api/dj.asmx";
    }


    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.residentadvisor.net/getartist",
                                                                RequestNamespace = "http://www.residentadvisor.net/",
                                                                ResponseNamespace = "http://www.residentadvisor.net/",
                                                                Use = System.Web.Services.Description.SoapBindingUse.Literal,
                                                                ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    public System.Xml.XmlNode getartist(string UserID, string AccessKey, string DJID, string ArtistName, string URL)
    {
        object[] results = this.Invoke("getartist", new object[] {
                    UserID,
                    AccessKey,
                    DJID,
                    ArtistName,
                    URL});
        return ((System.Xml.XmlNode)(results[0]));
    }
}
