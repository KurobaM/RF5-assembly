using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityDebug
{
	// Token: 0x02001453 RID: 5203
	[Token(Token = "0x2000E19")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x153A70", Offset = "0x153B71")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x153A70", Offset = "0x153B71")]
	public class DrawLine : Action
	{
		// Token: 0x0600779D RID: 30621 RVA: 0x000299D0 File Offset: 0x00027BD0
		[Token(Token = "0x6006451")]
		[Address(RVA = "0x28E4170", Offset = "0x28E4271", VA = "0x28E4170", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x0600779E RID: 30622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006452")]
		[Address(RVA = "0x28E42D0", Offset = "0x28E43D1", VA = "0x28E42D0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x0600779F RID: 30623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006453")]
		[Address(RVA = "0x28E43D0", Offset = "0x28E44D1", VA = "0x28E43D0")]
		public DrawLine()
		{
		}

		// Token: 0x0401BA5D RID: 113245
		[Token(Token = "0x401845B")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18FD60", Offset = "0x18FE61")]
		public SharedVector3 start;

		// Token: 0x0401BA5E RID: 113246
		[Token(Token = "0x401845C")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18FDA0", Offset = "0x18FEA1")]
		public SharedVector3 end;

		// Token: 0x0401BA5F RID: 113247
		[Token(Token = "0x401845D")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18FDE0", Offset = "0x18FEE1")]
		public SharedColor color;

		// Token: 0x0401BA60 RID: 113248
		[Token(Token = "0x401845E")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18FE20", Offset = "0x18FF21")]
		public SharedFloat duration;

		// Token: 0x0401BA61 RID: 113249
		[Token(Token = "0x401845F")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18FE60", Offset = "0x18FF61")]
		public SharedBool depthTest;
	}
}
