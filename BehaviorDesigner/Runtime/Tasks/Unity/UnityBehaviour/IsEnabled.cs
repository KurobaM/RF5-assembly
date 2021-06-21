using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityBehaviour
{
	// Token: 0x0200147B RID: 5243
	[Token(Token = "0x2000E41")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x154970", Offset = "0x154A71")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x154970", Offset = "0x154A71")]
	public class IsEnabled : Conditional
	{
		// Token: 0x06007839 RID: 30777 RVA: 0x00029DA8 File Offset: 0x00027FA8
		[Token(Token = "0x60064ED")]
		[Address(RVA = "0x28DEE80", Offset = "0x28DEF81", VA = "0x28DEE80", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x0600783A RID: 30778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064EE")]
		[Address(RVA = "0x28DEF30", Offset = "0x28DF031", VA = "0x28DEF30", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x0600783B RID: 30779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064EF")]
		[Address(RVA = "0x28DEFA0", Offset = "0x28DF0A1", VA = "0x28DEFA0")]
		public IsEnabled()
		{
		}

		// Token: 0x0401BAF5 RID: 113397
		[Token(Token = "0x40184F3")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x191330", Offset = "0x191431")]
		public SharedObject specifiedObject;
	}
}
