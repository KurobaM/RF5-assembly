using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityQuaternion
{
	// Token: 0x020013CA RID: 5066
	[Token(Token = "0x2000D95")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x1508F0", Offset = "0x1509F1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x1508F0", Offset = "0x1509F1")]
	public class Slerp : Action
	{
		// Token: 0x060075D4 RID: 30164 RVA: 0x00028D70 File Offset: 0x00026F70
		[Token(Token = "0x6006288")]
		[Address(RVA = "0x298F450", Offset = "0x298F551", VA = "0x298F450", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060075D5 RID: 30165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006289")]
		[Address(RVA = "0x298F5A0", Offset = "0x298F6A1", VA = "0x298F5A0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060075D6 RID: 30166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600628A")]
		[Address(RVA = "0x298F660", Offset = "0x298F761", VA = "0x298F660")]
		public Slerp()
		{
		}

		// Token: 0x0401B893 RID: 112787
		[Token(Token = "0x40182B4")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18AFF0", Offset = "0x18B0F1")]
		public SharedQuaternion fromQuaternion;

		// Token: 0x0401B894 RID: 112788
		[Token(Token = "0x40182B5")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18B030", Offset = "0x18B131")]
		public SharedQuaternion toQuaternion;

		// Token: 0x0401B895 RID: 112789
		[Token(Token = "0x40182B6")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18B070", Offset = "0x18B171")]
		public SharedFloat amount;

		// Token: 0x0401B896 RID: 112790
		[Token(Token = "0x40182B7")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18B0B0", Offset = "0x18B1B1")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x18B0B0", Offset = "0x18B1B1")]
		public SharedQuaternion storeResult;
	}
}
