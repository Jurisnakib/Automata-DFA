
;program - Count Down Oven  




delay macro
    pusha
    ; set 1 million microseconds interval (1 second)
    mov cx, 0fh
    mov dx, 4240h
    mov ah, 86h
    int 15h
    popa 
endm


_DATA segment
    
    RES  DB 10 DUP ('$')
    MSG1 DB 10,13,"Where to start?? (ONLY IN 2 DIGITS) : $"
    MSG2 DB 10,13,"You have (sec) : $"
    
    
_DATA ends 


_CODE segment
    
    assume cs: _CODE, ds: _DATA
        
        
start: 
    mov ax, _DATA
    mov ds, ax  
    
    
    LEA DX,MSG1
    MOV AH,09h
    INT 21H  
    
    
    MOV AH,01h
    INT 21H
   
    SUB AL,30H
    MOV AH,0
   
    MOV BL,10
    MUL BL
    MOV BL,AL
       
    MOV AH,01H
    INT 21H
   
    SUB AL,30H
    MOV AH,0
    ADD AL,BL

    
    rpt:
    cmp al,0
    je end
    
    dec al
    push ax 
  
    
    LEA SI,RES  
    
    
    CALL HEX2DEC 
    
    LEA DX,MSG2
    MOV AH,9
    INT 21H 
   
    LEA DX,RES
    MOV AH,9
    INT 21H
    
    LEA SI,RES
    
    pop ax
    inc si
    mov [si],al
    delay
    jmp rpt 
    
    end:        
    MOV AH,4CH
    INT 21H
    
    
    
_CODE ends

HEX2DEC PROC value
    MOV CX,0
    MOV BX,10
   
LOOP1: MOV DX,0
       DIV BX
       ADD DL,30H
       PUSH DX
       INC CX
       CMP AX,9
       JG LOOP1
     
       ADD AL,30H
       MOV [SI],AL
     
LOOP2: POP AX
       INC SI
       MOV [SI],AL
       LOOP LOOP2
       RET
HEX2DEC ENDP

end start
