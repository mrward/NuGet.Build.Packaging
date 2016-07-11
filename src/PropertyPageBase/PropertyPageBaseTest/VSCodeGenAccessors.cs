﻿// ------------------------------------------------------------------------------
//<autogenerated>
//        This code was generated by Microsoft Visual Studio Team System 2005.
//
//        Changes to this file may cause incorrect behavior and will be lost if
//        the code is regenerated.
//</autogenerated>
//------------------------------------------------------------------------------
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PropertyPageBaseTest
{
[System.Diagnostics.DebuggerStepThrough()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TestTools.UnitTestGeneration", "1.0.0.0")]
internal class BaseAccessor {
    
    protected Microsoft.VisualStudio.TestTools.UnitTesting.PrivateObject m_privateObject;
    
    protected BaseAccessor(object target, Microsoft.VisualStudio.TestTools.UnitTesting.PrivateType type) {
        m_privateObject = new Microsoft.VisualStudio.TestTools.UnitTesting.PrivateObject(target, type);
    }
    
    protected BaseAccessor(Microsoft.VisualStudio.TestTools.UnitTesting.PrivateType type) : 
            this(null, type) {
    }
    
    internal virtual object Target {
        get {
            return m_privateObject.Target;
        }
    }
    
    public override string ToString() {
        return this.Target.ToString();
    }
    
    public override bool Equals(object obj) {
        if (typeof(BaseAccessor).IsInstanceOfType(obj)) {
            obj = ((BaseAccessor)(obj)).Target;
        }
        return this.Target.Equals(obj);
    }
    
    public override int GetHashCode() {
        return this.Target.GetHashCode();
    }
}
[System.Diagnostics.DebuggerStepThrough()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TestTools.UnitTestGeneration", "1.0.0.0")]
internal class PropertyPageBase_PropertyControlMapAccessor : BaseAccessor {
    
    protected static Microsoft.VisualStudio.TestTools.UnitTesting.PrivateType m_privateType = new Microsoft.VisualStudio.TestTools.UnitTesting.PrivateType(typeof(global::PropertyPageBase.PropertyControlMap));
    
    internal PropertyPageBase_PropertyControlMapAccessor(global::PropertyPageBase.PropertyControlMap target) : 
            base(target, m_privateType) {
    }
    
    internal global::PropertyPageBase.IPageViewSite m_pageViewSite {
        get {
            global::PropertyPageBase.IPageViewSite ret = ((global::PropertyPageBase.IPageViewSite)(m_privateObject.GetField("m_pageViewSite")));
            return ret;
        }
        set {
            m_privateObject.SetField("m_pageViewSite", value);
        }
    }
    
    internal global::PropertyPageBase.PropertyControlTable m_propertyControlTable {
        get {
            global::PropertyPageBase.PropertyControlTable ret = ((global::PropertyPageBase.PropertyControlTable)(m_privateObject.GetField("m_propertyControlTable")));
            return ret;
        }
        set {
            m_privateObject.SetField("m_propertyControlTable", value);
        }
    }
    
    internal global::PropertyPageBase.IPropertyPageUI m_propertyPageUI {
        get {
            global::PropertyPageBase.IPropertyPageUI ret = ((global::PropertyPageBase.IPropertyPageUI)(m_privateObject.GetField("m_propertyPageUI")));
            return ret;
        }
        set {
            m_privateObject.SetField("m_propertyPageUI", value);
        }
    }
}
[System.Diagnostics.DebuggerStepThrough()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TestTools.UnitTestGeneration", "1.0.0.0")]
internal class PropertyPageBase_PageViewAccessor : BaseAccessor {
    
    protected static Microsoft.VisualStudio.TestTools.UnitTesting.PrivateType m_privateType = new Microsoft.VisualStudio.TestTools.UnitTesting.PrivateType(typeof(global::PropertyPageBase.PageView));
    
    internal PropertyPageBase_PageViewAccessor(global::PropertyPageBase.PageView target) : 
            base(target, m_privateType) {
    }
    
    internal global::PropertyPageBase.PropertyControlMap m_propertyControlMap {
        get {
            global::PropertyPageBase.PropertyControlMap ret = ((global::PropertyPageBase.PropertyControlMap)(m_privateObject.GetField("m_propertyControlMap")));
            return ret;
        }
        set {
            m_privateObject.SetField("m_propertyControlMap", value);
        }
    }
}
[System.Diagnostics.DebuggerStepThrough()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TestTools.UnitTestGeneration", "1.0.0.0")]
internal class PropertyPageBase_PropertyStoreAccessor : BaseAccessor {
    
    protected static Microsoft.VisualStudio.TestTools.UnitTesting.PrivateType m_privateType = new Microsoft.VisualStudio.TestTools.UnitTesting.PrivateType(typeof(global::PropertyPageBase.PropertyStore));
    
    internal PropertyPageBase_PropertyStoreAccessor(global::PropertyPageBase.PropertyStore target) : 
            base(target, m_privateType) {
    }
    
    internal global::EnvDTE.Project m_dteProject {
        get {
            global::EnvDTE.Project ret = ((global::EnvDTE.Project)(m_privateObject.GetField("m_dteProject")));
            return ret;
        }
        set {
            m_privateObject.SetField("m_dteProject", value);
        }
    }
    
    internal global::EnvDTE.Properties m_propertiesToUse {
        get {
            global::EnvDTE.Properties ret = ((global::EnvDTE.Properties)(m_privateObject.GetField("m_propertiesToUse")));
            return ret;
        }
        set {
            m_privateObject.SetField("m_propertiesToUse", value);
        }
    }
}
}
