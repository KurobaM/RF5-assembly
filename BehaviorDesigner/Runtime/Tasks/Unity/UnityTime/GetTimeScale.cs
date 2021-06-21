using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityTime
{
	// Token: 0x0200134E RID: 4942
	[Token(Token = "0x2000D19")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14DA20", Offset = "0x14DB21")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14DA20", Offset = "0x14DB21")]
	public class GetTimeScale : Action
	{
		// Token: 0x0600741A RID: 29722 RVA: 0x000281D0 File Offset: 0x000263D0
		[Token(Token = "0x60060CE")]
		[Address(RVA = "0x299A680", Offset = "0x299A781", VA = "0x299A680", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x0600741B RID: 29723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060CF")]
		[Address(RVA = "0x299A6F0", Offset = "0x299A7F1", VA = "0x299A6F0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x0600741C RID: 29724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060D0")]
		[Address(RVA = "0x299A730", Offset = "0x299A831", VA = "0x299A730")]
		public GetTimeScale()
		{
		}

		// Token: 0x0401B707 RID: 112391
		[Token(Token = "0x4018128")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x186AF0", Offset = "0x186BF1")]
		public SharedFloat storeResult;
	}
}
