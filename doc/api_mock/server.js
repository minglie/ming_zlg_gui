M=require("ming_node")
app=M.server();
app.listen(8888)

app.set("views","./")

a=[
    0x00,0x00,0x00,0x00,0x00,0x00,0xFF,0xFF,0xF8,0x03,0x83,0x3F,0xFF,0xFF,0xFF,0xFF,
    0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFC,0x7F,0xFF,0xF0,0x00,0x00,0x00,0x00,
    0x00,0x00,0x00,0x00,0x7F,0xFF,0xFE,0x01,0xC2,0x3F,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,
    0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xF8,0xFF,0xFF,0xF0,0x00,0x00,0x00,0x00,0x00,0x00,
    0x00,0x00,0x1F,0xFF,0xFF,0x80,0xE4,0x7F,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,
    0xFF,0xFF,0xFF,0xFF,0xC1,0xFF,0xFF,0xF0,0x00,0x00,0xC0,0x00,0x00,0x00,0x00,0x00,
    0x0F,0xFF,0xFF,0xC0,0x3C,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,
    0xFF,0xFF,0x07,0xFF,0xFF,0xE0,0x00,0x00,0xF0,0x00,0x00,0x00,0x00,0x00,0x07,0xFF,
    0xFF,0xF0,0x09,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,
    0x0F,0xFF,0xFF,0xE0,0x00,0x00,0xF8,0x00,0x00,0x00,0x00,0x00,0x03,0xFF,0xFF,0xFC,
    0x01,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFE,0x3F,0xFF,
    0xFF,0xE0,0x00,0x00,0xFC,0x00,0x00,0x00,0x00,0x00,0x00,0xFF,0xFF,0xFF,0x83,0xFF,
    0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFE,0xFF,0xFF,0xFF,0xC0,
    0x00,0x00,0xF8,0x00,0x00,0x00,0x00,0x00,0x00,0x7F,0xFF,0xFF,0xC7,0xFF,0xFF,0xFF,
    0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xC0,0x00,0x00,
    0xE0,0x00,0x00,0x00,0x00,0x00,0x00,0x1F,0xFF,0xFF,0xEF,0xFF,0xFF,0xFF,0xFF,0xFF,
    0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0x88,0x00,0x00,0xC0,0x00,
    0x00,0x00,0x00,0x00,0x00,0x1F,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,
    0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0x88,0x00,0x00,0xF0,0x00,0x00,0x00,
    0x00,0x00,0x00,0x0F,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,
    0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0x0C,0x00,0x00,0xF8,0x00,0x00,0x00,0x00,0x00,
    0x00,0x07,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,
    0xFF,0xFF,0xFF,0xFF,0xFE,0x0E,0x00,0x00,0xFC,0x00,0x00,0x00,0x00,0x00,0x00,0x03,
    0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,
    0xFF,0xFF,0xFE,0x0F,0x00,0x00,0xFC,0x00,0x00,0x00,0x00,0x00,0x00,0x01,0xFF,0xFF,
    0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,
    0xFC,0x1F,0xE0,0x00,0xC0,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x7F,0xFF,0xFF,0xFF,
    0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFC,0x1F,
    0xF8,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x7F,0xFF,0xFF,0xFF,0xFF,0xFF,
    0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xF8,0x1F,0xFC,0x00,
    0xF8,0x00,0x00,0x00,0x00,0x00,0x0F,0xFF,0xB0,0x00,0x7F,0xFF,0xFF,0xFF,0xFF,0xFF,
    0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xF0,0x3F,0xFC,0x00,0xFF,0x00,
    0x00,0x00,0x00,0x01,0xFF,0x80,0x03,0xE0,0x7F,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,
    0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xE0,0x3F,0xFF,0x80,0xFF,0x80,0x00,0x00,
    0x00,0x0F,0xF8,0x03,0xFF,0xF0,0x7F,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,
    0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xC0,0x3F,0xFF,0xC0,0xFC,0x00,0x00,0x00,0x00,0xFF,
    0x00,0x01,0xFF,0xFE,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,
    0xFF,0xFF,0xFF,0xFF,0x80,0x7F,0xFF,0xE0,0xFE,0x00,0x00,0x00,0x03,0xF0,0x00,0x00,
    0x00,0x03,0xFF,0xFF,0xFF,0xFF,0xFF,0xF7,0xFF,0xFF,0xFF,0xFE,0xFF,0xFF,0xFF,0xFF,
    0xFF,0xFF,0x00,0x7F,0xFF,0xE0,0xFF,0xF0,0x00,0x00,0x3F,0x80,0x00,0x7F,0xFF,0xFF,
    0xFF,0xFC,0x1F,0xFF,0xFF,0xEF,0xFF,0xFF,0xFF,0xE1,0xFF,0xFF,0xFF,0xFF,0xFF,0xFE,
    0x00,0x7F,0xFF,0xE0,0xFF,0xF8,0x00,0x00,0x7F,0x00,0x3F,0xFF,0xFF,0xFF,0xFF,0xF8,
    0x7F,0xFF,0xFF,0x8F,0xFF,0xFF,0xFF,0x07,0xFF,0xFF,0xFF,0xFF,0xFF,0xFE,0x00,0x7F,
    0xFF,0xF0,0xFF,0xF8,0x00,0x01,0xF9,0xE7,0xFF,0xFF,0xFF,0xFF,0xFF,0xF0,0x7F,0xFF,
    0xFF,0x9F,0xFF,0xFF,0xFF,0x0F,0xFF,0xFF,0xFF,0xFF,0xFF,0xF8,0x00,0x7F,0xFF,0xF8,
    0xFF,0xF8,0x00,0x07,0xEF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xE1,0xFF,0xFF,0xFE,0x1F,
    0xFF,0xFF,0xFE,0x0F,0xFF,0xFF,0xFF,0xFF,0xFF,0xF0,0x00,0x7F,0xFF,0xFE,0xFF,0x80,
    0x00,0x1F,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xC3,0xFF,0xFF,0xFC,0x3F,0xFF,0xFF,
    0xFF,0x3F,0xFF,0x7F,0xFF,0xFF,0xFF,0xFF,0xC0,0x7F,0xFF,0xFF,0xFF,0xE0,0x00,0x7F,
    0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0x87,0xFF,0xFF,0xFC,0x77,0xFF,0xFF,0xFC,0x7F,
    0xFE,0xFF,0xFF,0xFF,0xFF,0xFF,0xC0,0x7F,0xFF,0xFF,0xFF,0xE0,0x01,0xFF,0xFF,0xFF,
    0xFF,0xFF,0xFF,0xFF,0xFF,0x8F,0xFF,0xFF,0xDC,0x6F,0xFF,0xFF,0xF8,0xFF,0xFC,0xFF,
    0xFF,0xFF,0xFF,0xFF,0x80,0xFF,0xFF,0xFF,0xFF,0xFC,0x07,0xF7,0xFF,0xFF,0xFF,0xFF,
    0xFF,0xFF,0xFF,0x1F,0xFF,0xFF,0x98,0x1F,0xFF,0xFF,0xF1,0xFF,0xF9,0xFF,0xFF,0xFF,
    0xFF,0xFE,0x00,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,
    0xFF,0x3F,0xFF,0xFE,0x18,0x1F,0xFF,0xFF,0xE3,0xFF,0xF1,0xFF,0xFF,0xFF,0xFF,0xFC,
    0x00,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFE,0x7F,
    0xFF,0xF8,0x38,0x3F,0xFF,0xFF,0xCF,0xFF,0xF1,0xFF,0xFF,0xFF,0xFF,0xF0,0x00,0xFF,
    0xFF,0xFE,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFC,0x7F,0xFF,0xF0,
    0x30,0x7F,0xFF,0xFF,0x9F,0xFF,0xF1,0xFF,0xFF,0xFF,0xFF,0xE0,0x00,0xFF,0xFF,0xFE,
    0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFC,0xFF,0xFF,0xC0,0x30,0xFF,
    0xFF,0xFF,0x3F,0xFF,0xF3,0xFF,0xFF,0xFF,0xFF,0x80,0x00,0xFF,0xFF,0xFE,0xFF,0xFF,
    0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xF9,0xFF,0xFF,0x00,0x70,0xFF,0xFF,0xFC,
    0x7F,0xFF,0xE3,0xFF,0xFF,0xFF,0xFF,0x00,0x00,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,
    0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xF3,0xFF,0xFC,0x00,0x61,0xFF,0xFF,0xF8,0xFF,0xFF,
    0xE3,0xFF,0xFF,0xFF,0xFC,0x00,0x00,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,
    0xFF,0xFF,0xFF,0xFF,0xF3,0xFF,0xF8,0x00,0x63,0xFF,0xFF,0xF1,0xFF,0xFF,0xE3,0xFF,
    0xFF,0xFF,0xF8,0x00,0x00,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,
    0xFF,0xFF,0xE7,0xFF,0xE0,0x00,0x43,0xFF,0xFF,0xE7,0xFF,0xFF,0xE7,0xFF,0xFF,0xFF,
    0xF0,0x00,0x00,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xC0,0x0F,0xFF,0xFF,0xFF,0xFF,0xFF,
    0xEF,0xFF,0x80,0x00,0xC7,0xFF,0xFF,0x8F,0xFF,0xFF,0xE7,0xFF,0xFF,0xFF,0xE0,0x00,
    0x01,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0x80,0x01,0xFF,0xFF,0xFF,0xFF,0xFF,0xCF,0xFF,
    0xC0,0x00,0xCF,0xFF,0xFF,0x1F,0xFF,0xFF,0xCF,0xFF,0xFF,0xFF,0xC0,0x00,0x03,0xFF,
    0xFF,0xFF,0xFF,0xFF,0xFE,0x00,0x00,0x1F,0xFF,0xFF,0xFF,0xFF,0xDF,0xFF,0xC0,0x01,
    0x9F,0xFF,0xFC,0x3F,0xFF,0xFE,0xCF,0xFF,0xFF,0xFF,0x80,0x00,0x03,0xFF,0xFF,0xFF,
    0xFF,0xFF,0xF0,0x00,0x00,0x03,0xFF,0xFF,0xFF,0xFF,0xDF,0xFF,0xC0,0x01,0xBF,0xFF,
    0xFC,0xFF,0xFF,0xF8,0xDF,0xFF,0xFF,0xFF,0x00,0x00,0x07,0xFF,0xFF,0xFF,0xFF,0xFF,
    0xC0,0x00,0x00,0x00,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xC8,0x01,0x3F,0xFF,0xF1,0xFF,
    0xFF,0xF1,0xFF,0xFF,0xFF,0xFE,0x00,0x00,0x07,0xFF,0xFF,0xFF,0xFF,0xFF,0x83,0x80,
    0x00,0x00,0x3F,0xFF,0xFF,0xFF,0xBF,0xDF,0x87,0x83,0x7F,0xFF,0xE7,0xFF,0xFF,0xC1,
    0xBF,0xF7,0xFF,0xFC,0x00,0x00,0x07,0xFF,0xFF,0xFF,0xFF,0xFC,0x07,0x00,0x00,0x00,
    0x0F,0xFF,0xFF,0xFF,0xFF,0x8F,0x8F,0xE2,0x7F,0xFF,0xCF,0xFF,0xFF,0x81,0xFF,0xEF,
    0xFF,0xF8,0x00,0x00,0x0F,0xFF,0xFF,0xFF,0xFF,0xFC,0x18,0x00,0x00,0x00,0x07,0xFF,
    0xFF,0xFF,0xFF,0xCF,0x3F,0xF6,0xFF,0xFF,0x7F,0xFF,0xFF,0x03,0xFF,0xCF,0xFF,0xF0,
    0x00,0x00,0x1F,0xFF,0xFF,0xFF,0xFF,0xF8,0x78,0x00,0x00,0x00,0x00,0xFF,0xFF,0xFF,
    0xFF,0xE6,0x3F,0xFD,0xFF,0xFD,0xFF,0xFF,0xF8,0x03,0xFF,0xDF,0xFF,0xE0,0x00,0x00,
    0x1F,0xFF,0xFF,0xFF,0xFF,0xFF,0xF8,0x00,0x00,0x00,0x00,0x3F,0xFF,0xFF,0xFD,0x26,
    0x7F,0xFD,0xFF,0xF3,0xFF,0xFF,0xF0,0x07,0xFF,0xDF,0xFF,0xC0,0x00,0x00,0x3F,0xFF,
    0xFF,0xFF,0xFF,0xF8,0xF6,0x00,0x00,0x00,0x00,0x1F,0xFF,0xFF,0xF8,0x34,0x6F,0xFB,
    0xFF,0xFF,0xFF,0xFF,0xC0,0x07,0xFF,0xDF,0xFF,0x80,0x00,0x00,0x7F,0xFF,0xFF,0xFF,
    0xFF,0xF8,0x00,0x00,0x00,0x00,0x00,0x0F,0xFF,0xFF,0xF0,0x1C,0x7F,0xFF,0xFF,0xFF,
    0xFF,0xFF,0x90,0x0F,0xFF,0xFF,0xFF,0x80,0x00,0x00,0x7F,0xFF,0xFF,0xFF,0xFF,0xFC,
    0x00,0x00,0x00,0x00,0x00,0x03,0xFF,0xFF,0xF0,0x3E,0x3F,0xF7,0xFF,0xFF,0xFF,0xFE,
    0x60,0x1F,0xFF,0xFF,0xFF,0x00,0x00,0x00,0xFF,0xFF,0xFF,0xFF,0xFB,0xFE,0x00,0x00,
    0x00,0x00,0x00,0x00,0xFF,0xFF,0xF8,0x76,0x11,0xFF,0xFF,0xFF,0xFF,0xF9,0x60,0x3F,
    0xFF,0x2F,0xFF,0x80,0x00,0x00,0xFF,0xFF,0xFF,0xFF,0xFF,0xFE,0x00,0x00,0x00,0x00,
    0x00,0x00,0x7F,0xFF,0xF8,0x42,0x00,0xFF,0xFF,0xFF,0xFF,0xE3,0xC0,0x7F,0xFF,0xEF,
    0xEF,0xE0,0x00,0x01,0xFF,0xFF,0xFF,0xFF,0xFF,0xFE,0x00,0x00,0x00,0x00,0x00,0x00,
    0x0F,0xFF,0xFC,0x63,0x00,0xFF,0xFF,0xFF,0xFC,0x07,0x81,0xFF,0xC0,0x7F,0xCF,0xF0,
    0x00,0x01,0xFF,0xFF,0xFF,0xFF,0x1F,0xFE,0x00,0x00,0x00,0x00,0x00,0x00,0x38,0x1F,
    0xFC,0x21,0x01,0xFF,0xFF,0xFC,0x00,0x0F,0x03,0xFE,0x40,0xFF,0x9F,0xF0,0x00,0x01,
    0xFF,0xFF,0xFF,0xFF,0x3F,0xFF,0x80,0x00,0x00,0x00,0x00,0x01,0xE0,0x3F,0xFE,0x21,
    0x03,0xFF,0xFE,0x06,0x00,0x0E,0x07,0xF8,0xC0,0xFF,0x3F,0xFC,0x00,0x03,0xFF,0xFF,
    0xFF,0xFF,0x7F,0xFF,0x80,0x00,0x00,0x00,0x01,0x8F,0x00,0xFF,0xFE,0x15,0x83,0xFC,
    0x7F,0x03,0x00,0x1C,0x0F,0xE0,0x80,0xFE,0x3F,0xFC,0x00,0x03,0xFF,0xFF,0xFF,0xFF,
    0xFF,0xFF,0x00,0x00,0x00,0x00,0x00,0x78,0x07,0xFF,0xFF,0x17,0x87,0xF0,0x3F,0x81,
    0x00,0x10,0x1F,0xC0,0xC1,0xFC,0x7F,0xFE,0x00,0x07,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,
    0xC0,0x00,0x00,0x00,0x07,0xC0,0x7F,0xFF,0xFF,0x99,0x8F,0xC0,0x3F,0xC1,0x80,0x30,
    0x7F,0x00,0x81,0xF8,0xFF,0xFF,0x00,0x07,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xC0,0x00,
    0x02,0x00,0x1C,0x07,0xFF,0xFF,0xFF,0xC0,0xDE,0x40,0x1F,0xE0,0xC0,0x01,0xFF,0x00,
    0x81,0xE1,0xFF,0xFF,0x80,0x0F,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xF0,0x00,0x03,0x07,
    0x00,0x7F,0xFF,0xFF,0xFF,0xE2,0x78,0x60,0x1F,0xF0,0x60,0x03,0xFF,0x00,0x01,0xC7,
    0xFF,0xFF,0x80,0x0F,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xE8,0x00,0x7F,0xFB,0xFF,0xFF,
    0xFF,0xFF,0xFF,0xE3,0xC0,0x00,0x0F,0xFC,0x00,0x07,0xFE,0x00,0x03,0x87,0xFF,0xFF,
    0xC0,0x0F,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0x80,0x02,0x3F,0xFF,0xFF,0xFF,0xFF,0xFF,
    0xFF,0xF0,0xE0,0x00,0x07,0xFE,0x00,0x0F,0xFC,0x02,0x03,0x07,0xFF,0xFF,0xC0,0x1F,
    0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0x80,0x00,0x3F,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xF8,
    0x20,0x00,0x00,0x1F,0x00,0x1F,0x78,0x1E,0x02,0x1F,0xFF,0xFF,0xC0,0x1F,0xFF,0xFF,
    0xFF,0xFF,0xFF,0xFF,0xC0,0x10,0x73,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFC,0x20,0x00,
    0x00,0x07,0xC0,0x7C,0x03,0xF0,0x06,0x3F,0xFF,0xFF,0xC0,0x3F,0xFF,0xFF,0xFF,0xFF,
    0xFF,0xFF,0xC0,0x00,0x70,0x3F,0xFF,0xFF,0xFF,0xFF,0xFF,0xFE,0x30,0x00,0x00,0x01,
    0x80,0x30,0x04,0x00,0x06,0x7F,0xFF,0xFF,0xC0,0x3F,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,
    0xE0,0x03,0xF8,0x07,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xD0,0x00,0x01,0x00,0x00,0x00,
    0x00,0x7E,0x85,0xFF,0xFF,0xFF,0xC0,0x7F,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,
    0xFC,0x00,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xF0,0x00,0x00,0x00,0x00,0x00,0x00,0xF7,
    0xCF,0xFF,0xFF,0xFF,0xE0,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFD,0xFC,0x00,
    0x1F,0xFF,0xFF,0xFF,0xFF,0xFF,0xF8,0x00,0x00,0x00,0x00,0x00,0x07,0x88,0x0F,0xFF,
    0xFF,0xFF,0xE0,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0x00,0x60,0xFF,
    0xFF,0xFF,0x83,0xFF,0xE8,0x00,0x00,0x00,0x00,0x00,0x3C,0x00,0x1F,0xFF,0xFF,0xFF,
    0xE1,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFC,0x3F,0xFF,0xFE,
    0x0F,0xFF,0xC8,0x00,0x70,0x00,0x00,0x0F,0xF0,0x00,0x1F,0xFF,0xFF,0xFF,0xE7,0xFF,
    0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFC,0xFF,0xFF,0xFC,0xFF,0xFF,0xF8,0x3F,0xFF,
    0xC8,0x00,0x00,0x00,0x00,0x07,0x00,0x00,0x3F,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,
    0xFF,0xFF,0xFF,0xFF,0xFF,0xFE,0x7C,0x1F,0xFF,0xFF,0xFF,0xE1,0xFF,0xFF,0xCC,0x00,
    0x00,0x00,0x02,0x00,0x00,0x00,0x3F,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,
    0xFF,0xFF,0xFF,0xFE,0x70,0x0F,0xFF,0xFF,0xF3,0xCF,0xFF,0xFF,0xC4,0x00,0x00,0x00,
    0x03,0x00,0x00,0x00,0x33,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,
    0xFF,0xFF,0x00,0x0F,0xFF,0xFF,0xEF,0x7F,0xFF,0xFF,0xC4,0x00,0x00,0x00,0x03,0x00,
    0x00,0x00,0x7F,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,
    0x83,0xFF,0xFF,0xFF,0x7F,0xFF,0xFF,0xFF,0x86,0x00,0x00,0x00,0x03,0x80,0x00,0x00,
    0x7F,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,
    0xFF,0xF9,0xFF,0xFF,0xFF,0xFF,0x82,0x00,0x00,0x00,0x02,0x80,0x00,0x00,0xDF,0x7F,
    0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xDF,
    0xFF,0xFF,0xFF,0xFF,0x83,0x00,0x00,0x00,0x02,0xC0,0x00,0x00,0xC0,0x3F,0xFF,0xFF,
    0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xC7,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,
    0xFF,0xFC,0x81,0x80,0x00,0x00,0x02,0x40,0x00,0x01,0x80,0x0F,0xFF,0xFF,0xFF,0xFF,
    0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xF1,0xFF,0xFF,0xFD,0xFF,0xFF,0xFF,0xFF,0xFC,
    0x80,0x80,0x00,0x00,0x04,0x40,0x00,0x01,0x80,0x0F,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,
    0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xF8,0x40,0x07,0xFF,0xFC,0x08,0x80,0xC0,
    0x00,0x00,0x06,0xC0,0x00,0x03,0x00,0x07,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,
    0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xF8,0xFE,0x00,0x00,0x00,0x11,0x80,0x60,0x00,0x00,
    0x67,0x80,0x00,0x06,0x00,0x0F,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,
    0xF9,0xFF,0xFF,0xFF,0xE0,0x7F,0xC0,0x00,0x00,0x31,0x80,0x30,0x00,0x00,0x3F,0x00,
    0x00,0x0C,0x00,0x17,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,
    0xFF,0xFF,0xE7,0xFE,0x00,0x00,0x00,0x61,0x00,0x1C,0x00,0x00,0x0E,0x18,0x00,0x3C,
    0x00,0x33,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,
    0xFF,0x08,0x00,0x00,0x00,0xC1,0x00,0x06,0x00,0x00,0x1F,0xC0,0x00,0x74,0x00,0x63,
    0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFC,0x00,
    0x00,0x00,0x01,0x81,0x00,0x03,0x00,0x00,0x00,0x00,0x00,0x64,0x00,0x43,0xFF,0xFF,
    0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFC,0xE0,0x00,0x00,
    0x01,0x01,0x00,0x01,0x80,0x00,0x00,0x00,0x00,0xE4,0x00,0xC3,0xFF,0xFF,0xFF,0xFF,
    0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xF9,0xFE,0x00,0x00,0x03,0x01,
    0x00,0x00,0xC0,0x00,0x00,0x00,0x01,0xE4,0x01,0x03,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,
    0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFD,0xF6,0x00,0x00,0x02,0x01,0x00,0x00,
    0x70,0x00,0x03,0xE0,0x03,0x64,0x01,0x01,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,
    0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0x7F,0xFA,0x00,0x00,0x1E,0x01,0x00,0x00,0x1C,0x00,
    0x1F,0xE0,0x0E,0x64,0x07,0x01,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,
    0xFF,0xFF,0xFF,0xFF,0xBF,0xB8,0x00,0x00,0xFC,0x01,0x00,0x00,0x06,0x00,0x00,0x00,
    0x1C,0x44,0x06,0x01,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,
    0xFF,0xFF,0x3F,0xBC,0x00,0x03,0xF8,0x01,0x00,0x00,0x03,0x80,0x00,0x00,0x18,0x44,
    0x0C,0x01,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,
    0xFC,0x08,0x00,0x0F,0xF0,0x03,0x00,0x00,0x41,0xC0,0x00,0x00,0x70,0x46,0x08,0x00,
    0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFC,0x00,
    0x00,0x1F,0xF0,0x03,0x00,0x00,0x60,0x70,0x00,0x00,0xE0,0x47,0x18,0x00,0xFF,0xFF,
    0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFC,0x00,0x00,0x7F,
    0xE0,0x03,0x00,0x00,0x10,0x1C,0x00,0x01,0xC4,0x47,0x30,0x00,0xFF,0xFF,0xFF,0xFF,
    0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFC,0x7E,0x0C,0xFF,0xE0,0x03,
    0x00,0x00,0x18,0x0F,0x00,0x03,0x8C,0x43,0x20,0x00,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,
    0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFE,0x09,0xFF,0xC0,0x0F,0x00,0x00,
    0x0C,0x03,0xC0,0x0E,0x38,0x43,0x60,0x00,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,
    0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0x03,0xFF,0x80,0x0F,0x00,0x00,0x03,0x00,
    0xF8,0x18,0x30,0x40,0x40,0x00,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,
    0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0x9F,0xFF,0x80,0x0C,0x00,0x00,0x01,0x80,0x3F,0xF0,
    0x70,0x40,0x00,0x00,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,
    0xFF,0xFF,0xFF,0xFF,0xFB,0xFF,0x80,0x0C,0x00,0x00,0x00,0x80,0x00,0x00,0x70,0x48,
    0x80,0x00,0x7F,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,
    0xFF,0xFF,0xE3,0xFF,0x80,0x18,0x00,0x00,0x00,0xC0,0x00,0x00,0xE0,0x48,0x80,0x00,
    0x7F,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFE,
    0x03,0xFF,0x00,0x18,0x00,0x00,0x00,0x20,0x00,0x00,0xC0,0xC9,0x80,0x00,0x7F,0xFF,
    0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xF8,0x03,0xFF,
    0x00,0x18,0x00,0x00,0x02,0x18,0x00,0x01,0x80,0x8B,0x00,0x00,0x7F,0xFF,0xFF,0xFF,
    0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xE0,0x03,0xFE,0x00,0x30,
    0x00,0x00,0x02,0x0C,0x00,0x01,0x00,0x8A,0x00,0x00,0x7F,0xFF,0xFF,0xFF,0xFF,0xFF,
    0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xE0,0x07,0xFE,0x00,0x30,0x00,0x00,
    0x00,0x02,0x00,0x01,0x00,0x8E,0x00,0x00,0xFF,0xFE,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,
    0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xC0,0x07,0xFC,0x00,0x30,0x00,0x00,0x00,0x01,
    0x00,0x01,0x01,0x8E,0x00,0x01,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,
    0xFF,0xFF,0xFF,0xFF,0xFF,0xC0,0x1F,0xFC,0x00,0x70,0x00,0x00,0x00,0x01,0x80,0x01,
    0x81,0x8C,0x00,0x01,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,
    0xFF,0xFF,0xFF,0xC0,0x3F,0xF8,0x00,0x70,0x00,0x00,0x00,0x00,0x40,0x00,0x81,0x0C,
    0x00,0x03,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,
    0xFF,0xC0,0xFF,0xF8,0x00,0xE0,0x00,0x00,0x00,0xE0,0x70,0x00,0x81,0x08,0x00,0x07,
    0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0x80,
    0xFF,0xF8,0x00,0x60,0x00,0x00,0x00,0x40,0x18,0x00,0x01,0x08,0x00,0x0F,0xFF,0xFF,
    0xFF,0xFF,0xFF,0xFF,0xFF,0xFA,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0x80,0xFF,0xF8,
    0x00,0x60,0x00,0x00,0x00,0x28,0x0C,0x00,0x03,0x08,0x00,0x1F,0xFF,0xFF,0xFF,0xFF,
    0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0x00,0xFF,0xF8,0x00,0xE0,
    0x00,0x00,0x00,0x30,0x06,0x00,0x03,0x08,0x00,0x3F,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,
    0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0x00,0x7F,0xF8,0x01,0xE0,0x00,0x00,
    0x00,0x18,0x03,0x00,0x03,0x08,0x00,0x7F,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,
    0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0x00,0x7F,0xF8,0x00,0x00,0x00,0x00,0x00,0x06,
    0x01,0x80,0x02,0x00,0x00,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,
    0xFF,0xFF,0xFF,0xFF,0xFE,0x00,0x7F,0xFC,0x00,0x00,0x00,0x00,0x00,0x07,0x00,0xC0,
    0x02,0x00,0x01,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,
    0xFF,0xFF,0xFE,0x00,0x3F,0xFC,0x01,0x00,0x00,0x00,0x00,0x02,0x80,0x70,0x04,0x00,
    0x03,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,
    0xFE,0x00,0x00,0x7C,0x00,0x00,0x00,0x00,0x00,0x01,0xC0,0x18,0x00,0x08,0x07,0xFF,
    0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0x80,
    0x00,0x0F,0x00,0x00,0x00,0x00,0x00,0x01,0xC0,0x08,0x00,0x08,0x0F,0xFF,0xFF,0xFF,
    0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xC0,0x00,0x00,
    0x00,0x00,0x00,0x00,0x00,0x01,0xA0,0x04,0x00,0x08,0x1F,0xFF,0xFF,0xFF,0xFF,0xFF,
    0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xE0,0x00,0x00,0x00,0x00,
    0x00,0x00,0x00,0x00,0xF0,0x03,0x7F,0xFD,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,
    0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xF8,0x00,0x00,0x01,0xC0,0x00,0x00,
    0x00,0x00,0x58,0x01,0xE0,0x00,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,
    0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xF8,0x00,0x00,0x7C,0x00,0x00,0x00,0x00,
    0x68,0x00,0x00,0x03,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,
    0xFF,0xFF,0xFF,0xFF,0x00,0x3F,0xFF,0x80,0x00,0x07,0x00,0x00,0x00,0x00,0x30,0x20,
    0x00,0x07,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,
    0xFF,0xFF,0x00,0x01,0xFF,0xF0,0x00,0x01,0xC0,0x00,0x00,0x00,0x10,0x00,0x00,0x0F,
    0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,
    0x00,0x00,0x1F,0xFF,0x00,0x00,0x70,0x00,0x00,0x00,0x30,0x00,0x00,0x1F,0xFF,0xFF,
    0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0x00,0x00,
    0x01,0xFF,0xC0,0x00,0x0C,0x00,0x00,0x00,0x28,0x00,0x00,0x7F,0xFF,0xFF,0xFF,0xFF,
    0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFE,0x00,0x00,0x00,0x7F,
    0xF8,0x00,0x07,0x00,0x00,0x00,0x60,0x00,0x00,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,
    0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFE,0x00,0x00,0x00,0x0F,0xFF,0x80,
    0x01,0xE0,0x00,0x01,0xC0,0x00,0x03,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,
    0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFE,0x00,0x00,0x00,0x01,0xFF,0xF8,0x00,0x10,
    0x00,0x06,0x00,0x00,0x07,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,
    0xFF,0xFF,0xFF,0xFF,0xFF,0xFE,0x00,0x00,0x00,0x00,0x7F,0xFE,0x00,0x00,0x00,0x08,
    0x00,0x00,0x1F,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,
    0xFF,0xFF,0xFF,0xFE,0x00,0x00,0x00,0x00,0x1F,0xFF,0x80,0x03,0x00,0x30,0x00,0x00,
    0x3F,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,
    0xFF,0xFE,0x00,0x00,0x00,0x00,0x07,0xFF,0xE0,0x01,0xC0,0xC0,0x00,0x00,0x7F,0xFF,
    0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFE,
    0x00,0x00,0x18,0x00,0x01,0xFF,0xF8,0x00,0x70,0x80,0x00,0x01,0xFF,0xFF,0xFF,0xFF,
    0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFE,0x00,0x00,
    0x0F,0x00,0x00,0xFF,0xFE,0x00,0x1E,0x00,0x00,0x07,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,
    0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xF8,0x00,0x00,0x03,0xE0,
    0x00,0x3F,0xFF,0x00,0x04,0x00,0x00,0x1F,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,
    0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xE0,0x00,0x00,0x00,0x78,0x00,0x07,
    0xFF,0x00,0x00,0x00,0x00,0x7F,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,
    0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0x80,0x00,0x00,0x00,0x3E,0x00,0x03,0xFF,0x80,
    0x00,0x80,0x01,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,
    0x7F,0xFF,0xFF,0xFF,0xFF,0x00,0x00,0x00,0x00,0x0F,0x80,0x01,0xFF,0xC0,0x00,0xFF,
    0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0x1F,0xFF,
    0xFF,0xFF,0xFE,0x00,0x00,0x00,0x00,0x03,0xE0,0x00,0x7F,0xC0,0x00,0x7F,0xFF,0xFF,
    0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0x0F,0xFF,0xFF,0xFF,
    0xFC,0x00,0x00,0x00,0x00,0x01,0xF8,0x00,0x3F,0xC0,0x00,0x3F,0xFF,0xFF,0xFF,0xFF,
    0xFF,0xFF,0xFF,0xFF,0xBF,0xFF,0xFF,0xFF,0xFF,0xFF,0x00,0x00,0x00,0x00,0x00,0x00,
    0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,
    0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,
    0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,
    0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,
    0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,
    0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,
    0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,
    0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,
    0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00
]

M.writeFile("a.json", JSON.stringify(a)) 



