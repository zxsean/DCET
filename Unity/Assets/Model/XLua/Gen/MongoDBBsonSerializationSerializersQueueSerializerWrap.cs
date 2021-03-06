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
    public class MongoDBBsonSerializationSerializersQueueSerializerWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(MongoDB.Bson.Serialization.Serializers.QueueSerializer);
			Utils.BeginObjectRegister(type, L, translator, 0, 1, 0, 0);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "WithItemSerializer", _m_WithItemSerializer);
			
			
			
			
			
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
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					MongoDB.Bson.Serialization.Serializers.QueueSerializer gen_ret = new MongoDB.Bson.Serialization.Serializers.QueueSerializer();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 2 && translator.Assignable<MongoDB.Bson.Serialization.IBsonSerializer>(L, 2))
				{
					MongoDB.Bson.Serialization.IBsonSerializer _itemSerializer = (MongoDB.Bson.Serialization.IBsonSerializer)translator.GetObject(L, 2, typeof(MongoDB.Bson.Serialization.IBsonSerializer));
					
					MongoDB.Bson.Serialization.Serializers.QueueSerializer gen_ret = new MongoDB.Bson.Serialization.Serializers.QueueSerializer(_itemSerializer);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 2 && translator.Assignable<MongoDB.Bson.Serialization.IBsonSerializerRegistry>(L, 2))
				{
					MongoDB.Bson.Serialization.IBsonSerializerRegistry _serializerRegistry = (MongoDB.Bson.Serialization.IBsonSerializerRegistry)translator.GetObject(L, 2, typeof(MongoDB.Bson.Serialization.IBsonSerializerRegistry));
					
					MongoDB.Bson.Serialization.Serializers.QueueSerializer gen_ret = new MongoDB.Bson.Serialization.Serializers.QueueSerializer(_serializerRegistry);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to MongoDB.Bson.Serialization.Serializers.QueueSerializer constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_WithItemSerializer(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.Serialization.Serializers.QueueSerializer gen_to_be_invoked = (MongoDB.Bson.Serialization.Serializers.QueueSerializer)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    MongoDB.Bson.Serialization.IBsonSerializer _itemSerializer = (MongoDB.Bson.Serialization.IBsonSerializer)translator.GetObject(L, 2, typeof(MongoDB.Bson.Serialization.IBsonSerializer));
                    
                        MongoDB.Bson.Serialization.Serializers.QueueSerializer gen_ret = gen_to_be_invoked.WithItemSerializer( _itemSerializer );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        
        
		
		
		
		
    }
}
