using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks
{
	// Token: 0x020012D9 RID: 4825
	[Token(Token = "0x2000CA6")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14AE20", Offset = "0x14AF21")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14AE20", Offset = "0x14AF21")]
	[Attribute(Name = "TaskIconAttribute", RVA = "0x14AE20", Offset = "0x14AF21")]
	public class InvokeMethod : Action
	{
		// Token: 0x06007224 RID: 29220 RVA: 0x000273F0 File Offset: 0x000255F0
		[Token(Token = "0x6005ED8")]
		[Address(RVA = "0x2213D90", Offset = "0x2213E91", VA = "0x2213D90", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007225 RID: 29221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005ED9")]
		[Address(RVA = "0x22142D0", Offset = "0x22143D1", VA = "0x22142D0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007226 RID: 29222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EDA")]
		[Address(RVA = "0x2214370", Offset = "0x2214471", VA = "0x2214370")]
		public InvokeMethod()
		{
		}

		// Token: 0x0401B575 RID: 111989
		[Token(Token = "0x4017F9E")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x182700", Offset = "0x182801")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B576 RID: 111990
		[Token(Token = "0x4017F9F")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x182740", Offset = "0x182841")]
		public SharedString componentName;

		// Token: 0x0401B577 RID: 111991
		[Token(Token = "0x4017FA0")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x182780", Offset = "0x182881")]
		public SharedString methodName;

		// Token: 0x0401B578 RID: 111992
		[Token(Token = "0x4017FA1")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1827C0", Offset = "0x1828C1")]
		public SharedVariable parameter1;

		// Token: 0x0401B579 RID: 111993
		[Token(Token = "0x4017FA2")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x182800", Offset = "0x182901")]
		public SharedVariable parameter2;

		// Token: 0x0401B57A RID: 111994
		[Token(Token = "0x4017FA3")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x182840", Offset = "0x182941")]
		public SharedVariable parameter3;

		// Token: 0x0401B57B RID: 111995
		[Token(Token = "0x4017FA4")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x182880", Offset = "0x182981")]
		public SharedVariable parameter4;

		// Token: 0x0401B57C RID: 111996
		[Token(Token = "0x4017FA5")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1828C0", Offset = "0x1829C1")]
		public SharedVariable storeResult;
	}
}
