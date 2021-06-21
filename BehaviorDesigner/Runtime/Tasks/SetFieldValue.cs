using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks
{
	// Token: 0x020012DA RID: 4826
	[Token(Token = "0x2000CA7")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14AEB0", Offset = "0x14AFB1")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14AEB0", Offset = "0x14AFB1")]
	[Attribute(Name = "TaskIconAttribute", RVA = "0x14AEB0", Offset = "0x14AFB1")]
	public class SetFieldValue : Action
	{
		// Token: 0x06007227 RID: 29223 RVA: 0x00027408 File Offset: 0x00025608
		[Token(Token = "0x6005EDB")]
		[Address(RVA = "0x221AA60", Offset = "0x221AB61", VA = "0x221AA60", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007228 RID: 29224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EDC")]
		[Address(RVA = "0x221ACE0", Offset = "0x221ADE1", VA = "0x221ACE0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007229 RID: 29225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EDD")]
		[Address(RVA = "0x221AD40", Offset = "0x221AE41", VA = "0x221AD40")]
		public SetFieldValue()
		{
		}

		// Token: 0x0401B57D RID: 111997
		[Token(Token = "0x4017FA6")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x182900", Offset = "0x182A01")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B57E RID: 111998
		[Token(Token = "0x4017FA7")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x182940", Offset = "0x182A41")]
		public SharedString componentName;

		// Token: 0x0401B57F RID: 111999
		[Token(Token = "0x4017FA8")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x182980", Offset = "0x182A81")]
		public SharedString fieldName;

		// Token: 0x0401B580 RID: 112000
		[Token(Token = "0x4017FA9")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1829C0", Offset = "0x182AC1")]
		public SharedVariable fieldValue;
	}
}
