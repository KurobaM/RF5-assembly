using System;
using System.Reflection;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

namespace Tantawowa.TimelineEvents
{
	// Token: 0x020010EA RID: 4330
	[Token(Token = "0x2000AE0")]
	[Serializable]
	public class TimelineEventBehaviour : PlayableBehaviour
	{
		// Token: 0x06006DB8 RID: 28088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B03")]
		[Address(RVA = "0x1FC2460", Offset = "0x1FC2561", VA = "0x1FC2460", Slot = "17")]
		public override void OnBehaviourPlay(Playable playable, FrameData info)
		{
		}

		// Token: 0x06006DB9 RID: 28089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B04")]
		[Address(RVA = "0x1FC2510", Offset = "0x1FC2611", VA = "0x1FC2510")]
		private void UpdateDelegates()
		{
		}

		// Token: 0x06006DBA RID: 28090 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B05")]
		[Address(RVA = "0x1FC2570", Offset = "0x1FC2671", VA = "0x1FC2570")]
		private EventInvocationInfo GetInvocationInfo(bool isEnabled, string methodKey, EventInvocationInfo currentInfo, bool methodWitharg)
		{
			return null;
		}

		// Token: 0x06006DBB RID: 28091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B06")]
		[Address(RVA = "0x1FC27B0", Offset = "0x1FC28B1", VA = "0x1FC27B0")]
		private void GetBehaviourAndMethod(bool isEnabled, string key, ref Behaviour targetBehaviour, ref string methodName)
		{
		}

		// Token: 0x06006DBC RID: 28092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B07")]
		[Address(RVA = "0x1FC2A70", Offset = "0x1FC2B71", VA = "0x1FC2A70")]
		public TimelineEventBehaviour()
		{
		}

		// Token: 0x04017553 RID: 95571
		[Token(Token = "0x4014035")]
		[FieldOffset(Offset = "0x10")]
		public string HandlerKey;

		// Token: 0x04017554 RID: 95572
		[Token(Token = "0x4014036")]
		[FieldOffset(Offset = "0x18")]
		public bool IsMethodWithParam;

		// Token: 0x04017555 RID: 95573
		[Token(Token = "0x4014037")]
		[FieldOffset(Offset = "0x19")]
		public bool InvokeEventsInEditMode;

		// Token: 0x04017556 RID: 95574
		[Token(Token = "0x4014038")]
		[FieldOffset(Offset = "0x20")]
		public GameObject TargetObject;

		// Token: 0x04017557 RID: 95575
		[Token(Token = "0x4014039")]
		[FieldOffset(Offset = "0x28")]
		public string ArgValue;

		// Token: 0x04017558 RID: 95576
		[Token(Token = "0x401403A")]
		[FieldOffset(Offset = "0x30")]
		private EventInvocationInfo invocationInfo;

		// Token: 0x020010EB RID: 4331
		[Token(Token = "0x2001576")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15A0F0", Offset = "0x15A1F1")]
		private sealed class <>c__DisplayClass8_0
		{
			// Token: 0x06006DBD RID: 28093 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007D64")]
			[Address(RVA = "0x1FC27A0", Offset = "0x1FC28A1", VA = "0x1FC27A0")]
			public <>c__DisplayClass8_0()
			{
			}

			// Token: 0x06006DBE RID: 28094 RVA: 0x00025C50 File Offset: 0x00023E50
			[Token(Token = "0x6007D65")]
			[Address(RVA = "0x1FC2A80", Offset = "0x1FC2B81", VA = "0x1FC2A80")]
			internal bool <GetInvocationInfo>b__0(MethodInfo m)
			{
				return default(bool);
			}

			// Token: 0x04017559 RID: 95577
			[Token(Token = "0x401C12A")]
			[FieldOffset(Offset = "0x10")]
			public string methodName;

			// Token: 0x0401755A RID: 95578
			[Token(Token = "0x401C12B")]
			[FieldOffset(Offset = "0x18")]
			public bool methodWitharg;
		}
	}
}
