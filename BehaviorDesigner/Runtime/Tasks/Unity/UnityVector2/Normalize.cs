using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityVector2
{
	// Token: 0x02001321 RID: 4897
	[Token(Token = "0x2000CED")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14C9A0", Offset = "0x14CAA1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14C9A0", Offset = "0x14CAA1")]
	public class Normalize : Action
	{
		// Token: 0x06007371 RID: 29553 RVA: 0x00027DB0 File Offset: 0x00025FB0
		[Token(Token = "0x6006025")]
		[Address(RVA = "0x2448D00", Offset = "0x2448E01", VA = "0x2448D00", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007372 RID: 29554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006026")]
		[Address(RVA = "0x2448DA0", Offset = "0x2448EA1", VA = "0x2448DA0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007373 RID: 29555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006027")]
		[Address(RVA = "0x2448E40", Offset = "0x2448F41", VA = "0x2448E40")]
		public Normalize()
		{
		}

		// Token: 0x0401B657 RID: 112215
		[Token(Token = "0x401807C")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1851F0", Offset = "0x1852F1")]
		public SharedVector2 vector2Variable;

		// Token: 0x0401B658 RID: 112216
		[Token(Token = "0x401807D")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x185230", Offset = "0x185331")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x185230", Offset = "0x185331")]
		public SharedVector2 storeResult;
	}
}
