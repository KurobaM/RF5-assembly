using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000D04 RID: 3332
	[Token(Token = "0x2000895")]
	public abstract class Grounder : MonoBehaviour
	{
		// Token: 0x06005515 RID: 21781
		[Token(Token = "0x60046F9")]
		public abstract void ResetPosition();

		// Token: 0x17000AEC RID: 2796
		// (get) Token: 0x06005516 RID: 21782 RVA: 0x0001C050 File Offset: 0x0001A250
		// (set) Token: 0x06005517 RID: 21783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170008AA")]
		public bool initiated
		{
			[Token(Token = "0x60046FA")]
			[Address(RVA = "0x2C04070", Offset = "0x2C04171", VA = "0x2C04070")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A9B00", Offset = "0x1A9C01")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60046FB")]
			[Address(RVA = "0x2C04080", Offset = "0x2C04181", VA = "0x2C04080")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A9B10", Offset = "0x1A9C11")]
			protected set
			{
			}
		}

		// Token: 0x06005518 RID: 21784 RVA: 0x0001C068 File Offset: 0x0001A268
		[Token(Token = "0x60046FC")]
		[Address(RVA = "0x2C04090", Offset = "0x2C04191", VA = "0x2C04090")]
		protected Vector3 GetSpineOffsetTarget()
		{
			return default(Vector3);
		}

		// Token: 0x06005519 RID: 21785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046FD")]
		[Address(RVA = "0x2C04370", Offset = "0x2C04471", VA = "0x2C04370")]
		protected void LogWarning(string message)
		{
		}

		// Token: 0x0600551A RID: 21786 RVA: 0x0001C080 File Offset: 0x0001A280
		[Token(Token = "0x60046FE")]
		[Address(RVA = "0x2C041E0", Offset = "0x2C042E1", VA = "0x2C041E0")]
		private Vector3 GetLegSpineBendVector(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		// Token: 0x0600551B RID: 21787 RVA: 0x0001C098 File Offset: 0x0001A298
		[Token(Token = "0x60046FF")]
		[Address(RVA = "0x2C043B0", Offset = "0x2C044B1", VA = "0x2C043B0")]
		private Vector3 GetLegSpineTangent(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		// Token: 0x0600551C RID: 21788
		[Token(Token = "0x6004700")]
		protected abstract void OpenUserManual();

		// Token: 0x0600551D RID: 21789
		[Token(Token = "0x6004701")]
		protected abstract void OpenScriptReference();

		// Token: 0x0600551E RID: 21790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004702")]
		[Address(RVA = "0x2C045C0", Offset = "0x2C046C1", VA = "0x2C045C0")]
		protected Grounder()
		{
		}

		// Token: 0x0400B484 RID: 46212
		[Token(Token = "0x40087A3")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x178B20", Offset = "0x178C21")]
		[Attribute(Name = "RangeAttribute", RVA = "0x178B20", Offset = "0x178C21")]
		public float weight;

		// Token: 0x0400B485 RID: 46213
		[Token(Token = "0x40087A4")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x178B80", Offset = "0x178C81")]
		public Grounding solver;

		// Token: 0x0400B486 RID: 46214
		[Token(Token = "0x40087A5")]
		[FieldOffset(Offset = "0x28")]
		public Grounder.GrounderDelegate OnPreGrounder;

		// Token: 0x0400B487 RID: 46215
		[Token(Token = "0x40087A6")]
		[FieldOffset(Offset = "0x30")]
		public Grounder.GrounderDelegate OnPostGrounder;

		// Token: 0x0400B488 RID: 46216
		[Token(Token = "0x40087A7")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x178BC0", Offset = "0x178CC1")]
		private bool <initiated>k__BackingField;

		// Token: 0x02000D05 RID: 3333
		// (Invoke) Token: 0x06005520 RID: 21792
		[Token(Token = "0x20013E8")]
		public delegate void GrounderDelegate();
	}
}
