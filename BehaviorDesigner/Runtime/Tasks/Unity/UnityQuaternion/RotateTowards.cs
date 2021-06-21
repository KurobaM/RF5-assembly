using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityQuaternion
{
	// Token: 0x020013C9 RID: 5065
	[Token(Token = "0x2000D94")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x150890", Offset = "0x150991")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x150890", Offset = "0x150991")]
	public class RotateTowards : Action
	{
		// Token: 0x060075D1 RID: 30161 RVA: 0x00028D58 File Offset: 0x00026F58
		[Token(Token = "0x6006285")]
		[Address(RVA = "0x298F230", Offset = "0x298F331", VA = "0x298F230", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060075D2 RID: 30162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006286")]
		[Address(RVA = "0x298F380", Offset = "0x298F481", VA = "0x298F380", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060075D3 RID: 30163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006287")]
		[Address(RVA = "0x298F440", Offset = "0x298F541", VA = "0x298F440")]
		public RotateTowards()
		{
		}

		// Token: 0x0401B88F RID: 112783
		[Token(Token = "0x40182B0")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18AEE0", Offset = "0x18AFE1")]
		public SharedQuaternion fromQuaternion;

		// Token: 0x0401B890 RID: 112784
		[Token(Token = "0x40182B1")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18AF20", Offset = "0x18B021")]
		public SharedQuaternion toQuaternion;

		// Token: 0x0401B891 RID: 112785
		[Token(Token = "0x40182B2")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18AF60", Offset = "0x18B061")]
		public SharedFloat maxDeltaDegrees;

		// Token: 0x0401B892 RID: 112786
		[Token(Token = "0x40182B3")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18AFA0", Offset = "0x18B0A1")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x18AFA0", Offset = "0x18B0A1")]
		public SharedQuaternion storeResult;
	}
}
