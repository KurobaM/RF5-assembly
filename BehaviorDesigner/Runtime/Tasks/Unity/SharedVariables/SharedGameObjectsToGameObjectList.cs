using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.SharedVariables
{
	// Token: 0x0200137E RID: 4990
	[Token(Token = "0x2000D49")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14EC20", Offset = "0x14ED21")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14EC20", Offset = "0x14ED21")]
	public class SharedGameObjectsToGameObjectList : Action
	{
		// Token: 0x060074AF RID: 29871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006163")]
		[Address(RVA = "0x28D1130", Offset = "0x28D1231", VA = "0x28D1130", Slot = "4")]
		public override void OnAwake()
		{
		}

		// Token: 0x060074B0 RID: 29872 RVA: 0x00028650 File Offset: 0x00026850
		[Token(Token = "0x6006164")]
		[Address(RVA = "0x28D11C0", Offset = "0x28D12C1", VA = "0x28D11C0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060074B1 RID: 29873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006165")]
		[Address(RVA = "0x28D12F0", Offset = "0x28D13F1", VA = "0x28D12F0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060074B2 RID: 29874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006166")]
		[Address(RVA = "0x28D1330", Offset = "0x28D1431", VA = "0x28D1330")]
		public SharedGameObjectsToGameObjectList()
		{
		}

		// Token: 0x0401B774 RID: 112500
		[Token(Token = "0x4018195")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1885A0", Offset = "0x1886A1")]
		public SharedGameObject[] gameObjects;

		// Token: 0x0401B775 RID: 112501
		[Token(Token = "0x4018196")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x1885E0", Offset = "0x1886E1")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1885E0", Offset = "0x1886E1")]
		public SharedGameObjectList storedGameObjectList;
	}
}
