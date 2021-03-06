﻿#if USE_UNI_LUA
using LuaAPI = UniLua.Lua;
using RealStatePtr = UniLua.ILuaState;
using LuaCSFunction = UniLua.CSharpFunctionDelegate;
#else
using LuaAPI = XLua.LuaDLL.Lua;
using RealStatePtr = System.IntPtr;
using LuaCSFunction = XLua.LuaDLL.lua_CSFunction;
#endif

using XLua;
using System.Collections.Generic;


namespace XLua.CSObjectWrap
{
    using Utils = XLua.Utils;
    public class DCETModelMessageProxyWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(DCET.Model.MessageProxy);
			Utils.BeginObjectRegister(type, L, translator, 0, 2, 0, 0);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Handle", _m_Handle);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetMessageType", _m_GetMessageType);
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 1, 0, 0);
			
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 3 && translator.Assignable<System.Type>(L, 2) && translator.Assignable<System.Action<DCET.Model.Session, object>>(L, 3))
				{
					System.Type _type = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
					System.Action<DCET.Model.Session, object> _action = translator.GetDelegate<System.Action<DCET.Model.Session, object>>(L, 3);
					
					DCET.Model.MessageProxy gen_ret = new DCET.Model.MessageProxy(_type, _action);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to DCET.Model.MessageProxy constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Handle(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                DCET.Model.MessageProxy gen_to_be_invoked = (DCET.Model.MessageProxy)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    DCET.Model.Session _session = (DCET.Model.Session)translator.GetObject(L, 2, typeof(DCET.Model.Session));
                    object _message = translator.GetObject(L, 3, typeof(object));
                    
                        DCET.Model.ETVoid gen_ret = gen_to_be_invoked.Handle( _session, _message );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetMessageType(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                DCET.Model.MessageProxy gen_to_be_invoked = (DCET.Model.MessageProxy)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        System.Type gen_ret = gen_to_be_invoked.GetMessageType(  );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        
        
		
		
		
		
    }
}
