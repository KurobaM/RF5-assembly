using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityAnimator
{
	// Token: 0x020014BA RID: 5306
	[Token(Token = "0x2000E7D")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x155FF0", Offset = "0x1560F1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x155FF0", Offset = "0x1560F1")]
	public class SetLookAtWeight : Action
	{
		// Token: 0x0600793C RID: 31036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065DE")]
		[Address(RVA = "0x28D8700", Offset = "0x28D8801", VA = "0x28D8700", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x0600793D RID: 31037 RVA: 0x0002A390 File Offset: 0x00028590
		[Token(Token = "0x60065DF")]
		[Address(RVA = "0x28D8770", Offset = "0x28D8871", VA = "0x28D8770", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x0600793E RID: 31038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065E0")]
		[Address(RVA = "0x28D8840", Offset = "0x28D8941", VA = "0x28D8840", Slot = "27")]
		public override void OnAnimatorIK()
		{
		}

		// Token: 0x0600793F RID: 31039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065E1")]
		[Address(RVA = "0x28D8900", Offset = "0x28D8A01", VA = "0x28D8900", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007940 RID: 31040 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065E2")]
		[Address(RVA = "0x28D8950", Offset = "0x28D8A51", VA = "0x28D8950")]
		public SetLookAtWeight()
		{
		}

		// Token: 0x0401BC00 RID: 113664
		[Token(Token = "0x40185F2")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x193710", Offset = "0x193811")]
		public SharedFloat weight;

		// Token: 0x0401BC01 RID: 113665
		[Token(Token = "0x40185F3")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x193750", Offset = "0x193851")]
		public float bodyWeight;

		// Token: 0x0401BC02 RID: 113666
		[Token(Token = "0x40185F4")]
		[FieldOffset(Offset = "0x5C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x193790", Offset = "0x193891")]
		public float headWeight;

		// Token: 0x0401BC03 RID: 113667
		[Token(Token = "0x40185F5")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1937D0", Offset = "0x1938D1")]
		public float eyesWeight;

		// Token: 0x0401BC04 RID: 113668
		[Token(Token = "0x40185F6")]
		[FieldOffset(Offset = "0x64")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x193810", Offset = "0x193911")]
		public float clampWeight;

		// Token: 0x0401BC05 RID: 113669
		[Token(Token = "0x40185F7")]
		[FieldOffset(Offset = "0x68")]
		private Animator animator;

		// Token: 0x0401BC06 RID: 113670
		[Token(Token = "0x40185F8")]
		[FieldOffset(Offset = "0x70")]
		private bool weightSet;
	}
}
