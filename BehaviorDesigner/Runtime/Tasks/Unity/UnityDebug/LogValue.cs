using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityDebug
{
	// Token: 0x02001456 RID: 5206
	[Token(Token = "0x2000E1C")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x153B90", Offset = "0x153C91")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x153B90", Offset = "0x153C91")]
	public class LogValue : Action
	{
		// Token: 0x060077A8 RID: 30632 RVA: 0x00029A30 File Offset: 0x00027C30
		[Token(Token = "0x600645C")]
		[Address(RVA = "0x28E4B20", Offset = "0x28E4C21", VA = "0x28E4B20", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060077A9 RID: 30633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600645D")]
		[Address(RVA = "0x28E4BD0", Offset = "0x28E4CD1", VA = "0x28E4BD0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060077AA RID: 30634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600645E")]
		[Address(RVA = "0x28E4BE0", Offset = "0x28E4CE1", VA = "0x28E4BE0")]
		public LogValue()
		{
		}

		// Token: 0x0401BA6B RID: 113259
		[Token(Token = "0x4018469")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18FFE0", Offset = "0x1900E1")]
		public SharedGenericVariable variable;
	}
}
