﻿#pragma checksum "..\..\..\..\View\Doctor\Prescription.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "B68BA232A2232A07338E32B893DDDE160F8D47A96831731FED1C5F82C55FFCE1"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using SIMSKT3.ValidationDoctor;
using SIMSKT3.View.Doctor;
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
    /// Prescription
    /// </summary>
    public partial class Prescription : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 33 "..\..\..\..\View\Doctor\Prescription.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Textbox3;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\..\View\Doctor\Prescription.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Textbox4;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\..\View\Doctor\Prescription.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cb_patients;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\..\View\Doctor\Prescription.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker datePicker;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\..\View\Doctor\Prescription.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lv_prescriptions;
        
        #line default
        #line hidden
        
        
        #line 85 "..\..\..\..\View\Doctor\Prescription.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cb_medicines;
        
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
            System.Uri resourceLocater = new System.Uri("/SIMSKT3;component/view/doctor/prescription.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\Doctor\Prescription.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
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
            
            #line 21 "..\..\..\..\View\Doctor\Prescription.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_BackToDr);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Textbox3 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.Textbox4 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            
            #line 49 "..\..\..\..\View\Doctor\Prescription.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_Clear);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 50 "..\..\..\..\View\Doctor\Prescription.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_AddPrescription);
            
            #line default
            #line hidden
            return;
            case 6:
            this.cb_patients = ((System.Windows.Controls.ComboBox)(target));
            
            #line 52 "..\..\..\..\View\Doctor\Prescription.xaml"
            this.cb_patients.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cb_patients_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.datePicker = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 8:
            this.lv_prescriptions = ((System.Windows.Controls.ListView)(target));
            
            #line 56 "..\..\..\..\View\Doctor\Prescription.xaml"
            this.lv_prescriptions.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.lv_prescriptions_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 83 "..\..\..\..\View\Doctor\Prescription.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.read_AllPrescriptions);
            
            #line default
            #line hidden
            return;
            case 10:
            this.cb_medicines = ((System.Windows.Controls.ComboBox)(target));
            
            #line 85 "..\..\..\..\View\Doctor\Prescription.xaml"
            this.cb_medicines.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cb_medicines_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 88 "..\..\..\..\View\Doctor\Prescription.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_UpdatePrescription);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

