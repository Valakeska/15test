﻿#pragma checksum "..\..\..\AdminMenu\CRUDVisitingEvent.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "919D2B381E2B233A1CEC2820F07BB9415B1A5C2377C51D7687A465342E2C75C3"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using SocailNetSchool.AdminMenu;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace SocailNetSchool.AdminMenu {
    
    
    /// <summary>
    /// CRUDVisitingEvent
    /// </summary>
    public partial class CRUDVisitingEvent : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\AdminMenu\CRUDVisitingEvent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DGadmin;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\AdminMenu\CRUDVisitingEvent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CBUser;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\AdminMenu\CRUDVisitingEvent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CBEvent;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/SocailNetSchool;component/adminmenu/crudvisitingevent.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\AdminMenu\CRUDVisitingEvent.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.DGadmin = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 2:
            
            #line 11 "..\..\..\AdminMenu\CRUDVisitingEvent.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AddDataDGbtn);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 12 "..\..\..\AdminMenu\CRUDVisitingEvent.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.UpdateDataDGbtn);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 13 "..\..\..\AdminMenu\CRUDVisitingEvent.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.DeleteDataDGbtn);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 14 "..\..\..\AdminMenu\CRUDVisitingEvent.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ExitBTN);
            
            #line default
            #line hidden
            return;
            case 6:
            this.CBUser = ((System.Windows.Controls.ComboBox)(target));
            
            #line 18 "..\..\..\AdminMenu\CRUDVisitingEvent.xaml"
            this.CBUser.Loaded += new System.Windows.RoutedEventHandler(this.CBUser_Loaded);
            
            #line default
            #line hidden
            return;
            case 7:
            this.CBEvent = ((System.Windows.Controls.ComboBox)(target));
            
            #line 20 "..\..\..\AdminMenu\CRUDVisitingEvent.xaml"
            this.CBEvent.Loaded += new System.Windows.RoutedEventHandler(this.CBEvent_Loaded);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

