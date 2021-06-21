using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityTime
{
	// Token: 0x0200134D RID: 4941
	[Token(Token = "0x2000D18")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14D9C0", Offset = "0x14DAC1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14D9C0", Offset = "0x14DAC1")]
	public class GetTime : Action
	{
		// Token: 0x06007417 RID: 29719 RVA: 0x000281B8 File Offset: 0x000263B8
		[Token(Token = "0x60060CB")]
		[Address(RVA = "0x299A5C0", Offset = "0x299A6C1", VA = "0x299A5C0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007418 RID: 29720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060CC")]
		[Address(RVA = "0x299A630", Offset = "0x299A731", VA = "0x299A630", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007419 RID: 29721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060CD")]
		[Address(RVA = "0x299A670", Offset = "0x299A771", VA = "0x299A670")]
		public GetTime()
		{
		}

		// Token: 0x0401B706 RID: 112390
		[Token(Token = "0x4018127")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x186AB0", Offset = "0x186BB1")]
		public SharedFloat storeResult;
	}
}
