using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.Math
{
	// Token: 0x02001421 RID: 5153
	[Token(Token = "0x2000DE7")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x1527B0", Offset = "0x1528B1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x1527B0", Offset = "0x1528B1")]
	public class SetFloat : Action
	{
		// Token: 0x060076F5 RID: 30453 RVA: 0x00029520 File Offset: 0x00027720
		[Token(Token = "0x60063A9")]
		[Address(RVA = "0x221F0F0", Offset = "0x221F1F1", VA = "0x221F0F0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060076F6 RID: 30454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063AA")]
		[Address(RVA = "0x221F170", Offset = "0x221F271", VA = "0x221F170", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060076F7 RID: 30455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063AB")]
		[Address(RVA = "0x221F2C0", Offset = "0x221F3C1", VA = "0x221F2C0")]
		public SetFloat()
		{
		}

		// Token: 0x0401B9D9 RID: 113113
		[Token(Token = "0x40183D7")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18E410", Offset = "0x18E511")]
		public SharedFloat floatValue;

		// Token: 0x0401B9DA RID: 113114
		[Token(Token = "0x40183D8")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18E450", Offset = "0x18E551")]
		public SharedFloat storeResult;
	}
}
