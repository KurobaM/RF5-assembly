using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.SharedVariables
{
	// Token: 0x0200137D RID: 4989
	[Token(Token = "0x2000D48")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14EBC0", Offset = "0x14ECC1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14EBC0", Offset = "0x14ECC1")]
	public class SharedGameObjectToTransform : Action
	{
		// Token: 0x060074AC RID: 29868 RVA: 0x00028638 File Offset: 0x00026838
		[Token(Token = "0x6006160")]
		[Address(RVA = "0x28D0FE0", Offset = "0x28D10E1", VA = "0x28D0FE0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060074AD RID: 29869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006161")]
		[Address(RVA = "0x28D10E0", Offset = "0x28D11E1", VA = "0x28D10E0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060074AE RID: 29870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006162")]
		[Address(RVA = "0x28D1120", Offset = "0x28D1221", VA = "0x28D1120")]
		public SharedGameObjectToTransform()
		{
		}

		// Token: 0x0401B772 RID: 112498
		[Token(Token = "0x4018193")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x188510", Offset = "0x188611")]
		public SharedGameObject sharedGameObject;

		// Token: 0x0401B773 RID: 112499
		[Token(Token = "0x4018194")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x188550", Offset = "0x188651")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x188550", Offset = "0x188651")]
		public SharedTransform sharedTransform;
	}
}
