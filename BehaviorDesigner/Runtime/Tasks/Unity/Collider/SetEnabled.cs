using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.Collider
{
	// Token: 0x02001458 RID: 5208
	[Token(Token = "0x2000E1E")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x153C50", Offset = "0x153D51")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x153C50", Offset = "0x153D51")]
	public class SetEnabled : Action
	{
		// Token: 0x060077AE RID: 30638 RVA: 0x00029A60 File Offset: 0x00027C60
		[Token(Token = "0x6006462")]
		[Address(RVA = "0x221C380", Offset = "0x221C481", VA = "0x221C380", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060077AF RID: 30639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006463")]
		[Address(RVA = "0x221C460", Offset = "0x221C561", VA = "0x221C460", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060077B0 RID: 30640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006464")]
		[Address(RVA = "0x221C550", Offset = "0x221C651", VA = "0x221C550")]
		public SetEnabled()
		{
		}

		// Token: 0x0401BA6E RID: 113262
		[Token(Token = "0x401846C")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1900B0", Offset = "0x1901B1")]
		public SharedCollider specifiedCollider;

		// Token: 0x0401BA6F RID: 113263
		[Token(Token = "0x401846D")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1900F0", Offset = "0x1901F1")]
		public SharedBool enabled;
	}
}
