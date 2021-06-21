using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityPlayerPrefs
{
	// Token: 0x020013D4 RID: 5076
	[Token(Token = "0x2000D9F")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x150CB0", Offset = "0x150DB1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x150CB0", Offset = "0x150DB1")]
	public class SetString : Action
	{
		// Token: 0x060075F0 RID: 30192 RVA: 0x00028E60 File Offset: 0x00027060
		[Token(Token = "0x60062A4")]
		[Address(RVA = "0x298E180", Offset = "0x298E281", VA = "0x298E180", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060075F1 RID: 30193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062A5")]
		[Address(RVA = "0x298E210", Offset = "0x298E311", VA = "0x298E210", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060075F2 RID: 30194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062A6")]
		[Address(RVA = "0x298E290", Offset = "0x298E391", VA = "0x298E290")]
		public SetString()
		{
		}

		// Token: 0x0401B8A6 RID: 112806
		[Token(Token = "0x40182C7")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18B4F0", Offset = "0x18B5F1")]
		public SharedString key;

		// Token: 0x0401B8A7 RID: 112807
		[Token(Token = "0x40182C8")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18B530", Offset = "0x18B631")]
		public SharedString value;
	}
}
