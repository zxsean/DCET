﻿using DCET.Model;

namespace DCET.Hotfix
{
	// 分发数值监听
	[Event(DCET.Model.EventIdType.TestHotfixSubscribMonoEvent)]
	public class TestHotfixSubscribMonoEvent_LogString : AEvent<string>
	{
		public override void Run(string info)
		{
			Log.Info(info);
		}
	}
}
