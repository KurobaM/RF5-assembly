using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityVector3
{
	// Token: 0x02001314 RID: 4884
	[Token(Token = "0x2000CE0")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14C4C0", Offset = "0x14C5C1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14C4C0", Offset = "0x14C5C1")]
	public class SetXYZ : Action
	{
		// Token: 0x0600734A RID: 29514 RVA: 0x00027C78 File Offset: 0x00025E78
		[Token(Token = "0x6005FFE")]
		[Address(RVA = "0x244B300", Offset = "0x244B401", VA = "0x244B300", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x0600734B RID: 29515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FFF")]
		[Address(RVA = "0x244B430", Offset = "0x244B531", VA = "0x244B430", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x0600734C RID: 29516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006000")]
		[Address(RVA = "0x244B4F0", Offset = "0x244B5F1", VA = "0x244B4F0")]
		public SetXYZ()
		{
		}

		// Token: 0x0401B634 RID: 112180
		[Token(Token = "0x4018059")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x184860", Offset = "0x184961")]
		public SharedVector3 vector3Variable;

		// Token: 0x0401B635 RID: 112181
		[Token(Token = "0x401805A")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1848A0", Offset = "0x1849A1")]
		public SharedFloat xValue;

		// Token: 0x0401B636 RID: 112182
		[Token(Token = "0x401805B")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1848E0", Offset = "0x1849E1")]
		public SharedFloat yValue;

		// Token: 0x0401B637 RID: 112183
		[Token(Token = "0x401805C")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x184920", Offset = "0x184A21")]
		public SharedFloat zValue;
	}
}
