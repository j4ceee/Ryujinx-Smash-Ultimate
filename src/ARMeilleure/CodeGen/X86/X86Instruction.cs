namespace ARMeilleure.CodeGen.X86
{
    enum X86Instruction
    {
        None,
        Add,
        Addpd,
        Addps,
        Addsd,
        Addss,
        Aesdec,
        Aesdeclast,
        Aesenc,
        Aesenclast,
        Aesimc,
        And,
        Andnpd,
        Andnps,
        Andpd,
        Andps,
        Blendvpd,
        Blendvps,
        Bsr,
        Bswap,
        Call,
        Cmovcc,
        Cmp,
        Cmppd,
        Cmpps,
        Cmpsd,
        Cmpss,
        Cmpxchg,
        Cmpxchg16b,
        Cmpxchg8,
        Comisd,
        Comiss,
        Crc32,
        Crc32_16,
        Crc32_8,
        Cvtdq2pd,
        Cvtdq2ps,
        Cvtpd2dq,
        Cvtpd2ps,
        Cvtps2dq,
        Cvtps2pd,
        Cvtsd2si,
        Cvtsd2ss,
        Cvtsi2sd,
        Cvtsi2ss,
        Cvtss2sd,
        Cvtss2si,
        Div,
        Divpd,
        Divps,
        Divsd,
        Divss,
        Gf2p8affineqb,
        Haddpd,
        Haddps,
        Idiv,
        Imul,
        Imul128,
        Insertps,
        Jmp,
        Ldmxcsr,
        Lea,
        Maxpd,
        Maxps,
        Maxsd,
        Maxss,
        Minpd,
        Minps,
        Minsd,
        Minss,
        Mov,
        Mov16,
        Mov8,
        Movd,
        Movdqu,
        Movhlps,
        Movlhps,
        Movq,
        Movsd,
        Movss,
        Movsx16,
        Movsx32,
        Movsx8,
        Movzx16,
        Movzx8,
        Mul128,
        Mulpd,
        Mulps,
        Mulsd,
        Mulss,
        Neg,
        Not,
        Or,
        Paddb,
        Paddd,
        Paddq,
        Paddw,
        Palignr,
        Pand,
        Pandn,
        Pavgb,
        Pavgw,
        Pblendvb,
        Pclmulqdq,
        Pcmpeqb,
        Pcmpeqd,
        Pcmpeqq,
        Pcmpeqw,
        Pcmpgtb,
        Pcmpgtd,
        Pcmpgtq,
        Pcmpgtw,
        Pextrb,
        Pextrd,
        Pextrq,
        Pextrw,
        Pinsrb,
        Pinsrd,
        Pinsrq,
        Pinsrw,
        Pmaxsb,
        Pmaxsd,
        Pmaxsw,
        Pmaxub,
        Pmaxud,
        Pmaxuw,
        Pminsb,
        Pminsd,
        Pminsw,
        Pminub,
        Pminud,
        Pminuw,
        Pmovsxbw,
        Pmovsxdq,
        Pmovsxwd,
        Pmovzxbw,
        Pmovzxdq,
        Pmovzxwd,
        Pmulld,
        Pmullw,
        Pop,
        Popcnt,
        Por,
        Pshufb,
        Pshufd,
        Pslld,
        Pslldq,
        Psllq,
        Psllw,
        Psrad,
        Psraw,
        Psrld,
        Psrlq,
        Psrldq,
        Psrlw,
        Psubb,
        Psubd,
        Psubq,
        Psubw,
        Punpckhbw,
        Punpckhdq,
        Punpckhqdq,
        Punpckhwd,
        Punpcklbw,
        Punpckldq,
        Punpcklqdq,
        Punpcklwd,
        Push,
        Pxor,
        Rcpps,
        Rcpss,
        Ror,
        Roundpd,
        Roundps,
        Roundsd,
        Roundss,
        Rsqrtps,
        Rsqrtss,
        Sar,
        Setcc,
        Sha256Msg1,
        Sha256Msg2,
        Sha256Rnds2,
        Shl,
        Shr,
        Shufpd,
        Shufps,
        Sqrtpd,
        Sqrtps,
        Sqrtsd,
        Sqrtss,
        Stmxcsr,
        Sub,
        Subpd,
        Subps,
        Subsd,
        Subss,
        Test,
        Unpckhpd,
        Unpckhps,
        Unpcklpd,
        Unpcklps,
        Vblendvpd,
        Vblendvps,
        Vcvtph2ps,
        Vcvtps2ph,
        Vfmadd231ps,
        Vfmadd231sd,
        Vfmadd231ss,
        Vfmsub231sd,
        Vfmsub231ss,
        Vfnmadd231ps,
        Vfnmadd231sd,
        Vfnmadd231ss,
        Vfnmsub231sd,
        Vfnmsub231ss,
        Vpblendvb,
        Vpternlogd,
        Xor,
        Xorpd,
        Xorps,

        Count,
    }
}
