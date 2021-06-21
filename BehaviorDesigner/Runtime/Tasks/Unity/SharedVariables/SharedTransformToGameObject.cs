using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.SharedVariables
{
	// Token: 0x0200137F RID: 4991
	[Token(Token = "0x2000D4A")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14EC80", Offset = "0x14ED81")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14EC80", Offset = "0x14ED81")]
	public class SharedTransformToGameObject : Action
	{
		// Token: 0x060074B3 RID: 29875 RVA: 0x00028668 File Offset: 0x00026868
		[Token(Token = "0x6006167")]
		[Address(RVA = "0x28D1340", Offset = "0x28D1441", VA = "0x28D1340", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060074B4 RID: 29876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006168")]
		[Address(RVA = "0x28D1430", Offset = "0x28D1531", VA = "0x28D1430", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060074B5 RID: 29877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006169")]
		[Address(RVA = "0x28D1470", Offset = "0x28D1571", VA = "0x28D1470")]
		public SharedTransformToGameObject()
		{
		}

		// Token: 0x0401B776 RID: 112502
		[Token(Token = "0x4018197")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x188630", Offset = "0x188731")]
		public SharedTransform sharedTransform;

		// Token: 0x0401B777 RID: 112503
		[Token(Token = "0x4018198")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x188670", Offset = "0x188771")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x188670", Offset = "0x188771")]
		public SharedGameObject sharedGameObject;
	}
}
