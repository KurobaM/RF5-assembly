using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityPlayerPrefs
{
	// Token: 0x020013CF RID: 5071
	[Token(Token = "0x2000D9A")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x150AD0", Offset = "0x150BD1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x150AD0", Offset = "0x150BD1")]
	public class GetString : Action
	{
		// Token: 0x060075E2 RID: 30178 RVA: 0x00028DE8 File Offset: 0x00026FE8
		[Token(Token = "0x6006296")]
		[Address(RVA = "0x298DCD0", Offset = "0x298DDD1", VA = "0x298DCD0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060075E3 RID: 30179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006297")]
		[Address(RVA = "0x298DD80", Offset = "0x298DE81", VA = "0x298DD80", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060075E4 RID: 30180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006298")]
		[Address(RVA = "0x298DE20", Offset = "0x298DF21", VA = "0x298DE20")]
		public GetString()
		{
		}

		// Token: 0x0401B89E RID: 112798
		[Token(Token = "0x40182BF")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18B2E0", Offset = "0x18B3E1")]
		public SharedString key;

		// Token: 0x0401B89F RID: 112799
		[Token(Token = "0x40182C0")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18B320", Offset = "0x18B421")]
		public SharedString defaultValue;

		// Token: 0x0401B8A0 RID: 112800
		[Token(Token = "0x40182C1")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18B360", Offset = "0x18B461")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x18B360", Offset = "0x18B461")]
		public SharedString storeResult;
	}
}
