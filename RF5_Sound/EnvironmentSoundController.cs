using System;
using Il2CppDummyDll;

namespace RF5_Sound
{
	// Token: 0x02000EBF RID: 3775
	[Token(Token = "0x20009A8")]
	public class EnvironmentSoundController : SEController
	{
		// Token: 0x17000CC0 RID: 3264
		// (get) Token: 0x06006294 RID: 25236 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006295 RID: 25237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A02")]
		public EnvironmentSoundDataTable DataTable
		{
			[Token(Token = "0x60051B3")]
			[Address(RVA = "0x1F38070", Offset = "0x1F38171", VA = "0x1F38070")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AC940", Offset = "0x1ACA41")]
			get
			{
				return null;
			}
			[Token(Token = "0x60051B4")]
			[Address(RVA = "0x1F38080", Offset = "0x1F38181", VA = "0x1F38080")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AC950", Offset = "0x1ACA51")]
			set
			{
			}
		}

		// Token: 0x06006296 RID: 25238 RVA: 0x000211C8 File Offset: 0x0001F3C8
		[Token(Token = "0x60051B5")]
		[Address(RVA = "0x1F38090", Offset = "0x1F38191", VA = "0x1F38090")]
		public bool IsCondition()
		{
			return default(bool);
		}

		// Token: 0x06006297 RID: 25239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051B6")]
		[Address(RVA = "0x1F382A0", Offset = "0x1F383A1", VA = "0x1F382A0", Slot = "10")]
		public override void DoPlay(SoundID id, int priority = 0)
		{
		}

		// Token: 0x06006298 RID: 25240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051B7")]
		[Address(RVA = "0x1F384D0", Offset = "0x1F385D1", VA = "0x1F384D0", Slot = "13")]
		protected override void SetupBeforePlayByDataTable()
		{
		}

		// Token: 0x06006299 RID: 25241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051B8")]
		[Address(RVA = "0x1F385C0", Offset = "0x1F386C1", VA = "0x1F385C0", Slot = "16")]
		protected override void Play_Update()
		{
		}

		// Token: 0x0600629A RID: 25242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051B9")]
		[Address(RVA = "0x1F38660", Offset = "0x1F38761", VA = "0x1F38660", Slot = "20")]
		protected override void Done_Enter()
		{
		}

		// Token: 0x0600629B RID: 25243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051BA")]
		[Address(RVA = "0x1F38790", Offset = "0x1F38891", VA = "0x1F38790", Slot = "21")]
		protected virtual void Done_Update()
		{
		}

		// Token: 0x0600629C RID: 25244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051BB")]
		[Address(RVA = "0x1F383E0", Offset = "0x1F384E1", VA = "0x1F383E0")]
		private void FrightenedMotion(SoundID id)
		{
		}

		// Token: 0x0600629D RID: 25245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051BC")]
		[Address(RVA = "0x1F38850", Offset = "0x1F38951", VA = "0x1F38850")]
		public EnvironmentSoundController()
		{
		}

		// Token: 0x0400C2BF RID: 49855
		[Token(Token = "0x40091EE")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17F2D0", Offset = "0x17F3D1")]
		private EnvironmentSoundDataTable <DataTable>k__BackingField;

		// Token: 0x0400C2C0 RID: 49856
		[Token(Token = "0x40091EF")]
		[FieldOffset(Offset = "0x88")]
		public float Interval;

		// Token: 0x0400C2C1 RID: 49857
		[Token(Token = "0x40091F0")]
		[FieldOffset(Offset = "0x8C")]
		public float IntervalMin;

		// Token: 0x0400C2C2 RID: 49858
		[Token(Token = "0x40091F1")]
		[FieldOffset(Offset = "0x90")]
		public float IntervalMax;

		// Token: 0x0400C2C3 RID: 49859
		[Token(Token = "0x40091F2")]
		[FieldOffset(Offset = "0x94")]
		public bool MarkRemove;

		// Token: 0x0400C2C4 RID: 49860
		[Token(Token = "0x40091F3")]
		[FieldOffset(Offset = "0x98")]
		private float DoneTime;
	}
}
