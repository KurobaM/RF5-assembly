using System;
using Il2CppDummyDll;

namespace nn.irsensor
{
	// Token: 0x02001528 RID: 5416
	[Token(Token = "0x2000EDB")]
	public class ImageTransferProcessorManager
	{
		// Token: 0x17000E8A RID: 3722
		// (get) Token: 0x06007B2E RID: 31534 RVA: 0x0002B5D8 File Offset: 0x000297D8
		[Token(Token = "0x17000B3C")]
		public ImageTransferProcessorState State
		{
			[Token(Token = "0x600674C")]
			[Address(RVA = "0x34DC5C0", Offset = "0x34DC6C1", VA = "0x34DC5C0")]
			get
			{
				return default(ImageTransferProcessorState);
			}
		}

		// Token: 0x17000E8B RID: 3723
		// (get) Token: 0x06007B2F RID: 31535 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06007B30 RID: 31536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B3D")]
		public byte[] ImageBuffer
		{
			[Token(Token = "0x600674D")]
			[Address(RVA = "0x34DC5D0", Offset = "0x34DC6D1", VA = "0x34DC5D0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AF5D0", Offset = "0x1AF6D1")]
			get
			{
				return null;
			}
			[Token(Token = "0x600674E")]
			[Address(RVA = "0x34DC5E0", Offset = "0x34DC6E1", VA = "0x34DC5E0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AF5E0", Offset = "0x1AF6E1")]
			private set
			{
			}
		}

		// Token: 0x06007B31 RID: 31537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600674F")]
		[Address(RVA = "0x34DC5F0", Offset = "0x34DC6F1", VA = "0x34DC5F0", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x06007B32 RID: 31538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006750")]
		[Address(RVA = "0x34DC710", Offset = "0x34DC811", VA = "0x34DC710")]
		public void Initialize(IrCameraHandle handle, ImageTransferProcessorFormat format)
		{
		}

		// Token: 0x06007B33 RID: 31539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006751")]
		[Address(RVA = "0x34DC8C0", Offset = "0x34DC9C1", VA = "0x34DC8C0")]
		public void Initialize(IrCameraHandle handle, ImageTransferProcessorConfig config)
		{
		}

		// Token: 0x06007B34 RID: 31540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006752")]
		[Address(RVA = "0x34DC780", Offset = "0x34DC881", VA = "0x34DC780")]
		public void Initialize(IrCameraHandle handle, ImageTransferProcessorExConfig config)
		{
		}

		// Token: 0x06007B35 RID: 31541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006753")]
		[Address(RVA = "0x34DC900", Offset = "0x34DCA01", VA = "0x34DC900")]
		public void Destroy()
		{
		}

		// Token: 0x06007B36 RID: 31542 RVA: 0x0002B5F0 File Offset: 0x000297F0
		[Token(Token = "0x6006754")]
		[Address(RVA = "0x34DC9D0", Offset = "0x34DCAD1", VA = "0x34DC9D0")]
		public bool IsRunning()
		{
			return default(bool);
		}

		// Token: 0x06007B37 RID: 31543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006755")]
		[Address(RVA = "0x34DC9F0", Offset = "0x34DCAF1", VA = "0x34DC9F0")]
		public void Run()
		{
		}

		// Token: 0x06007B38 RID: 31544 RVA: 0x0002B608 File Offset: 0x00029808
		[Token(Token = "0x6006756")]
		[Address(RVA = "0x34DCA40", Offset = "0x34DCB41", VA = "0x34DCA40")]
		public Result Update()
		{
			return default(Result);
		}

		// Token: 0x06007B39 RID: 31545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006757")]
		[Address(RVA = "0x34DCAE0", Offset = "0x34DCBE1", VA = "0x34DCAE0")]
		public void Stop()
		{
		}

		// Token: 0x06007B3A RID: 31546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006758")]
		[Address(RVA = "0x34DC6A0", Offset = "0x34DC7A1", VA = "0x34DC6A0")]
		private void _Destroy()
		{
		}

		// Token: 0x06007B3B RID: 31547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006759")]
		[Address(RVA = "0x34DCB20", Offset = "0x34DCC21", VA = "0x34DCB20")]
		public ImageTransferProcessorManager()
		{
		}

		// Token: 0x0401BE1A RID: 114202
		[Token(Token = "0x4018794")]
		[FieldOffset(Offset = "0x10")]
		private ImageTransferProcessorState state;

		// Token: 0x0401BE1B RID: 114203
		[Token(Token = "0x4018795")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x194B00", Offset = "0x194C01")]
		private byte[] <ImageBuffer>k__BackingField;

		// Token: 0x0401BE1C RID: 114204
		[Token(Token = "0x4018796")]
		[FieldOffset(Offset = "0x28")]
		private IntPtr pWorkBuffer;

		// Token: 0x0401BE1D RID: 114205
		[Token(Token = "0x4018797")]
		[FieldOffset(Offset = "0x30")]
		private long workBufferSize;

		// Token: 0x0401BE1E RID: 114206
		[Token(Token = "0x4018798")]
		[FieldOffset(Offset = "0x38")]
		private ImageTransferProcessorExConfig config;

		// Token: 0x0401BE1F RID: 114207
		[Token(Token = "0x4018799")]
		[FieldOffset(Offset = "0x60")]
		private IrCameraHandle handle;
	}
}
