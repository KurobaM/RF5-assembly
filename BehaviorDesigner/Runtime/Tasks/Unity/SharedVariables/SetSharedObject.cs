using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.SharedVariables
{
	// Token: 0x02001373 RID: 4979
	[Token(Token = "0x2000D3E")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14E800", Offset = "0x14E901")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14E800", Offset = "0x14E901")]
	public class SetSharedObject : Action
	{
		// Token: 0x0600748E RID: 29838 RVA: 0x00028548 File Offset: 0x00026748
		[Token(Token = "0x6006142")]
		[Address(RVA = "0x28D0560", Offset = "0x28D0661", VA = "0x28D0560", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x0600748F RID: 29839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006143")]
		[Address(RVA = "0x28D05E0", Offset = "0x28D06E1", VA = "0x28D05E0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007490 RID: 29840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006144")]
		[Address(RVA = "0x28D0620", Offset = "0x28D0721", VA = "0x28D0620")]
		public SetSharedObject()
		{
		}

		// Token: 0x0401B75E RID: 112478
		[Token(Token = "0x401817F")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x187F70", Offset = "0x188071")]
		public SharedObject targetValue;

		// Token: 0x0401B75F RID: 112479
		[Token(Token = "0x4018180")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x187FB0", Offset = "0x1880B1")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x187FB0", Offset = "0x1880B1")]
		public SharedObject targetVariable;
	}
}
