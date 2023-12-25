


----创建数据库
create database DATA;
use DATA;

----------创建相关表

-- 用餐用户表
CREATE TABLE 用餐用户 (
    账号 VARCHAR(30) NOT NULL,
    密码 VARCHAR(50) NOT NULL,
    姓名 CHAR(50) NOT NULL,
    手机号 CHAR(15) NOT NULL,
    PRIMARY KEY (账号)
);

-- 窗口信息表
CREATE TABLE 窗口信息 (
    窗口号 CHAR(15) NOT NULL,
    密码 VARCHAR(50) NOT NULL,
    窗口名 VARCHAR(50) NOT NULL,
    PRIMARY KEY (窗口号)
);

-- 餐食表
CREATE TABLE 餐食 (
    餐食号 int identity(1,1) NOT NULL,
    餐食名称 VARCHAR(50) NOT NULL,
    餐食价格 FLOAT(5) NOT NULL,
	介绍 VARCHAR(1000),
	窗口号 char(15),
    制作时长 FLOAT(2) NOT NULL,
    PRIMARY KEY (餐食号),
	FOREIGN KEY (窗口号) REFERENCES 窗口信息(窗口号)
);

-- 订单表
CREATE TABLE 订单 (
    订单号 INT IDENTITY(1,1) NOT NULL,
    餐食号 int NOT NULL,
    窗口号 CHAR(15) NOT NULL,
	账号   VARCHAR(30) NOT NULL,
    创建时间 DATETIME NOT NULL,
    接单时间 DATETIME,
    订单状态 TINYINT NOT NULL CHECK (订单状态 BETWEEN 0 AND 5),
    评价 VARCHAR(1000),
    PRIMARY KEY (订单号),
    FOREIGN KEY (餐食号) REFERENCES 餐食 (餐食号),
    FOREIGN KEY (窗口号) REFERENCES 窗口信息 (窗口号),
	FOREIGN KEY (账号) REFERENCES 用餐用户 (账号)

);

-- 退餐表
CREATE TABLE 退餐 (
    订单号 INT NOT NULL,
    价格 FLOAT(5) NOT NULL,
    订单状态 TINYINT NOT NULL CHECK (订单状态 IN (0, 1)),
    PRIMARY KEY (订单号),
    FOREIGN KEY (订单号) REFERENCES 订单 (订单号)
);


-- 向用餐用户表插入数据
INSERT INTO 用餐用户 (账号, 密码, 姓名, 手机号)
VALUES ('zhangsan', '123456', '张三', '13800000001'),
       ('lisi', 'abcdef', '李四', '13900000002'),
       ('wangwu', '888888', '王五', '13700000003');

-- 向窗口信息表插入数据
INSERT INTO 窗口信息 (窗口号, 密码, 窗口名)
VALUES('C1','123','炸鸡汉堡'), 
('A01', '111111', '一楼一号窗口'),
('A02', '222222', '一楼二号窗口'),
('B01', '333333', '二楼一号窗口');

-- 向餐食表插入数据

INSERT INTO 餐食 (餐食名称, 介绍, 餐食价格,窗口号,制作时长) VALUES
( '披萨', '探索披萨的极致滋味，每一口都是独特的美食体验，搭配新鲜食材和传统工艺，让你沉浸在无穷的披萨诱惑中。',14,'C1',12),
( '香酥鸡腿', '口感香脆，肉质鲜嫩，让你欲罢不能的香酥鸡腿，美味诱惑，一口就爱上。', 3,'C1',3),
( '招牌鸡腿堡', '鲜香鸡腿，脆皮搭配秘制酱料，招牌鸡腿堡，一口咬下，爆发无限滋味。', 8,'C1',6);

-- 向订单表插入数据
INSERT into 订单 (餐食号, 窗口号,账号, 创建时间, 接单时间, 订单状态)
VALUES (1, 'A01', 'zhangsan','2021-10-01 12:00:00', '2021-10-01 12:05:00', 3),
       (2, 'A02', 'lisi','2021-10-01 12:10:00', '2021-10-01 12:15:00', 4),
       (3, 'B01','wangwu', '2021-10-01 12:20:00', NULL, 1);

-- 向退餐表插入数据
INSERT INTO 退餐 (订单号, 价格, 订单状态)
VALUES (3, 20.00, 0);