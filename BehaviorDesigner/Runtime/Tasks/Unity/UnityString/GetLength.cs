using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityString
{
	// Token: 0x02001353 RID: 4947
	[Token(Token = "0x2000D1E")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14DC00", Offset = "0x14DD01")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14DC00", Offset = "0x14DD01")]
	public class GetLength : Action
	{
		// Token: 0x0600742A RID: 29738 RVA: 0x00028248 File Offset: 0x00026448
		[Token(Token = "0x60060DE")]
		[Address(RVA = "0x2999C50", Offset = "0x2999D51", VA = "0x2999C50", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x0600742B RID: 29739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060DF")]
		[Address(RVA = "0x2999CE0", Offset = "0x2999DE1", VA = "0x2999CE0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x0600742C RID: 29740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060E0")]
		[Address(RVA = "0x2999D60", Offset = "0x2999E61", VA = "0x2999D60")]
		public GetLength()
		{
		}

		// Token: 0x0401B712 RID: 112402
		[Token(Token = "0x4018133")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x186DA0", Offset = "0x186EA1")]
		public SharedString targetString;

		// Token: 0x0401B713 RID: 112403
		[Token(Token = "0x4018134")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x186DE0", Offset = "0x186EE1")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x186DE0", Offset = "0x186EE1")]
		public SharedInt storeResult;
	}
}
