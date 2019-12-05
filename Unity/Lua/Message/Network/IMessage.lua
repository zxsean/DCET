-- Generated by CSharp.lua Compiler
local System = System
System.namespace("DCET.Hotfix", function (namespace)
  namespace.interface("IMessage", function ()
    return {
      __inherits__ = function (out)
        return {
          out.Google.Protobuf.IMessage
        }
      end
    }
  end)

  namespace.interface("IRequest", function ()
    return {
      __inherits__ = function (out)
        return {
          out.DCET.Hotfix.IMessage
        }
      end
    }
  end)

  namespace.interface("IResponse", function ()
    return {
      __inherits__ = function (out)
        return {
          out.DCET.Hotfix.IMessage
        }
      end
    }
  end)

  namespace.class("ResponseMessage", function (namespace)
    local getError, setError, getMessage, setMessage, getRpcId, setRpcId, MergeFrom, WriteTo, 
    CalculateSize
    getError, setError = System.property("Error")
    getMessage, setMessage = System.property("Message")
    getRpcId, setRpcId = System.property("RpcId")
    MergeFrom = function (this, input)
      System.throw(System.NotImplementedException())
    end
    WriteTo = function (this, output)
      System.throw(System.NotImplementedException())
    end
    CalculateSize = function (this)
      System.throw(System.NotImplementedException())
    end
    return {
      __inherits__ = function (out)
        return {
          out.DCET.Hotfix.IResponse
        }
      end,
      Error = 0,
      getError = getError,
      setError = setError,
      getMessage = getMessage,
      setMessage = setMessage,
      RpcId = 0,
      getRpcId = getRpcId,
      setRpcId = setRpcId,
      MergeFrom = MergeFrom,
      WriteTo = WriteTo,
      CalculateSize = CalculateSize
    }
  end)
end)