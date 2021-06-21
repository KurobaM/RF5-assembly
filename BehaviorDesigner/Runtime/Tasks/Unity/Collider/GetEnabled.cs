using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.Collider
{
	// Token: 0x02001457 RID: 5207
	[Token(Token = "0x2000E1D")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x153BF0", Offset = "0x153CF1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x153BF0", Offset = "0x153CF1")]
	public class GetEnabled : Action
	{
		// Token: 0x060077AB RID: 30635 RVA: 0x00029A48 File Offset: 0x00027C48
		[Token(Token = "0x600645F")]
		[Address(RVA = "0x221C1B0", Offset = "0x221C2B1", VA = "0x221C1B0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060077AC RID: 30636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006460")]
		[Address(RVA = "0x221C280", Offset = "0x221C381", VA = "0x221C280", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060077AD RID: 30637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006461")]
		[Address(RVA = "0x221C370", Offset = "0x221C471", VA = "0x221C370")]
		public GetEnabled()
		{
		}

		// Token: 0x0401BA6C RID: 113260
		[Token(Token = "0x401846A")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x190020", Offset = "0x190121")]
		public SharedCollider specifiedCollider;

		// Token: 0x0401BA6D RID: 113261
		[Token(Token = "0x401846B")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x190060", Offset = "0x190161")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x190060", Offset = "0x190161")]
		public SharedBool storeValue;
	}
}
