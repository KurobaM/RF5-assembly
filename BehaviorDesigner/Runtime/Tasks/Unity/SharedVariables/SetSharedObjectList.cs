using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.SharedVariables
{
	// Token: 0x02001374 RID: 4980
	[Token(Token = "0x2000D3F")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14E860", Offset = "0x14E961")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14E860", Offset = "0x14E961")]
	public class SetSharedObjectList : Action
	{
		// Token: 0x06007491 RID: 29841 RVA: 0x00028560 File Offset: 0x00026760
		[Token(Token = "0x6006145")]
		[Address(RVA = "0x28D0630", Offset = "0x28D0731", VA = "0x28D0630", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007492 RID: 29842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006146")]
		[Address(RVA = "0x28D06B0", Offset = "0x28D07B1", VA = "0x28D06B0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007493 RID: 29843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006147")]
		[Address(RVA = "0x28D06F0", Offset = "0x28D07F1", VA = "0x28D06F0")]
		public SetSharedObjectList()
		{
		}

		// Token: 0x0401B760 RID: 112480
		[Token(Token = "0x4018181")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x188000", Offset = "0x188101")]
		public SharedObjectList targetValue;

		// Token: 0x0401B761 RID: 112481
		[Token(Token = "0x4018182")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x188040", Offset = "0x188141")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x188040", Offset = "0x188141")]
		public SharedObjectList targetVariable;
	}
}
