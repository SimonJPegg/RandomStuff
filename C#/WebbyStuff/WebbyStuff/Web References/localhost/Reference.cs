﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.1.
// 
#pragma warning disable 1591

namespace WebbyStuff.localhost {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.ComponentModel;
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="EmployeesSoap", Namespace="http://tempuri.org/")]
    public partial class Employees : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback getAllEmployeesOperationCompleted;
        
        private System.Threading.SendOrPostCallback getAllManagersOperationCompleted;
        
        private System.Threading.SendOrPostCallback getAllSalesOperationCompleted;
        
        private System.Threading.SendOrPostCallback getEmployeesByDeptOperationCompleted;
        
        private System.Threading.SendOrPostCallback getEmployeesByIDOperationCompleted;
        
        private System.Threading.SendOrPostCallback AddEmployeeOperationCompleted;
        
        private System.Threading.SendOrPostCallback AddManagerOperationCompleted;
        
        private System.Threading.SendOrPostCallback AddSalesEmpOperationCompleted;
        
        private System.Threading.SendOrPostCallback getDepartmentsOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public Employees() {
            this.Url = global::WebbyStuff.Properties.Settings.Default.WebbyStuff_localhost_Employees;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event getAllEmployeesCompletedEventHandler getAllEmployeesCompleted;
        
        /// <remarks/>
        public event getAllManagersCompletedEventHandler getAllManagersCompleted;
        
        /// <remarks/>
        public event getAllSalesCompletedEventHandler getAllSalesCompleted;
        
        /// <remarks/>
        public event getEmployeesByDeptCompletedEventHandler getEmployeesByDeptCompleted;
        
        /// <remarks/>
        public event getEmployeesByIDCompletedEventHandler getEmployeesByIDCompleted;
        
        /// <remarks/>
        public event AddEmployeeCompletedEventHandler AddEmployeeCompleted;
        
        /// <remarks/>
        public event AddManagerCompletedEventHandler AddManagerCompleted;
        
        /// <remarks/>
        public event AddSalesEmpCompletedEventHandler AddSalesEmpCompleted;
        
        /// <remarks/>
        public event getDepartmentsCompletedEventHandler getDepartmentsCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/getAllEmployees", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Employee[] getAllEmployees() {
            object[] results = this.Invoke("getAllEmployees", new object[0]);
            return ((Employee[])(results[0]));
        }
        
        /// <remarks/>
        public void getAllEmployeesAsync() {
            this.getAllEmployeesAsync(null);
        }
        
        /// <remarks/>
        public void getAllEmployeesAsync(object userState) {
            if ((this.getAllEmployeesOperationCompleted == null)) {
                this.getAllEmployeesOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetAllEmployeesOperationCompleted);
            }
            this.InvokeAsync("getAllEmployees", new object[0], this.getAllEmployeesOperationCompleted, userState);
        }
        
        private void OngetAllEmployeesOperationCompleted(object arg) {
            if ((this.getAllEmployeesCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getAllEmployeesCompleted(this, new getAllEmployeesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/getAllManagers", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Manager[] getAllManagers() {
            object[] results = this.Invoke("getAllManagers", new object[0]);
            return ((Manager[])(results[0]));
        }
        
        /// <remarks/>
        public void getAllManagersAsync() {
            this.getAllManagersAsync(null);
        }
        
        /// <remarks/>
        public void getAllManagersAsync(object userState) {
            if ((this.getAllManagersOperationCompleted == null)) {
                this.getAllManagersOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetAllManagersOperationCompleted);
            }
            this.InvokeAsync("getAllManagers", new object[0], this.getAllManagersOperationCompleted, userState);
        }
        
        private void OngetAllManagersOperationCompleted(object arg) {
            if ((this.getAllManagersCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getAllManagersCompleted(this, new getAllManagersCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/getAllSales", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public SalesEmployee[] getAllSales() {
            object[] results = this.Invoke("getAllSales", new object[0]);
            return ((SalesEmployee[])(results[0]));
        }
        
        /// <remarks/>
        public void getAllSalesAsync() {
            this.getAllSalesAsync(null);
        }
        
        /// <remarks/>
        public void getAllSalesAsync(object userState) {
            if ((this.getAllSalesOperationCompleted == null)) {
                this.getAllSalesOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetAllSalesOperationCompleted);
            }
            this.InvokeAsync("getAllSales", new object[0], this.getAllSalesOperationCompleted, userState);
        }
        
        private void OngetAllSalesOperationCompleted(object arg) {
            if ((this.getAllSalesCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getAllSalesCompleted(this, new getAllSalesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/getEmployeesByDept", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Employee[] getEmployeesByDept(string dept) {
            object[] results = this.Invoke("getEmployeesByDept", new object[] {
                        dept});
            return ((Employee[])(results[0]));
        }
        
        /// <remarks/>
        public void getEmployeesByDeptAsync(string dept) {
            this.getEmployeesByDeptAsync(dept, null);
        }
        
        /// <remarks/>
        public void getEmployeesByDeptAsync(string dept, object userState) {
            if ((this.getEmployeesByDeptOperationCompleted == null)) {
                this.getEmployeesByDeptOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetEmployeesByDeptOperationCompleted);
            }
            this.InvokeAsync("getEmployeesByDept", new object[] {
                        dept}, this.getEmployeesByDeptOperationCompleted, userState);
        }
        
        private void OngetEmployeesByDeptOperationCompleted(object arg) {
            if ((this.getEmployeesByDeptCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getEmployeesByDeptCompleted(this, new getEmployeesByDeptCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/getEmployeesByID", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Employee getEmployeesByID(int ID) {
            object[] results = this.Invoke("getEmployeesByID", new object[] {
                        ID});
            return ((Employee)(results[0]));
        }
        
        /// <remarks/>
        public void getEmployeesByIDAsync(int ID) {
            this.getEmployeesByIDAsync(ID, null);
        }
        
        /// <remarks/>
        public void getEmployeesByIDAsync(int ID, object userState) {
            if ((this.getEmployeesByIDOperationCompleted == null)) {
                this.getEmployeesByIDOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetEmployeesByIDOperationCompleted);
            }
            this.InvokeAsync("getEmployeesByID", new object[] {
                        ID}, this.getEmployeesByIDOperationCompleted, userState);
        }
        
        private void OngetEmployeesByIDOperationCompleted(object arg) {
            if ((this.getEmployeesByIDCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getEmployeesByIDCompleted(this, new getEmployeesByIDCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/AddEmployee", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public int AddEmployee(string Name, double Salary, string Dept) {
            object[] results = this.Invoke("AddEmployee", new object[] {
                        Name,
                        Salary,
                        Dept});
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public void AddEmployeeAsync(string Name, double Salary, string Dept) {
            this.AddEmployeeAsync(Name, Salary, Dept, null);
        }
        
        /// <remarks/>
        public void AddEmployeeAsync(string Name, double Salary, string Dept, object userState) {
            if ((this.AddEmployeeOperationCompleted == null)) {
                this.AddEmployeeOperationCompleted = new System.Threading.SendOrPostCallback(this.OnAddEmployeeOperationCompleted);
            }
            this.InvokeAsync("AddEmployee", new object[] {
                        Name,
                        Salary,
                        Dept}, this.AddEmployeeOperationCompleted, userState);
        }
        
        private void OnAddEmployeeOperationCompleted(object arg) {
            if ((this.AddEmployeeCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.AddEmployeeCompleted(this, new AddEmployeeCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/AddManager", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void AddManager(int ID, int Reports, double BonPerRept) {
            this.Invoke("AddManager", new object[] {
                        ID,
                        Reports,
                        BonPerRept});
        }
        
        /// <remarks/>
        public void AddManagerAsync(int ID, int Reports, double BonPerRept) {
            this.AddManagerAsync(ID, Reports, BonPerRept, null);
        }
        
        /// <remarks/>
        public void AddManagerAsync(int ID, int Reports, double BonPerRept, object userState) {
            if ((this.AddManagerOperationCompleted == null)) {
                this.AddManagerOperationCompleted = new System.Threading.SendOrPostCallback(this.OnAddManagerOperationCompleted);
            }
            this.InvokeAsync("AddManager", new object[] {
                        ID,
                        Reports,
                        BonPerRept}, this.AddManagerOperationCompleted, userState);
        }
        
        private void OnAddManagerOperationCompleted(object arg) {
            if ((this.AddManagerCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.AddManagerCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/AddSalesEmp", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void AddSalesEmp(int ID, double Comission, double ComissionRate, int numSales) {
            this.Invoke("AddSalesEmp", new object[] {
                        ID,
                        Comission,
                        ComissionRate,
                        numSales});
        }
        
        /// <remarks/>
        public void AddSalesEmpAsync(int ID, double Comission, double ComissionRate, int numSales) {
            this.AddSalesEmpAsync(ID, Comission, ComissionRate, numSales, null);
        }
        
        /// <remarks/>
        public void AddSalesEmpAsync(int ID, double Comission, double ComissionRate, int numSales, object userState) {
            if ((this.AddSalesEmpOperationCompleted == null)) {
                this.AddSalesEmpOperationCompleted = new System.Threading.SendOrPostCallback(this.OnAddSalesEmpOperationCompleted);
            }
            this.InvokeAsync("AddSalesEmp", new object[] {
                        ID,
                        Comission,
                        ComissionRate,
                        numSales}, this.AddSalesEmpOperationCompleted, userState);
        }
        
        private void OnAddSalesEmpOperationCompleted(object arg) {
            if ((this.AddSalesEmpCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.AddSalesEmpCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/getDepartments", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string[] getDepartments() {
            object[] results = this.Invoke("getDepartments", new object[0]);
            return ((string[])(results[0]));
        }
        
        /// <remarks/>
        public void getDepartmentsAsync() {
            this.getDepartmentsAsync(null);
        }
        
        /// <remarks/>
        public void getDepartmentsAsync(object userState) {
            if ((this.getDepartmentsOperationCompleted == null)) {
                this.getDepartmentsOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetDepartmentsOperationCompleted);
            }
            this.InvokeAsync("getDepartments", new object[0], this.getDepartmentsOperationCompleted, userState);
        }
        
        private void OngetDepartmentsOperationCompleted(object arg) {
            if ((this.getDepartmentsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getDepartmentsCompleted(this, new getDepartmentsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SalesEmployee))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Manager))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Employee {
        
        private int numberField;
        
        private double salaryField;
        
        private string departmentField;
        
        private string nameField;
        
        /// <remarks/>
        public int Number {
            get {
                return this.numberField;
            }
            set {
                this.numberField = value;
            }
        }
        
        /// <remarks/>
        public double Salary {
            get {
                return this.salaryField;
            }
            set {
                this.salaryField = value;
            }
        }
        
        /// <remarks/>
        public string Department {
            get {
                return this.departmentField;
            }
            set {
                this.departmentField = value;
            }
        }
        
        /// <remarks/>
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class SalesEmployee : Employee {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Manager : Employee {
        
        private int reportsField;
        
        private double bonusPerReportField;
        
        /// <remarks/>
        public int Reports {
            get {
                return this.reportsField;
            }
            set {
                this.reportsField = value;
            }
        }
        
        /// <remarks/>
        public double BonusPerReport {
            get {
                return this.bonusPerReportField;
            }
            set {
                this.bonusPerReportField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void getAllEmployeesCompletedEventHandler(object sender, getAllEmployeesCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getAllEmployeesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getAllEmployeesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Employee[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Employee[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void getAllManagersCompletedEventHandler(object sender, getAllManagersCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getAllManagersCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getAllManagersCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Manager[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Manager[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void getAllSalesCompletedEventHandler(object sender, getAllSalesCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getAllSalesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getAllSalesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public SalesEmployee[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((SalesEmployee[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void getEmployeesByDeptCompletedEventHandler(object sender, getEmployeesByDeptCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getEmployeesByDeptCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getEmployeesByDeptCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Employee[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Employee[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void getEmployeesByIDCompletedEventHandler(object sender, getEmployeesByIDCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getEmployeesByIDCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getEmployeesByIDCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Employee Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Employee)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void AddEmployeeCompletedEventHandler(object sender, AddEmployeeCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AddEmployeeCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal AddEmployeeCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public int Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void AddManagerCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void AddSalesEmpCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void getDepartmentsCompletedEventHandler(object sender, getDepartmentsCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getDepartmentsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getDepartmentsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string[])(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591