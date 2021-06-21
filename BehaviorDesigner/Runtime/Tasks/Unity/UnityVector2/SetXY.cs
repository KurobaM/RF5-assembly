using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityVector2
{
	// Token: 0x02001325 RID: 4901
	[Token(Token = "0x2000CF0")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14CAC0", Offset = "0x14CBC1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14CAC0", Offset = "0x14CBC1")]
	public class SetXY : Action
	{
		// Token: 0x0600737A RID: 29562 RVA: 0x00027DF8 File Offset: 0x00025FF8
		[Token(Token = "0x600602E")]
		[Address(RVA = "0x2449250", Offset = "0x2449351", VA = "0x2449250", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x0600737B RID: 29563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600602F")]
		[Address(RVA = "0x2449340", Offset = "0x2449441", VA = "0x2449340", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x0600737C RID: 29564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006030")]
		[Address(RVA = "0x2449400", Offset = "0x2449501", VA = "0x2449400")]
		public SetXY()
		{
		}

		// Token: 0x0401B663 RID: 112227
		[Token(Token = "0x4018084")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x185400", Offset = "0x185501")]
		public SharedVector2 vector2Variable;

		// Token: 0x0401B664 RID: 112228
		[Token(Token = "0x4018085")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x185440", Offset = "0x185541")]
		public SharedFloat xValue;

		// Token: 0x0401B665 RID: 112229
		[Token(Token = "0x4018086")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x185480", Offset = "0x185581")]
		public SharedFloat yValue;
	}
}
