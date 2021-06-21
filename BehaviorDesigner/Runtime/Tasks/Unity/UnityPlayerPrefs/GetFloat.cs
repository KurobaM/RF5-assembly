using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityPlayerPrefs
{
	// Token: 0x020013CD RID: 5069
	[Token(Token = "0x2000D98")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x150A10", Offset = "0x150B11")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x150A10", Offset = "0x150B11")]
	public class GetFloat : Action
	{
		// Token: 0x060075DC RID: 30172 RVA: 0x00028DB8 File Offset: 0x00026FB8
		[Token(Token = "0x6006290")]
		[Address(RVA = "0x298D9F0", Offset = "0x298DAF1", VA = "0x298D9F0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060075DD RID: 30173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006291")]
		[Address(RVA = "0x298DAA0", Offset = "0x298DBA1", VA = "0x298DAA0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060075DE RID: 30174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006292")]
		[Address(RVA = "0x298DB50", Offset = "0x298DC51", VA = "0x298DB50")]
		public GetFloat()
		{
		}

		// Token: 0x0401B898 RID: 112792
		[Token(Token = "0x40182B9")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18B140", Offset = "0x18B241")]
		public SharedString key;

		// Token: 0x0401B899 RID: 112793
		[Token(Token = "0x40182BA")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18B180", Offset = "0x18B281")]
		public SharedFloat defaultValue;

		// Token: 0x0401B89A RID: 112794
		[Token(Token = "0x40182BB")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18B1C0", Offset = "0x18B2C1")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x18B1C0", Offset = "0x18B2C1")]
		public SharedFloat storeResult;
	}
}
