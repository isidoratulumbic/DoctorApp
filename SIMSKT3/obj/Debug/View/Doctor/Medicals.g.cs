﻿#pragma checksum "..\..\..\..\View\Doctor\Medicals.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "B676CCDC249A3A82FE1C883DD1CA045B52D99D122A891F14206E199D1C9BE8F6"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using SIMSKT3.Komande;
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


namespace SIMSKT3.View.Doctor {
    
    
    /// <summary>
    /// Medicals
    /// </summary>
    public partial class Medicals : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 24 "..\..\..\..\View\Doctor\Medicals.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lv_medicines;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\..\View\Doctor\Medicals.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Textbox1;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\..\View\Doctor\Medicals.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Textbox2;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\..\View\Doctor\Medicals.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Textbox3;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\..\View\Doctor\Medicals.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox status;
        
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
            System.Uri resourceLocater = new System.Uri("/SIMSKT3;component/view/doctor/medicals.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\Doctor\Medicals.xaml"
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
            
            #line 11 "..\..\..\..\View\Doctor\Medicals.xaml"
            ((System.Windows.Input.CommandBinding)(target)).CanExecute += new System.Windows.Input.CanExecuteRoutedEventHandler(this.UpdateMedication_CanExecute);
            
            #line default
            #line hidden
            
            #line 11 "..\..\..\..\View\Doctor\Medicals.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.UpdateMedication_Executed);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 12 "..\..\..\..\View\Doctor\Medicals.xaml"
            ((System.Windows.Input.CommandBinding)(target)).CanExecute += new System.Windows.Input.CanExecuteRoutedEventHandler(this.SeeAll_CanExecute);
            
            #line default
            #line hidden
            
            #line 12 "..\..\..\..\View\Doctor\Medicals.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.SeeAll_Executed);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 13 "..\..\..\..\View\Doctor\Medicals.xaml"
            ((System.Windows.Input.CommandBinding)(target)).CanExecute += new System.Windows.Input.CanExecuteRoutedEventHandler(this.Accept_CanExecute);
            
            #line default
            #line hidden
            
            #line 13 "..\..\..\..\View\Doctor\Medicals.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.Accept_Executed);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 14 "..\..\..\..\View\Doctor\Medicals.xaml"
            ((System.Windows.Input.CommandBinding)(target)).CanExecute += new System.Windows.Input.CanExecuteRoutedEventHandler(this.Decline_CanExecute);
            
            #line default
            #line hidden
            
            #line 14 "..\..\..\..\View\Doctor\Medicals.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.Decline_Executed);
            
            #line default
            #line hidden
            return;
            case 5:
            this.lv_medicines = ((System.Windows.Controls.ListView)(target));
            return;
            case 6:
            
            #line 35 "..\..\..\..\View\Doctor\Medicals.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_ClickBack);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 44 "..\..\..\..\View\Doctor\Medicals.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_ClickMedicines);
            
            #line default
            #line hidden
            return;
            case 8:
            this.Textbox1 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            
            #line 46 "..\..\..\..\View\Doctor\Medicals.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_Accept);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 48 "..\..\..\..\View\Doctor\Medicals.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_ClickCancelMedicine);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 49 "..\..\..\..\View\Doctor\Medicals.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_ClickUpdateMedicine);
            
            #line default
            #line hidden
            return;
            case 12:
            this.Textbox2 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 13:
            this.Textbox3 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 14:
            this.status = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

