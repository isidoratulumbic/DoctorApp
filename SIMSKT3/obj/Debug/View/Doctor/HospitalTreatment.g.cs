﻿#pragma checksum "..\..\..\..\View\Doctor\HospitalTreatment.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "299C7A8CE3FFDABD6DC7AEFACA149B274776D04E505467A8C6D36EEE48C8F0CD"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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
    /// HospitalTreatment
    /// </summary>
    public partial class HospitalTreatment : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\..\..\View\Doctor\HospitalTreatment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lv_finishedAppointments;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\..\View\Doctor\HospitalTreatment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Textbox1;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\..\View\Doctor\HospitalTreatment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker start;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\..\View\Doctor\HospitalTreatment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker end;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\..\View\Doctor\HospitalTreatment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cb_rooms;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\..\..\View\Doctor\HospitalTreatment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lv_treatments;
        
        #line default
        #line hidden
        
        
        #line 89 "..\..\..\..\View\Doctor\HospitalTreatment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox id;
        
        #line default
        #line hidden
        
        
        #line 139 "..\..\..\..\View\Doctor\HospitalTreatment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lv_beds;
        
        #line default
        #line hidden
        
        
        #line 147 "..\..\..\..\View\Doctor\HospitalTreatment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox bed;
        
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
            System.Uri resourceLocater = new System.Uri("/SIMSKT3;component/view/doctor/hospitaltreatment.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\Doctor\HospitalTreatment.xaml"
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
            
            #line 11 "..\..\..\..\View\Doctor\HospitalTreatment.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_Clear);
            
            #line default
            #line hidden
            return;
            case 2:
            this.lv_finishedAppointments = ((System.Windows.Controls.ListView)(target));
            
            #line 13 "..\..\..\..\View\Doctor\HospitalTreatment.xaml"
            this.lv_finishedAppointments.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ListView_SelectionChangedEO);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 25 "..\..\..\..\View\Doctor\HospitalTreatment.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_finishedAppointments);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Textbox1 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.start = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 6:
            this.end = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 7:
            this.cb_rooms = ((System.Windows.Controls.ComboBox)(target));
            
            #line 51 "..\..\..\..\View\Doctor\HospitalTreatment.xaml"
            this.cb_rooms.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComboBox_SelectionChangedRooms);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 67 "..\..\..\..\View\Doctor\HospitalTreatment.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_AddTreatment);
            
            #line default
            #line hidden
            return;
            case 9:
            this.lv_treatments = ((System.Windows.Controls.ListView)(target));
            
            #line 68 "..\..\..\..\View\Doctor\HospitalTreatment.xaml"
            this.lv_treatments.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ListView_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 80 "..\..\..\..\View\Doctor\HospitalTreatment.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_ClickBack);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 87 "..\..\..\..\View\Doctor\HospitalTreatment.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_readAllTreatments);
            
            #line default
            #line hidden
            return;
            case 12:
            this.id = ((System.Windows.Controls.TextBox)(target));
            return;
            case 13:
            
            #line 90 "..\..\..\..\View\Doctor\HospitalTreatment.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_ExtendTreatment);
            
            #line default
            #line hidden
            return;
            case 14:
            this.lv_beds = ((System.Windows.Controls.ListView)(target));
            
            #line 139 "..\..\..\..\View\Doctor\HospitalTreatment.xaml"
            this.lv_beds.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.lv_beds_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 15:
            this.bed = ((System.Windows.Controls.TextBox)(target));
            return;
            case 16:
            
            #line 148 "..\..\..\..\View\Doctor\HospitalTreatment.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_ClickBeds);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

