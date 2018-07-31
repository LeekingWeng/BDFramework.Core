using System;
using System.Collections.Generic;
using System.Reflection;

namespace ILRuntime.Runtime.Generated
{
    class CLRBindings
    {


        /// <summary>
        /// Initialize the CLR binding, please invoke this AFTER CLR Redirection registration
        /// </summary>
        public static void Initialize(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            System_String_Binding.Register(app);
            BDebug_Binding.Register(app);
            System_Collections_Generic_List_1_Type_Binding.Register(app);
            BResources_Binding.Register(app);
            System_Reflection_Assembly_Binding.Register(app);
            System_Linq_Enumerable_Binding.Register(app);
            System_Reflection_AssemblyName_Binding.Register(app);
            System_AppDomain_Binding.Register(app);
            System_Collections_Generic_List_1_Assembly_Binding.Register(app);
            BDFramework_ILRuntimeHelper_Binding.Register(app);
            ILRuntime_Runtime_Enviorment_AppDomain_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_String_IType_Binding.Register(app);
            System_Collections_Generic_List_1_IType_Binding.Register(app);
            System_Collections_Generic_List_1_IType_Binding_Enumerator_Binding.Register(app);
            ILRuntime_CLR_TypeSystem_IType_Binding.Register(app);
            System_IDisposable_Binding.Register(app);
            System_Collections_Generic_List_1_ILTypeInstance_Binding.Register(app);
            System_Collections_Generic_List_1_Type_Binding_Enumerator_Binding.Register(app);
            System_Type_Binding.Register(app);
            System_Reflection_PropertyInfo_Binding.Register(app);
            System_Activator_Binding.Register(app);
            System_Exception_Binding.Register(app);
            UnityEngine_Debug_Binding.Register(app);
            System_Collections_Generic_List_1_ILTypeInstance_Binding_Enumerator_Binding.Register(app);
            BDLauncher_Binding.Register(app);
            UnityEngine_Application_Binding.Register(app);
            System_IO_Path_Binding.Register(app);
            SQLite4Unity3d_SQLiteConnection_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_String_ILTypeInstance_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_String_ILTypeInstance_Binding_Enumerator_Binding.Register(app);
            System_Collections_Generic_KeyValuePair_2_String_ILTypeInstance_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_String_ILTypeInstance_Binding_ValueCollection_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_String_ILTypeInstance_Binding_ValueCollection_Binding_Enumerator_Binding.Register(app);
            System_Object_Binding.Register(app);
            IEnumeratorTool_Binding.Register(app);
            System_Collections_Generic_List_1_Int32_Binding.Register(app);
            System_Collections_Generic_List_1_Int32_Binding_Enumerator_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_String_Action_1_Object_Binding.Register(app);
            UnityEngine_Object_Binding.Register(app);
            UnityEngine_GameObject_Binding.Register(app);
            UnityEngine_Component_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_String_Object_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_String_Object_Binding_KeyCollection_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_String_Object_Binding_KeyCollection_Binding_Enumerator_Binding.Register(app);
            System_Action_1_Object_Binding.Register(app);
            System_Action_Binding.Register(app);
            System_Int32_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_Int32_ILTypeInstance_Binding.Register(app);
            System_Diagnostics_Stopwatch_Binding.Register(app);
            UnityEngine_Transform_Binding.Register(app);
            System_Action_2_Int32_Int32_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_Int32_List_1_ILTypeInstance_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_Int32_ILTypeInstance_Binding_ValueCollection_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_Int32_ILTypeInstance_Binding_ValueCollection_Binding_Enumerator_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_Int32_ILTypeInstance_Binding_Enumerator_Binding.Register(app);
            System_Collections_Generic_KeyValuePair_2_Int32_ILTypeInstance_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_Transform_Dictionary_2_String_ILTypeInstance_Binding.Register(app);
            System_Reflection_MemberInfo_Binding.Register(app);
            System_Reflection_FieldInfo_Binding.Register(app);
            System_Collections_Generic_List_1_UITool_Attribute_Binding.Register(app);
            System_Collections_Generic_List_1_Object_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_Int32_Object_Binding.Register(app);
            UITool_Attribute_Binding.Register(app);
            UnityEngine_WaitForSecondsRealtime_Binding.Register(app);
            System_Collections_Generic_List_1_Transform_Binding.Register(app);
            System_Collections_Generic_List_1_Transform_Binding_Enumerator_Binding.Register(app);
            System_NotSupportedException_Binding.Register(app);
            UnityEngine_UI_Text_Binding.Register(app);
            UnityEngine_UI_Image_Binding.Register(app);
            UnityEngine_UI_Slider_Binding.Register(app);
            UnityEngine_UI_Scrollbar_Binding.Register(app);
            UnityEngine_UI_Toggle_Binding.Register(app);
            ADataDriven_Binding.Register(app);
            System_Reflection_MethodInfo_Binding.Register(app);
            UnityEngine_UI_Button_Binding.Register(app);
            UnityEngine_Events_UnityEvent_Binding.Register(app);
            UnityEngine_Events_UnityEvent_1_Single_Binding.Register(app);
            System_Reflection_MethodBase_Binding.Register(app);
            UnityEngine_Random_Binding.Register(app);
            DataDrivenServer_Binding.Register(app);
            DG_Tweening_ShortcutExtensions_Binding.Register(app);
            UnityEngine_Vector3_Binding.Register(app);
            DG_Tweening_TweenSettingsExtensions_Binding.Register(app);

            ILRuntime.CLR.TypeSystem.CLRType __clrType = null;
        }

        /// <summary>
        /// Release the CLR binding, please invoke this BEFORE ILRuntime Appdomain destroy
        /// </summary>
        public static void Shutdown(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
        }
    }
}
