﻿#pragma checksum "..\..\ChoseUser.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1463E2F5383A8E966A8BFD02A1AD2294C27A951DA4FC2AE63BA1BFA06A067C8E"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

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
using уП2V1;


namespace уП2V1 {
    
    
    /// <summary>
    /// ChoseUser
    /// </summary>
    public partial class ChoseUser : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 61 "..\..\ChoseUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ОткрытьБазуДанных;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\ChoseUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Печать;
        
        #line default
        #line hidden
        
        
        #line 93 "..\..\ChoseUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DataBase;
        
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
            System.Uri resourceLocater = new System.Uri("/уП2V1;component/choseuser.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ChoseUser.xaml"
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
            this.ОткрытьБазуДанных = ((System.Windows.Controls.Button)(target));
            
            #line 61 "..\..\ChoseUser.xaml"
            this.ОткрытьБазуДанных.Click += new System.Windows.RoutedEventHandler(this.ОткрытьБазуДанных_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Печать = ((System.Windows.Controls.Button)(target));
            
            #line 78 "..\..\ChoseUser.xaml"
            this.Печать.Click += new System.Windows.RoutedEventHandler(this.Печать_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.DataBase = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

