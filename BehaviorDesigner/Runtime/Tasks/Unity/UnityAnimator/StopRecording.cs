using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityAnimator
{
	// Token: 0x020014C0 RID: 5312
	[Token(Token = "0x2000E83")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x156230", Offset = "0x156331")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x156230", Offset = "0x156331")]
	public class StopRecording : Action
	{
		// Token: 0x06007955 RID: 31061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065F7")]
		[Address(RVA = "0x28D9460", Offset = "0x28D9561", VA = "0x28D9460", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x06007956 RID: 31062 RVA: 0x0002A420 File Offset: 0x00028620
		[Token(Token = "0x60065F8")]
		[Address(RVA = "0x28D9560", Offset = "0x28D9661", VA = "0x28D9560", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007957 RID: 31063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065F9")]
		[Address(RVA = "0x28D9640", Offset = "0x28D9741", VA = "0x28D9640", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007958 RID: 31064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065FA")]
		[Address(RVA = "0x28D9650", Offset = "0x28D9751", VA = "0x28D9650")]
		public StopRecording()
		{
		}

		// Token: 0x0401BC19 RID: 113689
		[Token(Token = "0x401860B")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x193A50", Offset = "0x193B51")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401BC1A RID: 113690
		[Token(Token = "0x401860C")]
		[FieldOffset(Offset = "0x58")]
		private Animator animator;

		// Token: 0x0401BC1B RID: 113691
		[Token(Token = "0x401860D")]
		[FieldOffset(Offset = "0x60")]
		private GameObject prevGameObject;
	}
}
