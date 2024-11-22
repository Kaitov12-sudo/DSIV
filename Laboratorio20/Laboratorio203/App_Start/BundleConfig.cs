﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.UI;

namespace Laboratorio203
{
    public class BundleConfig
    {
        // Configuración de bundles
        public static void RegisterBundles(BundleCollection bundles)
        {
            // Configuración de jQuery en ScriptManager
            RegisterJQueryScriptManager();

            // Bundles para WebForms
            bundles.Add(new ScriptBundle("~/bundles/WebFormsJs").Include(
                            "~/Scripts/WebForms/WebForms.js",
                            "~/Scripts/WebForms/WebUIValidation.js",
                            "~/Scripts/WebForms/MenuStandards.js",
                            "~/Scripts/WebForms/Focus.js",
                            "~/Scripts/WebForms/GridView.js",
                            "~/Scripts/WebForms/DetailsView.js",
                            "~/Scripts/WebForms/TreeView.js",
                            "~/Scripts/WebForms/WebParts.js"));

            // Bundles para Microsoft Ajax
            bundles.Add(new ScriptBundle("~/bundles/MsAjaxJs").Include(
                            "~/Scripts/WebForms/MsAjax/MicrosoftAjax.js",
                            "~/Scripts/WebForms/MsAjax/MicrosoftAjaxApplicationServices.js",
                            "~/Scripts/WebForms/MsAjax/MicrosoftAjaxTimer.js",
                            "~/Scripts/WebForms/MsAjax/MicrosoftAjaxWebForms.js"));

            // Bundle para Modernizr
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                            "~/Scripts/modernizr-*"));

            // Bundle para Bootstrap
            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                            "~/Scripts/bootstrap.min.js"));

            // Bundle para estilos CSS
            bundles.Add(new StyleBundle("~/Content/css").Include(
                            "~/Content/bootstrap.css",
                            "~/Content/site.css"));
        }

        // Configuración de jQuery en ScriptManager
        public static void RegisterJQueryScriptManager()
        {
            ScriptManager.ScriptResourceMapping.AddDefinition("jquery",
                new ScriptResourceDefinition
                {
                    Path = "~/scripts/jquery-3.7.0.min.js",
                    DebugPath = "~/scripts/jquery-3.7.0.js",
                    CdnPath = "http://ajax.aspnetcdn.com/ajax/jQuery/jquery-3.7.0.min.js",
                    CdnDebugPath = "http://ajax.aspnetcdn.com/ajax/jQuery/jquery-3.7.0.js"
                });
        }
    }
}