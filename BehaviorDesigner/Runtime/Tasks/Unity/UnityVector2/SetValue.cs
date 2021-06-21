using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityVector2
{
	// Token: 0x02001324 RID: 4900
	[Token(Token = "0x2000CEF")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14CA60", Offset = "0x14CB61")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14CA60", Offset = "0x14CB61")]
	public class SetValue : Action
	{
		// Token: 0x06007377 RID: 29559 RVA: 0x00027DE0 File Offset: 0x00025FE0
		[Token(Token = "0x600602B")]
		[Address(RVA = "0x2449120", Offset = "0x2449221", VA = "0x2449120", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007378 RID: 29560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600602C")]
		[Address(RVA = "0x24491A0", Offset = "0x24492A1", VA = "0x24491A0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007379 RID: 29561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600602D")]
		[Address(RVA = "0x2449240", Offset = "0x2449341", VA = "0x2449240")]
		public SetValue()
		{
		}

		// Token: 0x0401B661 RID: 112225
		[Token(Token = "0x4018082")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x185380", Offset = "0x185481")]
		public SharedVector2 vector2Value;

		// Token: 0x0401B662 RID: 112226
		[Token(Token = "0x4018083")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1853C0", Offset = "0x1854C1")]
		public SharedVector2 vector2Variable;
	}
}
