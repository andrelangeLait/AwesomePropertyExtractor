﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:v4.0.30319
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//---
using System;
using APE.Umbraco;
namespace APE.Umbraco.App.Classes.Cms
{
    public partial class UmbNewsArticle 
    {

		public UmbNewsArticle()		
		{
			this.Introduction = new StringProperty(){ Alias = "introduction" };
			this.BodyText = new StringProperty(){ Alias = "bodyText" };
				
		}

		public readonly string DocTypeAlias = "umbNewsArticle";

		public static implicit operator string(UmbNewsArticle doctype)
		{
			return "umbNewsArticle";
		}
	 		
				
		/// <summary>
		///		<para>Datatype: Textbox multiple</para>
		/// </summary>
		public StringProperty Introduction { get; private set; }		
				
		/// <summary>
		///		<para>Datatype: Richtext editor</para>
		/// </summary>
		public StringProperty BodyText { get; private set; }
	}
}