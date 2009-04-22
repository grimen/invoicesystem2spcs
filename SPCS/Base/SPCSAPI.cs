using System;
using System.Runtime.InteropServices;
using System.Text;

namespace SPCS
{
    [ComVisible(true), GuidAttribute("029bcc96-6a8b-11dc-8314-0800200c9a66")]
    [ProgId("SPCS.API")]
    [ClassInterface(ClassInterfaceType.None)]
    public static class SPCSAPI
    {
        #region +++ Public API Constans +++
        
        public static int ADKI_ADMIN2000 = 1;
        public static int ADKI_ADMIN1000 = 2;
        public static int ADKI_ADMIN500 = 3;
        public static int ADKI_FORENING = 4;
        
        public static int ADK_DB_CUSTOMER = 0;
        public static int ADK_DB_ARTICLE = 1;
        public static int ADK_DB_ORDER_HEAD = 2;
        public static int ADK_DB_ORDER_ROW = 3;
        public static int ADK_DB_OFFER_HEAD = 4;
        public static int ADK_DB_OFFER_ROW = 5;
        public static int ADK_DB_INVOICE_HEAD = 6;
        public static int ADK_DB_INVOICE_ROW = 7;
        public static int ADK_DB_SUPPLIER_INVOICE_HEAD = 8;
        public static int ADK_DB_SUPPLIER_INVOICE_ROW = 9;
        public static int ADK_DB_PROJECT = 10;
        public static int ADK_DB_ACCOUNT = 11;
        public static int ADK_DB_SUPPLIER = 12;
        public static int ADK_DB_CODE_OF_TERMS_OF_DELIVERY = 13;
        public static int ADK_DB_CODE_OF_WAY_OF_DELIVERY = 14;
        public static int ADK_DB_CODE_OF_TERMS_OF_PAYMENT = 15;
        public static int ADK_DB_CODE_OF_LANGUAGE = 16;
        public static int ADK_DB_CODE_OF_CURRENCY = 17;
        public static int ADK_DB_CODE_OF_CUSTOMER_CATEGORY = 18;
        public static int ADK_DB_CODE_OF_DISTRICT = 19;
        public static int ADK_DB_CODE_OF_SELLER = 20;
        public static int ADK_DB_DISCOUNT_AGREEMENT = 21;
        public static int ADK_DB_CODE_OF_ARTICLE_GROUP = 22;
        public static int ADK_DB_CODE_OF_ARTICLE_ACCOUNT = 23;
        public static int ADK_DB_CODE_OF_UNIT = 24;
        public static int ADK_DB_CODE_OF_PROFIT_CENTRE = 25;
        public static int ADK_DB_CODE_OF_PRICE_LIST = 26;
        public static int ADK_DB_PRM = 27;
        public static int ADK_DB_INVENTORY_ARTICLE = 28;
        public static int ADK_DB_MANUAL_DELIVERY_IN = 29;
        public static int ADK_DB_MANUAL_DELIVERY_OUT = 30;
        public static int ADK_DB_DISPATCHER = 31;
        public static int ADK_DB_BOOKING_HEAD = 32;
        public static int ADK_DB_BOOKING_ROW = 33;
        public static int ADK_DB_CODE_OF_CUSTOMER_DISCOUNT_ROW = 34;
        public static int ADK_DB_CODE_OF_ARTICLE_PARCEL = 35;
        public static int ADK_DB_CODE_OF_ARTICLE_NAME = 36;
        public static int ADK_DB_PRICE = 37;
        public static int ADK_DB_ARTICLE_PURCHASE_PRICE = 38;
        public static int ADK_DB_CODE_OF_WAY_OF_PAYMENT = 39;
        public static int ADK_DB_FREE_CATEGORY_1 = 40;
        public static int ADK_DB_FREE_CATEGORY_2 = 41;
        public static int ADK_DB_FREE_CATEGORY_3 = 42;
        public static int ADK_DB_FREE_CATEGORY_4 = 43;
        public static int ADK_DB_FREE_CATEGORY_5 = 44;
        public static int ADK_DB_FREE_CATEGORY_6 = 45;
        public static int ADK_DB_FREE_CATEGORY_7 = 46;
        public static int ADK_DB_FREE_CATEGORY_8 = 47;
        public static int ADK_DB_FREE_CATEGORY_9 = 48;
        public static int ADK_DB_FREE_CATEGORY_10 = 49;
        public static int ADK_DB_MEMBER = 50;
        public static int ADK_DB_DELIVERY_NOTE_HEAD = 51;
        public static int ADK_DB_DELIVERY_NOTE_ROW = 52;
        public static int ADK_DB_PACKAGE_HEAD = 53;
        public static int ADK_DB_PACKAGE_ROW = 54;
        public static int ADK_DB_IMP_PACKAGE_HEAD = 55;
        public static int ADK_DB_IMP_PACKAGE_ROW = 56;
        public static int ADK_DB_DELIVERY_ADDRESS = 57;
        
        public static int ADK_CUSTOMER_FIRST = 0;
        public static int ADK_CUSTOMER_NUMBER = 0;
        public static int ADK_CUSTOMER_NAME = 1;
        public static int ADK_CUSTOMER_SHORT_NAME = 2;
        public static int ADK_CUSTOMER_MAILING_ADDRESS = 3;
        public static int ADK_CUSTOMER_MAILING_ADDRESS2 = 4;
        public static int ADK_CUSTOMER_VISITING_ADDRESS = 5;
        public static int ADK_CUSTOMER_ZIPCODE = 6;
        public static int ADK_CUSTOMER_CITY = 7;
        public static int ADK_CUSTOMER_COUNTRY = 8;
        public static int ADK_CUSTOMER_TELEPHONE = 9;
        public static int ADK_CUSTOMER_TELEPHONE2 = 10;
        public static int ADK_CUSTOMER_FAX = 11;
        public static int ADK_CUSTOMER_DELIVERY_NAME = 12;
        public static int ADK_CUSTOMER_DELIVERY_ADDRESS = 13;
        public static int ADK_CUSTOMER_DELIVERY_ADDRESS2 = 14;
        public static int ADK_CUSTOMER_DELIVERY_VISITING_ADDRESS = 15;
        public static int ADK_CUSTOMER_DELIVERY_ZIPCODE = 16;
        public static int ADK_CUSTOMER_DELIVERY_CITY = 17;
        public static int ADK_CUSTOMER_DELIVERY_COUNTRY = 18;
        public static int ADK_CUSTOMER_DELIVERY_TELEPHONE = 19;
        public static int ADK_CUSTOMER_DELIVERY_TELEPHONE2 = 20;
        public static int ADK_CUSTOMER_DELIVERY_FAX = 21;
        public static int ADK_CUSTOMER_REFERENCE = 22;
        public static int ADK_CUSTOMER_BGIRO = 23;
        public static int ADK_CUSTOMER_PGIRO = 24;
        public static int ADK_CUSTOMER_ORGANISATION_NUMBER = 25;
        public static int ADK_CUSTOMER_CATEGORY = 26;
        public static int ADK_CUSTOMER_DISTRICT = 27;
        public static int ADK_CUSTOMER_SELLER = 28;
        public static int ADK_CUSTOMER_CODE_OF_TERMS_OF_DELIVERY = 29;
        public static int ADK_CUSTOMER_CODE_OF_TERMS_OF_PAYMENT = 30;
        public static int ADK_CUSTOMER_CODE_OF_WAY_OF_DELIVERY = 31;
        public static int ADK_CUSTOMER_REMINDER = 32;
        public static int ADK_CUSTOMER_DEMAND_FEE = 33;
        public static int ADK_CUSTOMER_LONGEREST_INVOICE = 34;
        public static int ADK_CUSTOMER_DISPATCH_FEE = 35;
        public static int ADK_CUSTOMER_CARGO_FEE = 36;
        public static int ADK_CUSTOMER_CODE_OF_CURRENCY = 37;
        public static int ADK_CUSTOMER_CODE_OF_LANGUAGE = 38;
        public static int ADK_CUSTOMER_DISCOUNT_AGREEMENT = 39;
        public static int ADK_CUSTOMER_NOTE_OF_OUTSTANDING_ORDERS = 40;
        public static int ADK_CUSTOMER_EXPORT = 41;
        public static int ADK_CUSTOMER_LAST_INVOICE_DATE = 42;
        public static int ADK_CUSTOMER_PRICE_LIST = 43;
        public static int ADK_CUSTOMER_INVOICE_DISCOUNT = 44;
        public static int ADK_CUSTOMER_ROW_DISCOUNT = 45;
        public static int ADK_CUSTOMER_REMARK1 = 46;
        public static int ADK_CUSTOMER_REMARK2 = 47;
        public static int ADK_CUSTOMER_CREDIT_LIMIT = 48;
        public static int ADK_CUSTOMER_ACCUMULATE_TURNOVER_THIS_YEAR = 49;
        public static int ADK_CUSTOMER_ACCUMULATE_TURNOVER_LAST_YEAR = 50;
        public static int ADK_CUSTOMER_CONTRIBUTION_MARGIN_THIS_YEAR = 51;
        public static int ADK_CUSTOMER_CONTRIBUTION_MARGIN_LAST_YEAR = 52;
        public static int ADK_CUSTOMER_CLAIM = 53;
        public static int ADK_CUSTOMER_AVERAGE_TIME_OF_PAYMENT_THIS_YEAR = 54;
        public static int ADK_CUSTOMER_AVERAGE_TIME_OF_PAYMENT_THIS_YEAR_NO_P = 55;
        public static int ADK_CUSTOMER_AVERAGE_TIME_OF_PAYMENT_LAST_YEAR = 56;
        public static int ADK_CUSTOMER_AVERAGE_TIME_OF_PAYMENT_LAST_YEAR_NO_P = 57;
        public static int ADK_CUSTOMER_SORT_ORDER = 58;
        public static int ADK_CUSTOMER_VAT_NUMBER = 59;
        public static int ADK_CUSTOMER_SUMMARY_INVOICE = 60;
        public static int ADK_CUSTOMER_EU_CUSTOMER = 61;
        public static int ADK_CUSTOMER_EMAIL = 62;
        public static int ADK_CUSTOMER_DOCUMENT_PATH = 63;
        public static int ADK_CUSTOMER_CONTRIBUTION_DEGREE = 64;
        public static int ADK_CUSTOMER_CONTRIBUTION_DEGREE_LAST_YEAR = 65;
        public static int ADK_CUSTOMER_LASTCHANGE = 66;
        public static int ADK_CUSTOMER_DISPATCHER = 67;
        public static int ADK_CUSTOMER_EANLOC = 68;
        public static int ADK_CUSTOMER_DELIVERY_EANLOC = 69;
        public static int ADK_CUSTOMER_CODE_OF_COUNTRY = 70;
        public static int ADK_CUSTOMER_DELIVERY_CODE_OF_COUNTRY = 71;
        public static int ADK_CUSTOMER_FIRST_NAME = 72;
        public static int ADK_CUSTOMER_MEMBER = 73;
        public static int ADK_CUSTOMER_TELEPHONE3 = 74;
        public static int ADK_CUSTOMER_DELIVERY_TELEPHONE3 = 75;
        public static int ADK_CUSTOMER_ADDRESS_TO_BOOKING = 76;
        public static int ADK_CUSTOMER_WSCUSTOMER = 77;
        public static int ADK_CUSTOMER_LAST = 77;
        
        public static int ADK_ARTICLE_FIRST = 0;
        public static int ADK_ARTICLE_NUMBER = 0;
        public static int ADK_ARTICLE_NAME = 1;
        public static int ADK_ARTICLE_NAME_X = 2;
        public static int ADK_ARTICLE_SHORT_NAME = 3;
        public static int ADK_ARTICLE_GROUP = 4;
        public static int ADK_ARTICLE_ACCOUNTING_CODE = 5;
        public static int ADK_ARTICLE_STOCK_GOODS = 6;
        public static int ADK_ARTICLE_UNIT_CODE = 7;
        public static int ADK_ARTICLE_SORT_ORDER = 8;
        public static int ADK_ARTICLE_QUANTITY_IN_STOCK = 9;
        public static int ADK_ARTICLE_QUANTITY_RESERVED = 10;
        public static int ADK_ARTICLE_ORDER_POLONG = 11;
        public static int ADK_ARTICLE_MINIMUM_ORDER = 12;
        public static int ADK_ARTICLE_MAXIMUM_ORDER = 13;
        public static int ADK_ARTICLE_ORDERED_QUANTITY = 14;
        public static int ADK_ARTICLE_TIME_OF_DELIVERY = 15;
        public static int ADK_ARTICLE_PLACE_IN_STOCK = 16;
        public static int ADK_ARTICLE_WEIGHT = 17;
        public static int ADK_ARTICLE_VOLUME = 18;
        public static int ADK_ARTICLE_SUPPLIER_NUMBER = 19;
        public static int ADK_ARTICLE_INVOICE_DATE = 20;
        public static int ADK_ARTICLE_INVENTORY_DATE = 21;
        public static int ADK_ARTICLE_INVENTORY_QUANTITY = 22;
        public static int ADK_ARTICLE_INVENTORY_DIFFERENCE = 23;
        public static int ADK_ARTICLE_INVENTORY_ACCUMULATE = 24;
        public static int ADK_ARTICLE_LAST_PURCHASE_PRICE = 25;
        public static int ADK_ARTICLE_NOTE_OF_OUTSTANDING_ARTICLES = 26;
        public static int ADK_ARTICLE_LAND_OF_ORIGIN = 27;
        public static int ADK_ARTICLE_EXPORT_CODE = 28;
        public static int ADK_ARTICLE_REMARK1 = 29;
        public static int ADK_ARTICLE_REMARK2 = 30;
        public static int ADK_ARTICLE_DOCUMENT_PATH = 31;
        public static int ADK_ARTICLE_ACCUMULATED_TURNOVER_THIS_YEAR = 32;
        public static int ADK_ARTICLE_ACCUMULATED_TURNOVER_LAST_YEAR = 33;
        public static int ADK_ARTICLE_ACCUMULATED_QUANTITY_THIS_YEAR = 34;
        public static int ADK_ARTICLE_ACCUMULATED_QUANTITY_LAST_YEAR = 35;
        public static int ADK_ARTICLE_CONTRIBUTION_MARGIN_THIS_YEAR = 36;
        public static int ADK_ARTICLE_CONTRIBUTION_MARGIN_LAST_YEAR = 37;
        public static int ADK_ARTICLE_CLOSING_FLAG = 38;
        public static int ADK_ARTICLE_ESTIMATED_PURCHASE_PRICE = 39;
        public static int ADK_ARTICLE_ESTIMATED_CARGO_FEE = 40;
        public static int ADK_ARTICLE_ESTIMATED_OTHER = 41;
        public static int ADK_ARTICLE_STOCK_VALUE = 42;
        public static int ADK_ARTICLE_STOCK_VALUE_INACTIVE = 43;
        public static int ADK_ARTICLE_PRICE_LIST = 44;
        public static int ADK_ARTICLE_PRICE = 45;
        public static int ADK_ARTICLE_ESTIMATED_TOTAL_PURCHASE_PRICE = 46;
        public static int ADK_ARTICLE_DISPOSABLE_IN_STOCK = 47;
        public static int ADK_ARTICLE_TURNOVER_RATE = 48;
        public static int ADK_ARTICLE_ACCUMULATE_TURNOVER_PARCEL_THIS_YEAR = 49;
        public static int ADK_ARTICLE_ACCUMULATE_TURNOVER_TOTAL_THIS_YEAR = 50;
        public static int ADK_ARTICLE_ACCUMULATE_TURNOVER_PARCEL_LAST_YEAR = 51;
        public static int ADK_ARTICLE_ACCUMULATE_TURNOVER_TOTAL_LAST_YEAR = 52;
        public static int ADK_ARTICLE_ACCUMULATED_QUANTITY_PARCEL_THIS_YEAR = 53;
        public static int ADK_ARTICLE_ACCUMULATED_QUANTITY_TOTAL_THIS_YEAR = 54;
        public static int ADK_ARTICLE_ACCUMULATED_QUANTITY_PARCEL_LAST_YEAR = 55;
        public static int ADK_ARTICLE_ACCUMULATED_QUANTITY_TOTAL_LAST_YEAR = 56;
        public static int ADK_ARTICLE_CONTRIBUTION_MARGIN_PARCEL_THIS_YEAR = 57;
        public static int ADK_ARTICLE_CONTRIBUTION_MARGIN_TOTAL_THIS_YEAR = 58;
        public static int ADK_ARTICLE_CONTRIBUTION_MARGIN_PARCEL_LAST_YEAR = 59;
        public static int ADK_ARTICLE_CONTRIBUTION_MARGIN_TOTAL_LAST_YEAR = 60;
        public static int ADK_ARTICLE_CONTRIBUTION_DEGREE_THIS_YEAR = 61;
        public static int ADK_ARTICLE_CONTRIBUTION_DEGREE_PARCEL_THIS_YEAR = 62;
        public static int ADK_ARTICLE_CONTRIBUTION_DEGREE_TOTAL_THIS_YEAR = 63;
        public static int ADK_ARTICLE_CONTRIBUTION_DEGREE_LAST_YEAR = 64;
        public static int ADK_ARTICLE_CONTRIBUTION_DEGREE_PARCEL_LAST_YEAR = 65;
        public static int ADK_ARTICLE_CONTRIBUTION_DEGREE_TOTAL_LAST_YEAR = 66;
        public static int ADK_ARTICLE_BAR_CODE = 67;
        public static int ADK_ARTICLE_BAR_CODE_TYPE = 68;
        public static int ADK_ARTICLE_PARCEL = 69;
        public static int ADK_ARTICLE_TYPE = 70;
        public static int ADK_ARTICLE_WEBSHOP = 71;
        public static int ADK_ARTICLE_IMAGE_PATH = 72;
        public static int ADK_ARTICLE_LAST = 72;
        
        public static int ADK_OOI_HEAD_FIRST = 0;
        public static int ADK_OOI_HEAD_DOCUMENT_NUMBER = 0;
        public static int ADK_OOI_HEAD_DOCUMENT_CONNECTION_NUMBER1 = 1;
        public static int ADK_OOI_HEAD_DOCUMENT_CONNECTION_NUMBER2 = 2;
        public static int ADK_OOI_HEAD_DOCUMENT_CONNECTION_NUMBER3 = 3;
        public static int ADK_OOI_HEAD_DOCUMENT_CONNECTION_NUMBER4 = 4;
        public static int ADK_OOI_HEAD_DOCUMENT_NOT_DONE = 5;
        public static int ADK_OOI_HEAD_DOCUMENT_PRLONGED = 6;
        public static int ADK_OOI_HEAD_DOCUMENT_CANCELLED = 7;
        public static int ADK_OOI_HEAD_DOCUMENT_DATE1 = 8;
        public static int ADK_OOI_HEAD_DOCUMENT_DATE2 = 9;
        public static int ADK_OOI_HEAD_ORDER_DELIVERED = 10;
        public static int ADK_OOI_HEAD_ORDER_PICK_PRLONGED = 11;
        public static int ADK_OOI_HEAD_ORDER_DELIVERY_NOTE_PRLONGED = 12;
        public static int ADK_OOI_HEAD_TYPE_OF_INVOICE = 13;
        public static int ADK_OOI_HEAD_CUSTOMER_NUMBER = 14;
        public static int ADK_OOI_HEAD_CUSTOMER_NAME = 15;
        public static int ADK_OOI_HEAD_MAILING_ADDRESS1 = 16;
        public static int ADK_OOI_HEAD_MAILING_ADDRESS2 = 17;
        public static int ADK_OOI_HEAD_ZIPCODE = 18;
        public static int ADK_OOI_HEAD_CITY = 19;
        public static int ADK_OOI_HEAD_COUNTRY = 20;
        public static int ADK_OOI_HEAD_DELIVERY_NAME = 21;
        public static int ADK_OOI_HEAD_DELIVERY_MAILING_ADDRESS1 = 22;
        public static int ADK_OOI_HEAD_DELIVERY_MAILING_ADDRESS2 = 23;
        public static int ADK_OOI_HEAD_DELIVERY_ZIPCODE = 24;
        public static int ADK_OOI_HEAD_DELIVERY_CITY = 25;
        public static int ADK_OOI_HEAD_DELIVERY_COUNTRY = 26;
        public static int ADK_OOI_HEAD_CUSTOMER_REFERENCE_NAME = 27;
        public static int ADK_OOI_HEAD_CUSTOMER_ORDER_NUMBER = 28;
        public static int ADK_OOI_HEAD_CUSTOMER_REFERENCE_NUMBER = 29;
        public static int ADK_OOI_HEAD_OUR_REFERENCE_NAME = 30;
        public static int ADK_OOI_HEAD_DISTRICT_CODE = 31;
        public static int ADK_OOI_HEAD_SELLER_CODE = 32;
        public static int ADK_OOI_HEAD_CURRENCY_CODE = 33;
        public static int ADK_OOI_HEAD_LANGUAGE_CODE = 34;
        public static int ADK_OOI_HEAD_CURRENCY_RATE = 35;
        public static int ADK_OOI_HEAD_CURRENCY_UNIT = 36;
        public static int ADK_OOI_HEAD_REMINDER = 37;
        public static int ADK_OOI_HEAD_DEMAND_FEE = 38;
        public static int ADK_OOI_HEAD_INVOICE_LONGEREST = 39;
        public static int ADK_OOI_HEAD_EXPORT = 40;
        public static int ADK_OOI_HEAD_INCLUDING_VAT = 41;
        public static int ADK_OOI_HEAD_DO_NOT_CREATE_BACKORDER = 42;
        public static int ADK_OOI_HEAD_LIST_OF_PRICE_CODE = 43;
        public static int ADK_OOI_HEAD_INVOICE_DISCOUNT = 44;
        public static int ADK_OOI_HEAD_CODE_OF_DISCOUNT = 45;
        public static int ADK_OOI_HEAD_CODE_OF_TERMS_OF_PAYMENT = 46;
        public static int ADK_OOI_HEAD_CODE_OF_TERMS_OF_DELIVERY = 47;
        public static int ADK_OOI_HEAD_CODE_OF_WAY_OF_DELIVERY = 48;
        public static int ADK_OOI_HEAD_TEXT1 = 49;
        public static int ADK_OOI_HEAD_TEXT2 = 50;
        public static int ADK_OOI_HEAD_TEXT3 = 51;
        public static int ADK_OOI_HEAD_SET_OF_VAT1 = 52;
        public static int ADK_OOI_HEAD_SET_OF_VAT2 = 53;
        public static int ADK_OOI_HEAD_SET_OF_VAT3 = 54;
        public static int ADK_OOI_HEAD_SET_OF_VAT4 = 55;
        public static int ADK_OOI_HEAD_CARGO_AMOUNT = 56;
        public static int ADK_OOI_HEAD_CARGO_VAT_CODE = 57;
        public static int ADK_OOI_HEAD_DISPATCH_FEE = 58;
        public static int ADK_OOI_HEAD_VAT_CODE_DISPATCH_FEE = 59;
        public static int ADK_OOI_HEAD_ROUND_OFF = 60;
        public static int ADK_OOI_HEAD_TOTAL_AMOUNT = 61;
        public static int ADK_OOI_HEAD_BALANCE = 62;
        public static int ADK_OOI_HEAD_PROJECT_CODE = 63;
        public static int ADK_OOI_HEAD_PROFIT_CENTRE = 64;
        public static int ADK_OOI_HEAD_BASIS_OF_VAT0 = 65;
        public static int ADK_OOI_HEAD_BASIS_OF_VAT1 = 66;
        public static int ADK_OOI_HEAD_BASIS_OF_VAT2 = 67;
        public static int ADK_OOI_HEAD_BASIS_OF_VAT3 = 68;
        public static int ADK_OOI_HEAD_BASIS_OF_VAT4 = 69;
        public static int ADK_OOI_HEAD_AMOUNT_OF_VAT1 = 70;
        public static int ADK_OOI_HEAD_AMOUNT_OF_VAT2 = 71;
        public static int ADK_OOI_HEAD_AMOUNT_OF_VAT3 = 72;
        public static int ADK_OOI_HEAD_AMOUNT_OF_VAT4 = 73;
        public static int ADK_OOI_HEAD_PENALTY_LONGEREST_RATE = 74;
        public static int ADK_OOI_HEAD_CUSTOMER_DEMAND_ACCOUNT = 75;
        public static int ADK_OOI_HEAD_CARGO_ACCOUNT = 76;
        public static int ADK_OOI_HEAD_DISPATCH_FEE_ACCOUNT = 77;
        public static int ADK_OOI_HEAD_BALANCE2 = 78;
        public static int ADK_OOI_HEAD_NUMBER_OF_ORIGINAl_INVOICE = 80;
        public static int ADK_OOI_HEAD_VAT1_ACCOUNT = 81;
        public static int ADK_OOI_HEAD_VAT2_ACCOUNT = 82;
        public static int ADK_OOI_HEAD_VAT3_ACCOUNT = 83;
        public static int ADK_OOI_HEAD_VAT4_ACCOUNT = 84;
        public static int ADK_OOI_HEAD_ROUND_OFF_ACCOUNT = 85;
        public static int ADK_OOI_HEAD_DISCOUNT_ACCOUNT = 86;
        public static int ADK_OOI_HEAD_CUSTOMER_INVOICE_VAT_NUMBER = 87;
        public static int ADK_OOI_HEAD_SUMMARY_INVOICE = 88;
        public static int ADK_OOI_HEAD_EU_ACCOUNT_FOR_QUARTERLY = 89;
        public static int ADK_OOI_HEAD_EU_THIRD_PART_TRADE = 90;
        public static int ADK_OOI_HEAD_INVOICE_WORK_BY_CONTRACT_SENT = 91;
        public static int ADK_OOI_HEAD_INVOICE_WORK_BY_CONTRACT_DONE = 92;
        public static int ADK_OOI_HEAD_SAVE_TEXT = 93;
        public static int ADK_OOI_HEAD_EXTRA_DOCUMENT_PRLONGED = 94;
        public static int ADK_OOI_HEAD_BOOK_ORDER = 95;
        public static int ADK_OOI_HEAD_GROSS = 96;
        public static int ADK_OOI_HEAD_NET = 97;
        public static int ADK_OOI_HEAD_EXCLUDING_OF_VAT = 98;
        public static int ADK_OOI_HEAD_VAT_AMOUNT = 99;
        public static int ADK_OOI_HEAD_CONTRIBUTION_MARGIN = 100;
        public static int ADK_OOI_HEAD_VALUE = 101;
        public static int ADK_OOI_HEAD_TYPE_IN_TEXT = 102;
        public static int ADK_OOI_HEAD_ROWS = 103;
        public static int ADK_OOI_HEAD_NROWS = 104;
        public static int ADK_OOI_HEAD_LOCAL_REMARK = 105;
        public static int ADK_OOI_HEAD_CREDIT_INVOICE_COPY_NUMBER = 106;
        public static int ADK_OOI_HEAD_CREDIT_INVOICE_COPY_WHAT = 107;
        public static int ADK_OOI_HEAD_EANLOC = 108;
        public static int ADK_OOI_HEAD_DELIVERY_EANLOC = 109;
        public static int ADK_OOI_HEAD_DISPATCHER = 110;
        public static int ADK_OOI_HEAD_CREDIT_NOTE_STORAGE_AFFECT = 111;
        public static int ADK_OOI_HEAD_OCR_NUMBER = 112;
        public static int ADK_OOI_HEAD_CODE_OF_COUNTRY = 113;
        public static int ADK_OOI_HEAD_DELIVERY_CODE_OF_COUNTRY = 114;
        public static int ADK_OOI_HEAD_INVOICE_BASE = 115;
        public static int ADK_OOI_HEAD_CONTRACTNR = 116;
        public static int ADK_OOI_HEAD_TOT_SHIPWT = 117;
        public static int ADK_OOI_HEAD_DOCUMENT_DATE3 = 118;
        public static int ADK_OOI_HEAD_LAST = 118;
        
        public static int ADK_OOI_ROW_FIRST = 0;
        public static int ADK_OOI_ROW_ARTICLE_NUMBER = 0;
        public static int ADK_OOI_ROW_SUPPLIER_ARTICLE_NUMBER = 1;
        public static int ADK_OOI_ROW_QUANTITY1 = 2;
        public static int ADK_OOI_ROW_QUANTITY2 = 3;
        public static int ADK_OOI_ROW_QUANTITY3 = 4;
        public static int ADK_OOI_ROW_PRICE_EACH_CURRENT_CURRENCY = 5;
        public static int ADK_OOI_ROW_PRICE2 = 6;
        public static int ADK_OOI_ROW_DISCOUNT = 7;
        public static int ADK_OOI_ROW_AMOUNT_DISCOUNT_FLAG = 8;
        public static int ADK_OOI_ROW_AMOUNT_CURRENT_CURRENCY = 9;
        public static int ADK_OOI_ROW_AMOUNT_DOMESTIC_CURRENCY = 10;
        public static int ADK_OOI_ROW_ACCOUNT_NUMBER = 11;
        public static int ADK_OOI_ROW_PROFIT_CENTRE = 12;
        public static int ADK_OOI_ROW_PROJECT = 13;
        public static int ADK_OOI_ROW_TEXT = 14;
        public static int ADK_OOI_ROW_UNIT = 15;
        public static int ADK_OOI_ROW_VAT_CODE = 16;
        public static int ADK_OOI_ROW_NOTE_OF_OUTSTANDING_ORDERS = 17;
        public static int ADK_OOI_ROW_DATE2 = 18;
        public static int ADK_OOI_ROW_TYPE_OF_ROW = 19;
        public static int ADK_OOI_ROW_CONTRIBUTION_DEGREE = 20;
        public static int ADK_OOI_ROW_CONTRIBUTION_MARGIN = 21;
        public static int ADK_OOI_ROW_PRLONG = 22;
        public static int ADK_OOI_ROW_PRLONG2 = 23;
        public static int ADK_OOI_ROW_BAR_CODE = 25;
        public static int ADK_OOI_ROW_DATE3 = 26;
        public static int ADK_OOI_ROW_ARTICLE_TYPE = 27;
        public static int ADK_OOI_ROW_FROM_TYPE = 28;
        public static int ADK_OOI_ROW_FROM_DOCUMENT = 29;
        public static int ADK_OOI_ROW_FROM_DOCROW = 30;
        public static int ADK_OOI_ROW_ROWNUMBER = 31;
        public static int ADK_OOI_ROW_CONNECTION_TYPE = 32;
        public static int ADK_OOI_ROW_CONNECTION_DOCUMENT = 33;
        public static int ADK_OOI_ROW_CONNECTION_DOCROW = 34;
        public static int ADK_OOI_ROW_SERIAL_NUMBER = 35;
        public static int ADK_OOI_ROW_BATCH_NUMBER = 36;
        public static int ADK_OOI_ROW_BEST_BEFORE = 37;
        public static int ADK_OOI_ROW_NOTIFY_QT1 = 38;
        public static int ADK_OOI_ROW_NOTIFY_QT2 = 39;
        public static int ADK_OOI_ROW_PIN_BOOKING = 40;
        public static int ADK_OOI_ROW_NUM_PIN_BOOKING = 41;
        public static int ADK_OOI_ROW_LAST = 41;
        
        public static int ADK_SUP_INV_HEAD_FIRST = 0;
        public static int ADK_SUP_INV_HEAD_GIVEN_NUMBER = 0;
        public static int ADK_SUP_INV_HEAD_SUPPLIER_NUMBER = 1;
        public static int ADK_SUP_INV_HEAD_SUPPLIER_NAME = 2;
        public static int ADK_SUP_INV_HEAD_PGIRO = 3;
        public static int ADK_SUP_INV_HEAD_ORGANISATION_NUMBER = 4;
        public static int ADK_SUP_INV_HEAD_BGIRO = 5;
        public static int ADK_SUP_INV_HEAD_INVOICE_NUMBER = 6;
        public static int ADK_SUP_INV_HEAD_CUSTOMER_NUMBER = 7;
        public static int ADK_SUP_INV_HEAD_INVOICE_DATE = 8;
        public static int ADK_SUP_INV_HEAD_DUE_DATE = 9;
        public static int ADK_SUP_INV_HEAD_CURRENCY_CODE = 10;
        public static int ADK_SUP_INV_HEAD_CURRENCY_RATE = 11;
        public static int ADK_SUP_INV_HEAD_TYPE_OF_INVOICE = 12;
        public static int ADK_SUP_INV_HEAD_TOTAL = 13;
        public static int ADK_SUP_INV_HEAD_BALANCE_CURRENT_CURRENCY = 14;
        public static int ADK_SUP_INV_HEAD_OUTGOING_PAYMENTS_CURRENT_CURRENCY = 15;
        public static int ADK_SUP_INV_HEAD_VAT_AMOUNT = 16;
        public static int ADK_SUP_INV_HEAD_CARGO_FEE = 17;
        public static int ADK_SUP_INV_HEAD_NAME_OF_CERTIFIER = 18;
        public static int ADK_SUP_INV_HEAD_CERTIFIED = 19;
        public static int ADK_SUP_INV_HEAD_CANCELLED = 20;
        public static int ADK_SUP_INV_HEAD_PROJECT = 21;
        public static int ADK_SUP_INV_HEAD_PROFIT_CENTRE = 22;
        public static int ADK_SUP_INV_HEAD_JOURNAL_NUMBER = 23;
        public static int ADK_SUP_INV_HEAD_NOTE1 = 24;
        public static int ADK_SUP_INV_HEAD_NOTE2 = 25;
        public static int ADK_SUP_INV_HEAD_NOTE3 = 26;
        public static int ADK_SUP_INV_HEAD_CURRENCY_UNIT = 27;
        public static int ADK_SUP_INV_HEAD_SUPPLIER_DEBT_ACCOUNT = 28;
        public static int ADK_SUP_INV_HEAD_CODE_OF_CENTRAL_BANK = 29;
        public static int ADK_SUP_INV_HEAD_PAY_WITH_CURRENCY_ACCOUNT = 30;
        public static int ADK_SUP_INV_HEAD_PAYMENT_ABROAD = 31;
        public static int ADK_SUP_INV_HEAD_CODE_OF_CHARGE_ON_PAYMENT_ABROAD = 32;
        public static int ADK_SUP_INV_HEAD_TYPE_IN_TEXT = 33;
        public static int ADK_SUP_INV_HEAD_VERIFICATION_SERIES_ID = 34;
        public static int ADK_SUP_INV_HEAD_CHANGE_OF_STOCK = 35;
        public static int ADK_SUP_INV_HEAD_ROWS = 36;
        public static int ADK_SUP_INV_HEAD_NROWS = 37;
        public static int ADK_SUP_INV_HEAD_CREDIT_INVOICE_COPY_NUMBER = 38;
        public static int ADK_SUP_INV_HEAD_CREDIT_INVOICE_COPY_WHAT = 39;
        public static int ADK_SUP_INV_HEAD_CREDIT_NUMBER = 40;
        public static int ADK_SUP_INV_HEAD_LAST = 40;
        
        public static int ADK_PROJECT_FIRST = 0;
        public static int ADK_PROJECT_CODE_OF_PROJECT = 0;
        public static int ADK_PROJECT_NAME = 1;
        public static int ADK_PROJECT_DATE_OF_BEGINNING = 2;
        public static int ADK_PROJECT_DATE_OF_END = 3;
        public static int ADK_PROJECT_DATE_OF_CLOSURE = 4;
        public static int ADK_PROJECT_RESPONSIBLE_OF_PROJECT = 5;
        public static int ADK_PROJECT_CUSTOMER_NUMBER = 6;
        public static int ADK_PROJECT_CUSTOMER_NAME = 7;
        public static int ADK_PROJECT_OUR_ORDER_NUMBER = 8;
        public static int ADK_PROJECT_CUSTOMER_ORDER_NUMBER = 9;
        public static int ADK_PROJECT_CUSTOMER_REFERENCE_NAME = 10;
        public static int ADK_PROJECT_TELEPHONE = 11;
        public static int ADK_PROJECT_FAX = 12;
        public static int ADK_PROJECT_NOTE_ABOUT_WORKPLACE = 13;
        public static int ADK_PROJECT_NOTE_ABOUT_WORKPLACE2 = 14;
        public static int ADK_PROJECT_NOTE1 = 15;
        public static int ADK_PROJECT_NOTE2 = 16;
        public static int ADK_PROJECT_NOTE3 = 17;
        public static int ADK_PROJECT_NOTE4 = 18;
        public static int ADK_PROJECT_CHART_OF_ACCOUNTS_TYPE = 19;
        public static int ADK_PROJECT_CLOSED = 20;
        public static int ADK_PROJECT_LAST = 20;
        
        public static int ADK_ACCOUNT_FIRST = 0;
        public static int ADK_ACCOUNT_SEASON_ID = 0;
        public static int ADK_ACCOUNT_NUMBER = 1;
        public static int ADK_ACCOUNT_TEXT = 2;
        public static int ADK_ACCOUNT_VAT_CODE = 3;
        public static int ADK_ACCOUNT_SRU_CODE = 4;
        public static int ADK_ACCOUNT_DEBIT_CREDIT = 5;
        public static int ADK_ACCOUNT_AUTOMATION_DEVIDE = 6;
        public static int ADK_ACCOUNT_MANUAL_CODING = 7;
        public static int ADK_ACCOUNT_PROFIT_CENTRE_ON_ACCOUNT = 8;
        public static int ADK_ACCOUNT_PROFIT_CENTRE = 9;
        public static int ADK_ACCOUNT_PROJECT_ON_ACCOUNT = 10;
        public static int ADK_ACCOUNT_PROJECT = 11;
        public static int ADK_ACCOUNT_SUB_ACCOUNT = 12;
        public static int ADK_ACCOUNT_SUB_ACCOUNT_DEFINITION = 13;
        public static int ADK_ACCOUNT_QUANTITY_UNIT_ON_ACCOUNT = 14;
        public static int ADK_ACCOUNT_QUANTITY_UNIT = 15;
        public static int ADK_ACCOUNT_QUANTITY_UNIT_NORMAL = 16;
        public static int ADK_ACCOUNT_ROW_INFO_ON_ACCOUNT = 17;
        public static int ADK_ACCOUNT_ROW_INFO = 18;
        public static int ADK_ACCOUNT_TYPE_OF_ACCOUNT = 19;
        public static int ADK_ACCOUNT_NOT_ACTIVE = 20;
        public static int ADK_ACCOUNT_NEVER_DETAILED = 21;
        public static int ADK_ACCOUNT_LAST = 21;
        
        public static int ADK_SUPPLIER_FIRST = 0;
        public static int ADK_SUPPLIER_NUMBER = 0;
        public static int ADK_SUPPLIER_NAME = 1;
        public static int ADK_SUPPLIER_SHORT_NAME = 2;
        public static int ADK_SUPPLIER_MAILING_ADDRESS = 3;
        public static int ADK_SUPPLIER_MAILING_ADDRESS2 = 4;
        public static int ADK_SUPPLIER_VISITING_ADDRESS = 5;
        public static int ADK_SUPPLIER_ZIPCODE = 6;
        public static int ADK_SUPPLIER_CITY = 7;
        public static int ADK_SUPPLIER_COUNTRY = 8;
        public static int ADK_SUPPLIER_TELEPHONE = 9;
        public static int ADK_SUPPLIER_TELEPHONE2 = 10;
        public static int ADK_SUPPLIER_FAX = 11;
        public static int ADK_SUPPLIER_REFERENCE = 12;
        public static int ADK_SUPPLIER_OUR_REFERENCE = 13;
        public static int ADK_SUPPLIER_ORGANISATION_NUMBER = 14;
        public static int ADK_SUPPLIER_CODE_OF_CURRENCY = 15;
        public static int ADK_SUPPLIER_CODE_OF_LANGUAGE = 16;
        public static int ADK_SUPPLIER_BGIRO = 17;
        public static int ADK_SUPPLIER_PGIRO = 18;
        public static int ADK_SUPPLIER_OUR_CUSTOMER_NUMBER = 19;
        public static int ADK_SUPPLIER_CREDIT_LIMIT = 20;
        public static int ADK_SUPPLIER_DEBT = 21;
        public static int ADK_SUPPLIER_PAYMENT_SENT = 22;
        public static int ADK_SUPPLIER_LAST_INVOICE_DATE = 23;
        public static int ADK_SUPPLIER_ACCUMULATE_TURNOVER_THIS_YEAR = 24;
        public static int ADK_SUPPLIER_ACCUMULATE_TURN_OVER_LAST_YEAR = 25;
        public static int ADK_SUPPLIER_CODE_OF_TERMS_OF_PAYMENT = 26;
        public static int ADK_SUPPLIER_CODE_OF_TERMS_OF_DELIVERY = 27;
        public static int ADK_SUPPLIER_CODE_OF_WAY_OF_DELIVERY = 28;
        public static int ADK_SUPPLIER_REMARK1 = 29;
        public static int ADK_SUPPLIER_REMARK2 = 30;
        public static int ADK_SUPPLIER_SORT_ORDER = 31;
        public static int ADK_SUPPLIER_CODE_OF_COUNTRY = 32;
        public static int ADK_SUPPLIER_CODE_OF_CENTRAL_BANK = 33;
        public static int ADK_SUPPLIER_RECIEVER_NUMBER_OF_BANK = 34;
        public static int ADK_SUPPLIER_SWIFT_ADDRESS = 35;
        public static int ADK_SUPPLIER_CODE_OF_BANK = 36;
        public static int ADK_SUPPLIER_NAME_OF_BANK = 37;
        public static int ADK_SUPPLIER_ADDRESS_OF_BANK = 38;
        public static int ADK_SUPPLIER_ZIPCODE_OF_BANK = 39;
        public static int ADK_SUPPLIER_CITY_OF_BANK = 40;
        public static int ADK_SUPPLIER_PAYMENT_ABROAD = 41;
        public static int ADK_SUPPLIER_BG_CODE_OF_FEE_FOR_PAYMENT_ABROAD = 42;
        public static int ADK_SUPPLIER_EMAIL = 43;
        public static int ADK_SUPPLIER_WWW = 44;
        public static int ADK_SUPPLIER_DOCUMENT = 45;
        public static int ADK_SUPPLIER_OCR_SUPPLIER = 46;
        public static int ADK_SUPPLIER_CURRENCY_ACCOUNT = 47;
        public static int ADK_SUPPLIER_EANLOC = 48;
        public static int ADK_SUPPLIER_EU_PAYMENT_SEK_EUR = 49;
        public static int ADK_SUPPLIER_LAST = 49;
        
        public static int ADK_CODE_OF_TERMS_OF_DELIVERY_FIRST = 0;
        public static int ADK_CODE_OF_TERMS_OF_DELIVERY_CODE = 0;
        public static int ADK_CODE_OF_TERMS_OF_DELIVERY_TEXT = 1;
        public static int ADK_CODE_OF_TERMS_OF_DELIVERY_LAST = 1;
        public static int ADK_CODE_OF_WAY_OF_DELIVERY_FIRST = 0;
        public static int ADK_CODE_OF_WAY_OF_DELIVERY_CODE = 0;
        public static int ADK_CODE_OF_WAY_OF_DELIVERY_TEXT = 1;
        public static int ADK_CODE_OF_WAY_OF_DELIVERY_LAST = 1;
        public static int ADK_CODE_OF_TERMS_OF_PAYMENT_FIRST = 0;
        public static int ADK_CODE_OF_TERMS_OF_PAYMENT_CODE = 0;
        public static int ADK_CODE_OF_TERMS_OF_PAYMENT_TEXT = 1;
        public static int ADK_CODE_OF_TERMS_OF_PAYMENT_PAYMENT_CODE = 2;
        public static int ADK_CODE_OF_TERMS_OF_PAYMENT_LAST = 2;
        public static int ADK_CODE_OF_LANGUAGE_FIRST = 0;
        public static int ADK_CODE_OF_LANGUAGE_CODE = 0;
        public static int ADK_CODE_OF_LANGUAGE_TEXT = 1;
        public static int ADK_CODE_OF_LANGUAGE_LAST = 1;
        public static int ADK_CODE_OF_CURRENCY_FIRST = 0;
        public static int ADK_CODE_OF_CURRENCY_CODE = 0;
        public static int ADK_CODE_OF_CURRENCY_COUNTRY = 1;
        public static int ADK_CODE_OF_CURRENCY_UNIT = 2;
        public static int ADK_CODE_OF_CURRENCY_DATE_OF_REGISTRATION = 3;
        public static int ADK_CODE_OF_CURRENCY_SELL = 4;
        public static int ADK_CODE_OF_CURRENCY_BUY = 5;
        public static int ADK_CODE_OF_CURRENCY_LAST = 5;
        public static int ADK_CODE_OF_CUSTOMER_CATEGORY_FIRST = 0;
        public static int ADK_CODE_OF_CUSTOMER_CATEGORY_CODE = 0;
        public static int ADK_CODE_OF_CUSTOMER_CATEGORY_TEXT = 1;
        public static int ADK_CODE_OF_CUSTOMER_CATEGORY_MEMBER_CATEGORY = 2;
        public static int ADK_CODE_OF_CUSTOMER_CATEGORY_LAST = 2;
        public static int ADK_CODE_OF_DISTRICT_FIRST = 0;
        public static int ADK_CODE_OF_DISTRICT_CODE = 0;
        public static int ADK_CODE_OF_DISTRICT_TEXT = 1;
        public static int ADK_CODE_OF_DISTRICT_LAST = 1;
        public static int ADK_CODE_OF_SELLER_FIRST = 0;
        public static int ADK_CODE_OF_SELLER_SIGN = 0;
        public static int ADK_CODE_OF_SELLER_NAME = 1;
        public static int ADK_CODE_OF_SELLER_SELLER = 2;
        public static int ADK_CODE_OF_SELLER_REF = 3;
        public static int ADK_CODE_OF_SELLER_ATT = 4;
        public static int ADK_CODE_OF_SELLER_LAST = 4;
        
        public static int ADK_DISCOUNT_AGREEMENT_FIRST = 0;
        public static int ADK_DISCOUNT_AGREEMENT_CODE = 0;
        public static int ADK_DISCOUNT_AGREEMENT_TEXT = 1;
        public static int ADK_DISCOUNT_AGREEMENT_PRICE_LIST = 2;
        public static int ADK_DISCOUNT_AGREEMENT_INVOICE_DISCOUNT = 3;
        public static int ADK_DISCOUNT_AGREEMENT_ROW_DISCOUNT = 4;
        public static int ADK_DISCOUNT_AGREEMENT_LAST = 4;
        
        public static int ADK_CODE_OF_ARTICLE_GROUP_FIRST = 0;
        public static int ADK_CODE_OF_ARTICLE_GROUP_CODE = 0;
        public static int ADK_CODE_OF_ARTICLE_GROUP_TEXT = 1;
        public static int ADK_CODE_OF_ARTICLE_GROUP_LAST = 1;
        public static int ADK_CODE_OF_ARTICLE_ACCOUNT_FIRST = 0;
        public static int ADK_CODE_OF_ARTICLE_ACCOUNT_CODE = 0;
        public static int ADK_CODE_OF_ARTICLE_ACCOUNT_TEXT = 1;
        public static int ADK_CODE_OF_ARTICLE_ACCOUNT_SALES = 2;
        public static int ADK_CODE_OF_ARTICLE_ACCOUNT_EXPORT_SALES = 3;
        public static int ADK_CODE_OF_ARTICLE_ACCOUNT_SALES_EU = 4;
        public static int ADK_CODE_OF_ARTICLE_ACCOUNT_PURCHASE = 5;
        public static int ADK_CODE_OF_ARTICLE_ACCOUNT_STOCK = 6;
        public static int ADK_CODE_OF_ARTICLE_ACCOUNT_STOCK_CHANGE = 7;
        public static int ADK_CODE_OF_ARTICLE_ACCOUNT_PROFIT_CENTRE = 8;
        public static int ADK_CODE_OF_ARTICLE_ACCOUNT_VAT = 9;
        public static int ADK_CODE_OF_ARTICLE_ACCOUNT_VAT_EU = 10;
        public static int ADK_CODE_OF_ARTICLE_ACCOUNT_LAST = 10;
        public static int ADK_CODE_OF_UNIT_FIRST = 0;
        public static int ADK_CODE_OF_UNIT_CODE = 0;
        public static int ADK_CODE_OF_UNIT_DOMESTIC = 1;
        public static int ADK_CODE_OF_UNIT_LANGUAGE = 2;
        public static int ADK_CODE_OF_UNIT_TEXT = 3;
        public static int ADK_CODE_OF_UNIT_DECIMALS = 4;
        public static int ADK_CODE_OF_UNIT_LAST = 4;
        public static int ADK_CODE_OF_PROFIT_CENTRE_FIRST = 0;
        public static int ADK_CODE_OF_PROFIT_CENTRE_YEAR_ID = 0;
        public static int ADK_CODE_OF_PROFIT_CENTRE_CODE = 1;
        public static int ADK_CODE_OF_PROFIT_CENTRE_NAME = 2;
        public static int ADK_CODE_OF_PROFIT_CENTRE_LAST = 2;
        public static int ADK_CODE_OF_PRICE_LIST_FIRST = 0;
        public static int ADK_CODE_OF_PRICE_LIST_CODE = 0;
        public static int ADK_CODE_OF_PRICE_LIST_TEXT = 1;
        public static int ADK_CODE_OF_PRICE_LIST_CURRENCY_CODE = 2;
        public static int ADK_CODE_OF_PRICE_LIST_LANGUAGE_CODE = 3;
        public static int ADK_CODE_OF_PRICE_LIST_INCLUDING_VAT = 4;
        public static int ADK_CODE_OF_PRICE_LIST_NOTE = 5;
        public static int ADK_CODE_OF_PRICE_LIST_CHANGE_DATE = 6;
        public static int ADK_CODE_OF_PRICE_LIST_LONGERVAL1 = 7;
        public static int ADK_CODE_OF_PRICE_LIST_LONGERVAL2 = 8;
        public static int ADK_CODE_OF_PRICE_LIST_LONGERVAL3 = 9;
        public static int ADK_CODE_OF_PRICE_LIST_LONGERVAL4 = 10;
        public static int ADK_CODE_OF_PRICE_LIST_ROUND_OFF1 = 11;
        public static int ADK_CODE_OF_PRICE_LIST_ROUND_OFF2 = 12;
        public static int ADK_CODE_OF_PRICE_LIST_ROUND_OFF3 = 13;
        public static int ADK_CODE_OF_PRICE_LIST_ROUND_OFF4 = 14;
        public static int ADK_CODE_OF_PRICE_LIST_LAST = 14;
        
        public static int ADK_PRM_FIRST = 0;
        public static int ADK_PRM_NAME = 0;
        public static int ADK_PRM_MAILING_ADDRESS = 1;
        public static int ADK_PRM_VISITING_ADDRESS = 2;
        public static int ADK_PRM_ZIPCODE = 3;
        public static int ADK_PRM_CITY = 4;
        public static int ADK_PRM_COUNTRY = 5;
        public static int ADK_PRM_TELEPHONE = 6;
        public static int ADK_PRM_TELEPHONE2 = 7;
        public static int ADK_PRM_FAX = 8;
        public static int ADK_PRM_BGIRO = 9;
        public static int ADK_PRM_PGIRO = 10;
        public static int ADK_PRM_ORGANISATION_NUMBER = 11;
        public static int ADK_PRM_VAT_REGISTER_NUMBER = 12;
        public static int ADK_PRM_VAT_NUMBER = 13;
        public static int ADK_PRM_CODE_OF_LANGUAGE = 14;
        public static int ADK_PRM_CODE_OF_CURRENCY = 15;
        public static int ADK_PRM_CODE_OF_BRANCH = 16;
        public static int ADK_PRM_EMAIL = 17;
        public static int ADK_PRM_WWW = 18;
        public static int ADK_PRM_SEAT = 19;
        public static int ADK_PRM_DELIVERY_NAME = 20;
        public static int ADK_PRM_DELIVERY_ADDRESS = 21;
        public static int ADK_PRM_DELIVERY_ADDRESS2 = 22;
        public static int ADK_PRM_DELIVERY_ZIPCODE = 23;
        public static int ADK_PRM_DELIVERY_CITY = 24;
        public static int ADK_PRM_DELIVERY_MAILING_ADDRESS = 25;
        public static int ADK_PRM_DELIVERY_COUNTRY = 26;
        public static int ADK_PRM_DELIVERY_TELEPHONE = 27;
        public static int ADK_PRM_DELIVERY_REFERENCE = 28;
        public static int ADK_PRM_EANLOC = 29;
        public static int ADK_PRM_DELIVERY_EANLOC = 30;
        public static int ADK_PRM_IBAN_NUMBER = 31;
        public static int ADK_PRM_SWIFT_ADRESS = 32;
        public static int ADK_PRM_BANK_NAME = 33;
        public static int ADK_PRM_BANK_ADRESS = 34;
        public static int ADK_PRM_BANK_ADRESS2 = 35;
        public static int ADK_PRM_BANK_ZIPCODE = 36;
        public static int ADK_PRM_BANK_CITY = 37;
        public static int ADK_PRM_CODE_OF_COUNTRY = 38;
        public static int ADK_PRM_ACCOUNT_NUMBER = 39;
        public static int ADK_PRM_ADDRESS_CODE_OF_COUNTRY = 40;
        public static int ADK_PRM_DELIVERY_CODE_OF_COUNTRY = 41;
        public static int ADK_PRM_LAST = 41;
        
        public static int ADK_INVENTORY_ARTICLE_FIRST = 0;
        public static int ADK_INVENTORY_ARTICLE_ARTICLE_NUMBER = 0;
        public static int ADK_INVENTORY_ARTICLE_ARTICLE_NAME = 1;
        public static int ADK_INVENTORY_ARTICLE_ARTICLE_GROUP = 2;
        public static int ADK_INVENTORY_ARTICLE_ARTICLE_PLACE_IN_STOCK = 3;
        public static int ADK_INVENTORY_ARTICLE_ARTICLE_UNIT_CODE = 4;
        public static int ADK_INVENTORY_ARTICLE_QUANTITY = 5;
        public static int ADK_INVENTORY_ARTICLE_DATE = 6;
        public static int ADK_INVENTORY_ARTICLE_QUANTITY_IN_STOCK = 7;
        public static int ADK_INVENTORY_ARTICLE_DIFFERENCE = 8;
        public static int ADK_INVENTORY_ARTICLE_LAST_DATE = 9;
        public static int ADK_INVENTORY_ARTICLE_LAST_DIFFERENCE = 10;
        public static int ADK_INVENTORY_ARTICLE_ACCUMULATED_DIFFERENCE = 11;
        public static int ADK_INVENTORY_ARTICLE_FLAG = 12;
        public static int ADK_INVENTORY_ARTICLE_LAST = 12;
        
        public static int ADK_MANUAL_DELIVERY_IN_FIRST = 0;
        public static int ADK_MANUAL_DELIVERY_IN_DOCUMENT_NUMBER = 0;
        public static int ADK_MANUAL_DELIVERY_IN_DATE = 1;
        public static int ADK_MANUAL_DELIVERY_IN_ARTICLE_NUMBER = 2;
        public static int ADK_MANUAL_DELIVERY_IN_ARTICLE_NAME = 3;
        public static int ADK_MANUAL_DELIVERY_IN_UNIT = 4;
        public static int ADK_MANUAL_DELIVERY_IN_QUANTITY = 5;
        public static int ADK_MANUAL_DELIVERY_IN_PRICE_EACH = 6;
        public static int ADK_MANUAL_DELIVERY_IN_CARGO_AMOUNT_EACH = 7;
        public static int ADK_MANUAL_DELIVERY_IN_TEXT = 8;
        public static int ADK_MANUAL_DELIVERY_IN_ACCOUNT = 9;
        public static int ADK_MANUAL_DELIVERY_IN_PROFIT_CENTRE = 10;
        public static int ADK_MANUAL_DELIVERY_IN_PROJECT = 11;
        public static int ADK_MANUAL_DELIVERY_IN_CANCELLED = 12;
        public static int ADK_MANUAL_DELIVERY_IN_JOURNAL_PRLONGED = 13;
        public static int ADK_MANUAL_DELIVERY_IN_LAST = 13;
        public static int ADK_MANUAL_DELIVERY_OUT_FIRST = 0;
        public static int ADK_MANUAL_DELIVERY_OUT_DOCUMENT_NUMBER = 0;
        public static int ADK_MANUAL_DELIVERY_OUT_DATE = 1;
        public static int ADK_MANUAL_DELIVERY_OUT_ARTICLE_NUMBER = 2;
        public static int ADK_MANUAL_DELIVERY_OUT_ARTICLE_NAME = 3;
        public static int ADK_MANUAL_DELIVERY_OUT_UNIT = 4;
        public static int ADK_MANUAL_DELIVERY_OUT_QUANTITY = 5;
        public static int ADK_MANUAL_DELIVERY_OUT_TEXT = 6;
        public static int ADK_MANUAL_DELIVERY_OUT_ACCOUNT = 7;
        public static int ADK_MANUAL_DELIVERY_OUT_PROFIT_CENTRE = 8;
        public static int ADK_MANUAL_DELIVERY_OUT_PROJECT = 9;
        public static int ADK_MANUAL_DELIVERY_OUT_CANCELLED = 10;
        public static int ADK_MANUAL_DELIVERY_OUT_JOURNAL_PRLONGED = 11;
        public static int ADK_MANUAL_DELIVERY_OUT_LAST = 11;
        
        public static int ADK_DISPATCHER_FIST = 0;
        public static int ADK_DISPATCHER_ID = 0;
        public static int ADK_DISPATCHER_TEXT = 1;
        public static int ADK_DISPATCHER_OUR_CUSTOMER_NUMBER = 2;
        public static int ADK_DISPATCHER_LAST = 2;
        
        public static int ADK_BOOKING_FIRST = 0;
        public static int ADK_BOOKING_DOCUMENT_NUMBER = 0;
        public static int ADK_BOOKING_SUPPLIER_NUMBER = 1;
        public static int ADK_BOOKING_SUPPLIER_NAME = 2;
        public static int ADK_BOOKING_MAILING_ADDRESS = 3;
        public static int ADK_BOOKING_MAILING_ADDRESS2 = 4;
        public static int ADK_BOOKING_ZIPCODE = 5;
        public static int ADK_BOOKING_CITY = 6;
        public static int ADK_BOOKING_COUNTRY = 7;
        public static int ADK_BOOKING_DELIVERY_NAME = 8;
        public static int ADK_BOOKING_DELIVERY_MAILING_ADDRESS1 = 9;
        public static int ADK_BOOKING_DELIVERY_MAILING_ADDRESS2 = 10;
        public static int ADK_BOOKING_VISITING_ADDRESS = 11;
        public static int ADK_BOOKING_DELIVERY_ZIPCODE = 12;
        public static int ADK_BOOKING_DELIVERY_CITY = 13;
        public static int ADK_BOOKING_DELIVERY_COUNTRY = 14;
        public static int ADK_BOOKING_SUPPLIER_CUSTOMER_REFERENCE_NAME = 15;
        public static int ADK_BOOKING_SUPPLIER_REFERENCE = 16;
        public static int ADK_BOOKING_OUR_REFERENCE = 17;
        public static int ADK_BOOKING_LANGUAGE_CODE = 18;
        public static int ADK_BOOKING_CURRENCY_CODE = 19;
        public static int ADK_BOOKING_SUPPLIER_ORDER_NUMBER = 20;
        public static int ADK_BOOKING_NOT_DONE = 21;
        public static int ADK_BOOKING_DELIVERED = 22;
        public static int ADK_BOOKING_CANCELLED = 23;
        public static int ADK_BOOKING_PRLONGED = 24;
        public static int ADK_BOOKING_CODE_OF_TERMS_OF_PAYMENT = 25;
        public static int ADK_BOOKING_CODE_OF_TERMS_OF_DELIVERY = 26;
        public static int ADK_BOOKING_CODE_OF_WAY_OF_DELIVERY = 27;
        public static int ADK_BOOKING_DATE = 28;
        public static int ADK_BOOKING_DELIVERY_DATE = 29;
        public static int ADK_BOOKING_PROJECT_CODE = 30;
        public static int ADK_BOOKING_PROFIT_CENTRE = 31;
        public static int ADK_BOOKING_TOTAL_AMOUNT = 32;
        public static int ADK_BOOKING_TEXT1 = 33;
        public static int ADK_BOOKING_TEXT2 = 34;
        public static int ADK_BOOKING_TEXT3 = 35;
        public static int ADK_BOOKING_OUR_CUSTOMER_NUMBER = 36;
        public static int ADK_BOOKING_EANLOC = 37;
        public static int ADK_BOOKING_DELIVERY_EANLOC = 38;
        public static int ADK_BOOKING_ROWS = 39;
        public static int ADK_BOOKING_NROWS = 40;
        public static int ADK_BOOKING_CODE_OF_COUNTRY = 41;
        public static int ADK_BOOKING_DELIVERY_CODE_OF_COUNTRY = 42;
        public static int ADK_BOOKING_CONTRACTNR = 43;
        public static int ADK_BOOKING_LAST = 42;
        
        public static int ADK_CODE_OF_CUSTOMER_DISCOUNT_ROW_FIRST = 0;
        public static int ADK_CODE_OF_CUSTOMER_DISCOUNT_ROW_CODE = 0;
        public static int ADK_CODE_OF_CUSTOMER_DISCOUNT_ROW_ARTICLE_GROUP_FLAG = 1;
        public static int ADK_CODE_OF_CUSTOMER_DISCOUNT_ROW_ARTICLE_GROUP = 2;
        public static int ADK_CODE_OF_CUSTOMER_DISCOUNT_ROW_ARTICLE_NUMBER = 3;
        public static int ADK_CODE_OF_CUSTOMER_DISCOUNT_ROW_PRICELIST = 4;
        public static int ADK_CODE_OF_CUSTOMER_DISCOUNT_ROW_ROW_DISCOUNT = 5;
        public static int ADK_CODE_OF_CUSTOMER_DISCOUNT_ROW_LAST = 5;
        public static int ADK_CODE_OF_ARTICLE_PARCEL_FIRST = 0;
        public static int ADK_CODE_OF_ARTICLE_PARCEL_NR = 0;
        public static int ADK_CODE_OF_ARTICLE_PARCEL_ARTICLE_NR = 1;
        public static int ADK_CODE_OF_ARTICLE_PARCEL_TEXT = 2;
        public static int ADK_CODE_OF_ARTICLE_PARCEL_TEXT2 = 3;
        public static int ADK_CODE_OF_ARTICLE_PARCEL_QUANTITY = 4;
        public static int ADK_CODE_OF_ARTICLE_PARCEL_TOTAL = 5;
        public static int ADK_CODE_OF_ARTICLE_PARCEL_ROWNR = 6;
        public static int ADK_CODE_OF_ARTICLE_PARCEL_TYPE_OF_ROW = 7;
        public static int ADK_CODE_OF_ARTICLE_PARCEL_WRITE_OFFER = 8;
        public static int ADK_CODE_OF_ARTICLE_PARCEL_WRITE_ORDER = 9;
        public static int ADK_CODE_OF_ARTICLE_PARCEL_WRITE_INVOICE = 10;
        public static int ADK_CODE_OF_ARTICLE_PARCEL_WRITE_DELIVERY_NOTE = 11;
        public static int ADK_CODE_OF_ARTICLE_PARCEL_LAST = 11;
        public static int ADK_CODE_OF_ARTICLE_NAME_FIRST = 0;
        public static int ADK_CODE_OF_ARTICLE_NAME_LANGUAGE_CODE = 0;
        public static int ADK_CODE_OF_ARTICLE_NAME_ARTICLE_NUMBER = 1;
        public static int ADK_CODE_OF_ARTICLE_NAME_NAME = 2;
        public static int ADK_CODE_OF_ARTICLE_NAME_NAME2 = 3;
        public static int ADK_CODE_OF_ARTICLE_NAME_LAST = 3;
        
        public static int ADK_PRICE_FIRST = 0;
        public static int ADK_PRICE_PRICE_LIST = 0;
        public static int ADK_PRICE_ARTICLE_NUMBER = 1;
        public static int ADK_PRICE_QUANTITY = 2;
        public static int ADK_PRICE_PRICE = 3;
        public static int ADK_PRICE_BASE = 4;
        public static int ADK_PRICE_PER_CENT = 5;
        public static int ADK_PRICE_DATE_OF_CHANGE = 6;
        public static int ADK_PRICE_LAST = 6;
        
        public static int ADK_ARTICLE_PURCHASE_PRICE_FIRST = 0;
        public static int ADK_ARTICLE_PURCHASE_PRICE_ARTICLE_NUMBER = 0;
        public static int ADK_ARTICLE_PURCHASE_PRICE_SUPPLIER_NUMBER = 1;
        public static int ADK_ARTICLE_PURCHASE_PRICE_QUANTITY = 2;
        public static int ADK_ARTICLE_PURCHASE_PRICE_PRICE = 3;
        public static int ADK_ARTICLE_PURCHASE_PRICE_SUPPLIER_ARTICLE_NUMBER = 4;
        public static int ADK_ARTICLE_PURCHASE_PRICE_BASE = 5;
        public static int ADK_ARTICLE_PURCHASE_PRICE_CHANGED = 6;
        public static int ADK_ARTICLE_PURCHASE_PRICE_CHANGED_DATE = 7;
        public static int ADK_ARTICLE_PURCHASE_PRICE_PRICE_NEW = 8;
        public static int ADK_ARTICLE_PURCHASE_PRICE_PRICE_PER_CENT = 9;
        public static int ADK_ARTICLE_PURCHASE_PRICE_LAST = 9;
        
        public static int ADK_CODE_OF_WAY_OF_PAYMENT_FIRST = 0;
        public static int ADK_CODE_OF_WAY_OF_PAYMENT_CODE = 0;
        public static int ADK_CODE_OF_WAY_OF_PAYMENT_TEXT = 1;
        public static int ADK_CODE_OF_WAY_OF_PAYMENT_ACCOUNT = 2;
        public static int ADK_CODE_OF_WAY_OF_PAYMENT_LAST = 2;
        
        public static int ADK_FREE_CATEGORY_FIRST = 0;
        public static int ADK_FREE_CATEGORY_CATEGORY = 0;
        public static int ADK_FREE_CATEGORY_NAME = 1;
        public static int ADK_FREE_CATEGORY_LAST = 1;
        
        public static int ADK_MEMBER_FIRST = 0;
        public static int ADK_MEMBER_NUMBER = 0;
        public static int ADK_MEMBER_FIRST_NAME = 1;
        public static int ADK_MEMBER_LAST_NAME = 2;
        public static int ADK_MEMBER_OWN_ADDRESS = 3;
        public static int ADK_MEMBER_MAILING_ADDRESS = 4;
        public static int ADK_MEMBER_MAILING_ADDRESS2 = 5;
        public static int ADK_MEMBER_ZIPCODE = 6;
        public static int ADK_MEMBER_CITY = 7;
        public static int ADK_MEMBER_COUNTRY = 8;
        public static int ADK_MEMBER_TELEPHONE = 9;
        public static int ADK_MEMBER_TELEPHONE2 = 10;
        public static int ADK_MEMBER_PERSONAL_NUMBER = 11;
        public static int ADK_MEMBER_SEX = 12;
        public static int ADK_MEMBER_EMAIL = 13;
        public static int ADK_MEMBER_DOCUMENT_PATH = 14;
        public static int ADK_MEMBER_REMARK1 = 15;
        public static int ADK_MEMBER_REMARK2 = 16;
        public static int ADK_MEMBER_CATEGORY = 17;
        public static int ADK_MEMBER_FREE_CATEGORY1 = 18;
        public static int ADK_MEMBER_FREE_CATEGORY2 = 19;
        public static int ADK_MEMBER_FREE_CATEGORY3 = 20;
        public static int ADK_MEMBER_FREE_CATEGORY4 = 21;
        public static int ADK_MEMBER_FREE_CATEGORY5 = 22;
        public static int ADK_MEMBER_FREE_CATEGORY6 = 23;
        public static int ADK_MEMBER_FREE_CATEGORY7 = 24;
        public static int ADK_MEMBER_FREE_CATEGORY8 = 25;
        public static int ADK_MEMBER_FREE_CATEGORY9 = 26;
        public static int ADK_MEMBER_FREE_CATEGORY10 = 27;
        public static int ADK_MEMBER_SORT_ORDER = 28;
        public static int ADK_MEMBER_BGIRO = 29;
        public static int ADK_MEMBER_PGIRO = 30;
        public static int ADK_MEMBER_CODE_OF_TERMS_OF_PAYMENT = 31;
        public static int ADK_MEMBER_PRICE_LIST = 32;
        public static int ADK_MEMBER_LONGEREST_INVOICE = 33;
        public static int ADK_MEMBER_REMINDER = 34;
        public static int ADK_MEMBER_DEMAND_FEE = 35;
        public static int ADK_MEMBER_FAMILY_NUMBER = 36;
        public static int ADK_MEMBER_TEL3 = 37;
        public static int ADK_MEMBER_CODE_OF_COUNTRY = 38;
        public static int ADK_MEMBER_LAST = 36;
        
        public static int ADK_DELIVERY_NOTE_FIRST = 0;
        public static int ADK_DELIVERY_NOTE_DOCUMENT_NUMBER = 0;
        public static int ADK_DELIVERY_NOTE_SUPPLIER_NUMBER = 1;
        public static int ADK_DELIVERY_NOTE_SUPPLIER_NAME = 2;
        public static int ADK_DELIVERY_NOTE_DELIVERY_NUMBER = 3;
        public static int ADK_DELIVERY_NOTE_DATE = 4;
        public static int ADK_DELIVERY_NOTE_ARRIVAL_DATE = 5;
        public static int ADK_DELIVERY_NOTE_CANCELLED = 6;
        public static int ADK_DELIVERY_NOTE_NOTE1 = 7;
        public static int ADK_DELIVERY_NOTE_NOTE2 = 8;
        public static int ADK_DELIVERY_NOTE_NOTE3 = 9;
        public static int ADK_DELIVERY_NOTE_PROJECT_CODE = 10;
        public static int ADK_DELIVERY_NOTE_PROFIT_CENTRE = 11;
        public static int ADK_DELIVERY_NOTE_INVOICE_SENT = 12;
        public static int ADK_DELIVERY_NOTE_CURRENCY_CODE = 13;
        public static int ADK_DELIVERY_NOTE_ROWS = 14;
        public static int ADK_DELIVERY_NOTE_NROWS = 15;
        public static int ADK_DELIVERY_NOTE_DN_ARRIVAL_DATE = 16;
        public static int ADK_DELIVERY_NOTE_DN_DELIVER_DATE = 17;
        public static int ADK_DELIVERY_NOTE_DN_NUMBER = 18;
        public static int ADK_DELIVERY_NOTE_DN_NOT_DONE = 19;
        public static int ADK_DELIVERY_NOTE_DN_CREATED_EDI = 20;
        public static int ADK_DELIVERY_NOTE_LAST = 20;
        
        public static int ADK_PACKAGE_HEAD_FIRST = 0;
        public static int ADK_PACKAGE_HEAD_PACKAGE_NUMBER = 0;
        public static int ADK_PACKAGE_HEAD_PACKAGE_REFERENCE = 1;
        public static int ADK_PACKAGE_HEAD_QUANTITY = 2;
        public static int ADK_PACKAGE_HEAD_TYPE = 3;
        public static int ADK_PACKAGE_HEAD_GROSS_WEIGHT = 4;
        public static int ADK_PACKAGE_HEAD_GROSS_VOLUME = 5;
        public static int ADK_PACKAGE_HEAD_NET_WEIGHT = 6;
        public static int ADK_PACKAGE_HEAD_NET_VOLUME = 7;
        public static int ADK_PACKAGE_HEAD_AREA = 8;
        public static int ADK_PACKAGE_HEAD_IDENT = 9;
        public static int ADK_PACKAGE_HEAD_BATCH_NUMBER = 10;
        public static int ADK_PACKAGE_HEAD_CONNECTION_DOCUMENT = 11;
        public static int ADK_PACKAGE_HEAD_BEST_BEFORE = 12;
        public static int ADK_PACKAGE_HEAD_ROWS = 13;
        public static int ADK_PACKAGE_HEAD_NROWS = 14;
        public static int ADK_PACKAGE_HEAD_LAST = 14;
        public static int ADK_PACKAGE_ROW_FIRST = 0;
        public static int ADK_PACKAGE_ROW_ROWNR = 0;
        public static int ADK_PACKAGE_ROW_NAME = 1;
        public static int ADK_PACKAGE_ROW_QUANTITY = 2;
        public static int ADK_PACKAGE_ROW_ARTICLE_NUMBER = 3;
        public static int ADK_PACKAGE_ROW_SERIAL_NUMBER = 4;
        public static int ADK_PACKAGE_ROW_BATCH_NUMBER = 5;
        public static int ADK_PACKAGE_ROW_BEST_BEFORE = 6;
        public static int ADK_PACKAGE_ROW_ORDER_ROW_NUMBER = 7;
        public static int ADK_PACKAGE_ROW_LAST = 7;
        
        public static int ADK_IMP_PACKAGE_HEAD_FIRST = 0;
        public static int ADK_IMP_PACKAGE_HEAD_PACKAGE_NUMBER = 0;
        public static int ADK_IMP_PACKAGE_HEAD_QUANTITY = 1;
        public static int ADK_IMP_PACKAGE_HEAD_TYPE = 2;
        public static int ADK_IMP_PACKAGE_HEAD_GROSS_WEIGHT = 3;
        public static int ADK_IMP_PACKAGE_HEAD_GROSS_VOLUME = 4;
        public static int ADK_IMP_PACKAGE_HEAD_NET_WEIGHT = 5;
        public static int ADK_IMP_PACKAGE_HEAD_NET_VOLUME = 6;
        public static int ADK_IMP_PACKAGE_HEAD_AREA = 7;
        public static int ADK_IMP_PACKAGE_HEAD_IDENT = 8;
        public static int ADK_IMP_PACKAGE_HEAD_BATCH_NUMBER = 9;
        public static int ADK_IMP_PACKAGE_HEAD_CONNECTION_DOCUMENT = 10;
        public static int ADK_IMP_PACKAGE_HEAD_BEST_BEFORE = 11;
        public static int ADK_IMP_PACKAGE_HEAD_ROWS = 12;
        public static int ADK_IMP_PACKAGE_HEAD_NROWS = 13;
        public static int ADK_IMP_PACKAGE_HEAD_LAST = 13;
        public static int ADK_IMP_PACKAGE_ROW_FIRST = 0;
        public static int ADK_IMP_PACKAGE_ROW_ROWNR = 0;
        public static int ADK_IMP_PACKAGE_ROW_NAME = 1;
        public static int ADK_IMP_PACKAGE_ROW_QUANTITY = 2;
        public static int ADK_IMP_PACKAGE_ROW_ARTICLE_NUMBER = 3;
        public static int ADK_IMP_PACKAGE_ROW_SERIAL_NUMBER = 4;
        public static int ADK_IMP_PACKAGE_ROW_BATCH_NUMBER = 5;
        public static int ADK_IMP_PACKAGE_ROW_BEST_BEFORE = 6;
        public static int ADK_IMP_PACKAGE_ROW_LAST = 6;
        
        public static int ADK_DELIVERY_FIRST = 0;
        public static int ADK_DELIVERY_CUSTOMER_NUMBER = 0;
        public static int ADK_DELIVERY_NAME = 1;
        public static int ADK_DELIVERY_ADDRESS = 2;
        public static int ADK_DELIVERY_ADDRESS2 = 3;
        public static int ADK_DELIVERY_EANLOC = 4;
        public static int ADK_DELIVERY_VISITING_ADDRESS = 5;
        public static int ADK_DELIVERY_ZIPCODE = 6;
        public static int ADK_DELIVERY_CITY = 7;
        public static int ADK_DELIVERY_CODE_OF_COUNTRY = 8;
        public static int ADK_DELIVERY_COUNTRY = 9;
        public static int ADK_DELIVERY_TELEPHONE1 = 10;
        public static int ADK_DELIVERY_TELEPHONE2 = 11;
        public static int ADK_DELIVERY_TELEPHONE3 = 12;
        public static int ADK_DELIVERY_FAX = 13;
        public static int ADK_DELIVERY_LAST = 13;
        
        public static int ADKE_OK = 0;
        public static int ADKE_LONGERNAL = 1;
        public static int ADKE_CUST_DISCOUNT_EXIST = 2;
        public static int ADKE_EXPORT_INVOICE = 3;
        public static int ADKE_OOF_EDIT_DENIED = 4;
        public static int ADKE_NOT_PRLONGED_IF_NOT_READY = 5;
        public static int ADKE_NO_CHANGE_ON_EXPORT = 6;
        public static int ADKE_NO_ARTNR_ON_TEXT_ROW = 7;
        public static int ADKE_NO_ARTNR_CHANGE_ON_PACKET = 8;
        public static int ADKE_EDIT_DENIED_OBLITERATED = 9;
        public static int ADKE_OFFER_EDIT_DENIED_CREATED = 10;
        public static int ADKE_ORDER_EDIT_DENIED_CREATED = 11;
        public static int ADKE_EDIT_DENIED_PRLONGED = 12;
        public static int ADKE_ORDER_EDIT_DENIED_DELIVERED = 13;
        public static int ADKE_ORDER_EDIT_DENIED_NEW_ORDER_CREATED = 14;
        public static int ADKE_ORDER_EDIT_DENIED_NO_GROUP_INVOICE = 15;
        public static int ADKE_ORDER_EDIT_DENIED_ALREADY_REST = 16;
        public static int ADKE_ORDER_EDIT_DENIED_PACKET_NO_REST = 17;
        public static int ADKE_OOF_EDIT_DENIED_SUBSUM = 18;
        public static int ADKE_OOF_EDIT_DENIED_ALREADY_IN_LEDGER = 19;
        public static int ADKE_COULD_NOT_FIND_ARTICLE = 20;
        public static int ADKE_COULD_NOT_FIND_CUSTOMER = 21;
        public static int ADKE_DENIED_PROFIT_CENTRE_ON_ACCOUNT = 22;
        public static int ADKE_INVOICE_EDIT_DENIED_JOURNAL = 23;
        public static int ADKE_INVOICE_EDIT_DENIED_BOOKKEEPING = 24;
        public static int ADKE_INVOICE_EDIT_DENIED_ALREADY_IN_LEDGER = 25;
        public static int ADKE_INVOICE_EDIT_DENIED_OTHER_INVOICE = 26;
        public static int ADKE_INVOICE_EDIT_DENIED_LONGREST_LINE = 27;
        public static int ADKE_INVOICE_EDIT_DENIED_CUSTOMER_NR = 28;
        public static int ADKE_INVOICE_EDIT_DENIED_ORDERINFO = 29;
        public static int ADKE_INVOICE_EDIT_DENIED_AGREEMENT_PERIOD = 30;
        public static int ADKE_INVOICE_EDIT_DENIED_MANUAL = 31;
        public static int ADKE_ARTICLE_DENIED_KLKPRICE_MANUAL = 32;
        public static int ADKE_ARTICLE_DENIED_PARCELART_STOCK = 33;
        public static int ADKE_INVALID_STRING = 34;
        public static int ADKE_INVALID_PRISL = 35;
        public static int ADKE_ORDER_EDIT_DENIED_OFFER_CANT_BE_LOCKED = 36;
        public static int ADKE_CUSTOMER_INVALID_KUNDKAT = 37;
        public static int ADKE_CUSTOMER_INVALID_DISTRIKT = 38;
        public static int ADKE_CUSTOMER_INVALID_SELLER = 39;
        public static int ADKE_INVALID_DELIVERY_TERMS = 40;
        public static int ADKE_INVALID_PAYMENT_TERMS = 41;
        public static int ADKE_INVALID_DELIVERY_WAY = 42;
        public static int ADKE_INVALID_CURRENCY_CODE = 43;
        public static int ADKE_INVALID_LAUNGUAGE_CODE = 44;
        public static int ADKE_ARTICLE_INVALID_ARTGRP = 45;
        public static int ADKE_ARTICLE_INVALID_KONTKOD = 46;
        public static int ADKE_ARTICLE_INVALID_UNITCODE = 47;
        public static int ADKE_ARTICLE_INVALID_SUPPLIER = 48;
        public static int ADKE_OOF_INVALID_CUSTOMER = 49;
        public static int ADKE_OOF_INVALID_ARTICLE = 50;
        public static int ADKE_CUSTOMER_INVALID_CUSTOMERNR = 51;
        public static int ADKE_DBTABLE_CUSTOMER = 52;
        public static int ADKE_DBTABLE_ARTICLE = 53;
        public static int ADKE_DBTABLE_OOF = 54;
        public static int ADKE_DBTABLE_ARTRAD = 55;
        public static int ADKE_DBTABLE_KUNDKAT = 56;
        public static int ADKE_DBTABLE_DISTRICT = 57;
        public static int ADKE_DBTABLE_SELLER = 58;
        public static int ADKE_DBTABLE_DEL_TERMS = 59;
        public static int ADKE_DBTABLE_PAYMENT_TERMS = 60;
        public static int ADKE_DBTABLE_CURRENCY_CODE = 61;
        public static int ADKE_DBTABLE_LANGUAGE_CODE = 62;
        public static int ADKE_DBTABLE_PRICELIST = 63;
        public static int ADKE_DBTABLE_ARTGROUP = 64;
        public static int ADKE_DBTABLE_ARTKNT_KONTKOD = 65;
        public static int ADKE_DBTABLE_UNIT_CODE = 66;
        public static int ADKE_DBTABLE_SUPPLIER = 67;
        public static int ADKE_DBTABLE_PRICEL = 68;
        public static int ADKE_DBTABLE_LEVFKT = 69;
        public static int ADKE_DBTABLE_ACCOUNT = 70;
        public static int ADKE_DBTABLE_PROJECT = 71;
        public static int ADKE_DBTABLE_DEL_WAY = 72;
        public static int ADKE_DBTABLE_DISCOUNT_AGREEMENT = 73;
        public static int ADKE_DBTABLE_RESULT_UNIT = 74;
        public static int ADKE_INVALID_DB_PROG = 75;
        public static int ADKE_INVALID_DB_NEWER = 76;
        public static int ADKE_INVALID_DB_OLDER = 77;
        public static int ADKE_BOF = 78;
        public static int ADKE_EOF = 79;
        public static int ADKE_NO_DB_OPEN = 80;
        public static int ADKE_ADD = 81;
        public static int ADKE_FIND = 82;
        public static int ADKE_FIRST = 83;
        public static int ADKE_NEXT = 84;
        public static int ADKE_UPDATE = 85;
        public static int ADKE_SET_LONG = 86;
        public static int ADKE_SET_BOOL = 87;
        public static int ADKE_SET_DOUBLE = 88;
        public static int ADKE_SET_STRING = 89;
        public static int ADKE_SET_DATA = 90;
        public static int ADKE_SET_DATE = 91;
        public static int ADKE_GET_STRING = 92;
        public static int ADKE_GET_LONG = 93;
        public static int ADKE_GET_BOOL = 94;
        public static int ADKE_GET_DOUBLE = 95;
        public static int ADKE_GET_DATE = 96;
        public static int ADKE_GET_TYPE = 97;
        public static int ADKE_GET_DATA = 98;
        public static int ADKE_GET_DATA_ROW = 99;
        public static int ADKE_OPEN = 100;
        public static int ADKE_DELETE_STRUCT = 101;
        public static int ADKE_UNKNON_DB_FIELD = 102;
        public static int ADKE_INVALID_DATA_TYPE = 103;
        public static int ADKE_NOT_VALID_SORTORDER = 104;
        public static int ADKE_NO_PRICELIST = 105;
        public static int ADKE_COULD_NOT_FIND_SUPPLIER = 106;
        public static int ADKE_INVALID_DB = 107;
        public static int ADKE_INVALID_CONTROLNR = 108;
        public static int ADKE_EDIT_DENIED_FIELD = 109;
        public static int ADKE_INVALID_INVOICE_TYPE = 110;
        public static int ADKE_INVALID_INDEX = 111;
        public static int ADKE_NO_KEY = 112;
        public static int ADKE_LONG_TO_DATE = 113;
        public static int ADKE_TO_SHORT_STRING = 114;
        public static int ADKE_NOT_FOUND = 115;
        public static int ADKE_INVALID_PATH_COMPANY = 116;
        public static int ADKE_SET_SORT_ORDER = 117;
        public static int ADKE_NO_ACTIVE_PRICE_LIST = 118;
        public static int ADKE_RECIEVER_NUMBER_USED = 119;
        public static int ADKE_INVALID_CODE_OF_FEE = 120;
        public static int ADKE_DENIED_DELETE_CODE_SWE = 121;
        public static int ADKE_DENIED_DELETE_CODE_DOMESTIC = 122;
        public static int ADKE_DENIED_DELETE_CODE_USED = 123;
        public static int ADKE_IN_DISCOUNT_AGREEMENT = 124;
        public static int ADKE_DENIED_DELETE_RES_CODE_USED = 125;
        public static int ADKE_DENIED_DELETE_RES_CODE_ING = 126;
        public static int ADKE_DENIED_DELETE_RES_CODE_BUDGET = 127;
        public static int ADKE_INVALID_NET_LICENCE = 128;
        public static int ADKE_INVALID_TIME = 129;
        public static int ADKE_INVALID_SERIAL = 130;
        public static int ADKE_INVALID_ADM_PATH_INI = 131;
        public static int ADKE_APP_OLD = 132;
        public static int ADKE_APP_NEW = 133;
        public static int ADKE_CANT_OPEN_FILE = 134;
        public static int ADKE_TOO_MANY_LICENCE = 135;
        public static int ADKE_UTDATE_ARTICLE_NUMBER_DENIED = 136;
        public static int ADKE_INVALID_ADM_PATH = 137;
        public static int ADKE_DATE_TO_LONG = 138;
        public static int ADKE_NO_NAME = 139;
        public static int ADKE_EDIT_DENIED_PAYMENT_JOURNAL = 140;
        public static int ADKE_EDIT_DENIED_INVOICE_PAYED = 141;
        public static int ADKE_EDIT_DENIED_PAYMENTS_ON_INVOICE = 142;
        public static int ADKE_EDIT_DENIED_ROWS_TO_SUPPLIER = 143;
        public static int ADKE_DENIED_BAD_ROW_TYPE = 144;
        public static int ADKE_DENIED_INVOICE_ROW = 145;
        public static int ADKE_DENIED_BST_OTHER_SUPPLIER = 146;
        public static int ADKE_DENIED_COLLECTION_INVOICE = 147;
        public static int ADKE_INVLAID_ACCOUNT = 148;
        public static int ADKE_INVLAID_PROJECT = 149;
        public static int ADKE_INVLAID_RESULT_UNIT = 150;
        public static int ADKE_NO_ARTICLE_TO_DELIVER = 151;
        public static int ADKE_INVALID_DISCOUNT_AGGREMENT = 152;
        public static int ADKE_INVALID_ROW_CONNECTION = 153;
        public static int ADKE_DELETE = 154;
        public static int ADKE_DELETE_DENIED_CONNECTION = 155;
        public static int ADKE_DELETE_DENIED_DEBT = 156;
        public static int ADKE_DELETE_DENIED_STOCK = 157;
        public static int ADKE_DELETE_DENIED_RESERVATION = 158;
        public static int ADKE_DELETE_DENIED_ORDER = 159;
        public static int ADKE_DELETE_DENIED_PARCEL = 160;
        public static int ADKE_DELETE_DENIED_INVALID_TYPE = 161;
        public static int ADKE_DELETE_DENIED_INVOICE_ROWS = 162;
        public static int ADKE_DELETE_DENIED_ONLY_PLANED_DIRECT = 163;
        public static int ADKE_DELETE_DENIED = 164;
        public static int ADKE_DELETE_ROW = 165;
        public static int ADKE_INVALID_BST = 166;
        public static int ADKE_END_BEFORE_START = 167;
        public static int ADKE_END_AND_START = 168;
        public static int ADKE_INVALID_FLJ = 169;
        public static int ADKE_NOT_TYPE_AND_DOC = 170;
        public static int ADKE_INVALID_OFFER = 171;
        public static int ADKE_INVALID_ORDER = 172;
        public static int ADKE_INVALID_INVOICE = 173;
        public static int ADKE_INVALID_AGREEMENT = 174;
        public static int ADKE_INVALID_JOURNAL = 175;
        public static int ADKE_INVALID_VER = 176;
        public static int ADKE_NO_SEARCH_VALUE = 177;
        public static int ADKE_GET_LENGTH = 178;
        public static int ADKE_GET_DECIMALS = 179;
        public static int ADKE_TOO_MANY_SIGNS = 180;
        public static int ADKE_TOO_MANY_DECIMALS = 181;
        public static int ADKE_EDIT_DENIED_ON_TEXT_ROW = 182;
        public static int ADKE_CANT_FIND_ACCOUNT = 183;
        public static int ADKE_OLD_PROJECT_NUMBER = 184;
        public static int ADKE_DB_NOT_ADM_2000 = 185;
        public static int ADKE_GET_FIELD_NAME = 186;
        public static int ADKE_NO_DB_INVOLVED = 187;
        public static int ADKE_NO_FIELD_INVOLVED = 188;
        public static int ADKE_QUARTER_DENIED_IF_NO_VAT = 189;
        public static int ADKE_DENIED_FOLJ_MAKUL = 190;
        public static int ADKE_DENIED_FOLJ_INVALID_SUPPIER = 191;
        public static int ADKE_DENIED_PROJECT_ON_ACCOUNT = 192;
        public static int ADKE_DENIED_DELETE_CURRENCY_CODE_SWE = 193;
        public static int ADKE_DENIED_DELETE_CURRENCY_CODE_DOMESTIC = 194;
        public static int ADKE_CAN_NOT_CHANGE_ARTICLE_ROW_TO_TEXT_ROW = 195;
        public static int ADKE_CAN_NOT_CHANGE_TEXT_ROW_TO_ARTICLE_ROW = 196;
        public static int ADKE_INVALID_ROW_TYPE = 197;
        public static int ADKE_CAN_NOT_CHANGE_TEXT_ROW_TO_SUB_SUM = 198;
        public static int ADKE_CAN_NOT_CHANGE_OOF_TYPE = 199;
        public static int ADKE_CAN_NOT_CHANGE_SUB_SUM_TO_TEXT_ROW = 200;
        public static int ADKE_DENIED_UPDATE_TEXT_ROW = 201;
        public static int ADKE_ARTICLE_DENIED_NEED_GROUND_PRICE = 202;
        public static int ADKE_ORDER_EDIT_DENIED_CHANGE_DATE_ON_PACKET = 203;
        public static int ADKE_PREVIOUS = 204;
        public static int ADKE_LAST = 205;
        public static int ADKE_CANT_UPDATE_ART_NR = 206;
        public static int ADKE_DB_NOT_ADM_1000 = 207;
        public static int ADKE_FIELD_NOT_IN_ADM_VER = 208;
        public static int ADKE_CURRENCY_LANGUAGE_INACTIVE = 209;
        public static int ADKE_BARCODE_INACTIVE = 210;
        public static int ADKE_INVALID_STRUCT_POLONGER = 211;
        public static int ADKE_INVALID_STRUCT_POLONGER_TO_ROW = 212;
        public static int ADKE_ARTICLE_INVALID_BARCODE = 213;
        public static int ADKE_KEY_TAKEN_IN_NUMBERSERIES = 214;
        public static int ADKE_INVALID_SUPPLIER_ART_NUMBER = 215;
        public static int ADKE_INVALID_POST = 216;
        public static int ADKE_ORDER_HAS_CREATED_INVOICE = 217;
        public static int ADKE_ORDER_HAS_OTHER_OFFERNR = 218;
        public static int ADKE_OFFER_HAS_OTHER_ORDERNR = 219;
        public static int ADKE_ORDER_HAS_OTHER_INVOICENR = 220;
        public static int ADKE_INVOICE_HAS_OTHER_ORDERNR = 221;
        public static int ADKE_OOF_INVALID_BARCODE = 222;
        public static int ADKE_API_APP_DIFF = 223;
        public static int ADKE_EDIT_DENIED_ALREADY_IN_LEDGER = 224;
        public static int ADKE_DELIVERY_NO_STOCK_OBJECT = 225;
        public static int ADKE_QUANTITY_0 = 226;
        public static int ADKE_NO_ARTNR = 227;
        public static int ADKE_ONLY_OBLITERATED = 228;
        public static int ADKE_DBTABLE_INVENTORY = 229;
        public static int ADKE_DBTABLE_MANUAL_DELIVERY_IN = 230;
        public static int ADKE_DBTABLE_MANUAL_DELIVERY_OUT = 231;
        public static int ADKE_DBTABLE_DISPATCHER = 232;
        public static int ADKE_DENIED_CREDIT_CREDIT_INVOICE = 233;
        public static int ADKE_DENIED_CREDIT_OBLITERATED_INVOICE = 234;
        public static int ADKE_INVALID_TYPE_TO_COPY = 235;
        public static int ADKE_INVALID_DISPATCHER = 236;
        public static int ADKE_EDIT_DENIED_ON_THIS_INVOICE = 237;
        public static int ADKW_CREDIT_LIMIT = 238;
        public static int ADKW_RECIEVER_NUMBER_UNIQUE = 239;
        public static int ADKW_ONLY_NUMBERS_IN_SWIFT_ADDRES = 240;
        public static int ADKW_CHANGE_CURRENCY_CODE = 241;
        public static int ADKW_OCR_FOREIGN = 242;
        public static int ADKW_OCR_SUPPLIER = 243;
        public static int ADKW_OCR_ZIPCODE = 244;
        public static int ADKW_DENIED_FOLJESEDEL = 245;
        public static int ADKW_ARTICLE_STOCK_TRANSACTION = 246;
        public static int ADKW_ORDER_SUM = 247;
        public static int ADKW_VER_ON_PROJECT = 248;
        public static int ADKW_NOT_OCR_BUT_ZIP = 249;
        public static int ADKW_OCR_BUT_NOT_ZIP = 250;
        public static int ADKW_COULD_NOT_FIND_ARTICLE_PRICE = 251;
        public static int ADKW_CHANGED_STOCK = 252;
        public static int ADKW_CANT_FIND_TEMPLATE = 253;
        public static int ADKW_INVALID_FIND_TEMPLATE = 254;
        public static int ADKW_UPDATING_TEXTROW = 255;
        public static int ADKW_ACCOUNT_NOT_ACTIVE = 256;
        public static int ADKW_CALCPRICE_MISSING = 257;
        public static int ADKW_DELIVERY_IN_NO_PRICE = 258;
        public static int ADKW_ROWS_NOT_UPDATED = 259;
        public static int ADKW_SWIFT_AND_BG_NECESSARY = 260;
        public static int ADKE_CAN_NOT_CONNECT_CREDIT = 261;
        public static int ADKE_ORDER_DOESNT_EXIST = 262;
        public static int ADKE_ORDER_MAKUL = 263;
        public static int ADKE_OFFER_DOESNT_EXIST = 264;
        public static int ADKE_OFFER_MAKUL = 265;
        public static int ADKE_OOI_CONNECT_NROWS_NOT_ZERO = 266;
        public static int ADKE_CONNECTION_NUMBER1 = 267;
        public static int ADKE_CANT_ERASE_BG_SWIFT = 268;
        public static int ADKE_ONLY_FOR_EUR_SEK = 269;
        public static int ADKE_BG_CODE_OF_FEE_FOR_PAYMENT_ABROAD = 270;
        public static int ADKE_BG_CODE_OF_FEE_MUST_BE_RECIP_PAYS_FOREIGN = 271;
        public static int ADKE_BG_CODE_OF_FEE_NOT_SUPPORTED_BY_BANK = 272;
        public static int ADKE_NO_CHANGE_CLOSED_PROJECT1 = 273;
        public static int ADKE_DB_NOT_ADM_500 = 274;
        public static int ADKE_DB_NOT_ADM_FOR = 275;
        public static int ADKE_DBTABLE_BOOKING = 276;
        public static int ADKE_INVOICE_OR_DELIVERY_NOTE_PRLONGED = 277;
        public static int ADKE_DBTABLE_NOT_IN_ADM_VER = 278;
        public static int ADKE_INVALID_COUNTRY_CODE = 279;
        public static int ADKE_DBTABLE_PRICE = 280;
        public static int ADKE_GETADMSIZE = 281;
        public static int ADKE_CANT_CHANGE_WRITE_FLAG = 282;
        public static int ADKE_CANT_CHANGE_WHEN_WRITE_FLAG = 283;
        public static int ADKE_DOC_SENT_EDI = 284;
        public static int ADKE_DBTABLE_MEMBER = 285;
        public static int ADKE_DELETE_DENIED_HEAD_OF_FAMILY = 286;
        public static int ADKE_DELETE_DENIED_MEMBER_OF_FAMILY = 287;
        public static int ADKE_HEAD_OF_FAMILY_NEED_OWN_ADRESS = 288;
        public static int ADKW_FAILED_LOAD_ADDRESS_FROM_HEAD_OF_FAMILY = 289;
        public static int ADKW_FAILED_LOAD_ADDRESS_TO_MEMBER_OF_FAMILY = 290;
        public static int ADKE_INVALID_FREE_CATEGORY_1 = 291;
        public static int ADKE_INVALID_FREE_CATEGORY_2 = 292;
        public static int ADKE_INVALID_FREE_CATEGORY_3 = 293;
        public static int ADKE_INVALID_FREE_CATEGORY_4 = 294;
        public static int ADKE_INVALID_FREE_CATEGORY_5 = 295;
        public static int ADKE_INVALID_FREE_CATEGORY_6 = 296;
        public static int ADKE_INVALID_FREE_CATEGORY_7 = 297;
        public static int ADKE_INVALID_FREE_CATEGORY_8 = 298;
        public static int ADKE_INVALID_FREE_CATEGORY_9 = 299;
        public static int ADKE_INVALID_FREE_CATEGORY_10 = 300;
        public static int ADKE_FREE_CATEGORY_1_INACTIVE = 301;
        public static int ADKE_FREE_CATEGORY_2_INACTIVE = 302;
        public static int ADKE_FREE_CATEGORY_3_INACTIVE = 303;
        public static int ADKE_FREE_CATEGORY_4_INACTIVE = 304;
        public static int ADKE_FREE_CATEGORY_5_INACTIVE = 305;
        public static int ADKE_FREE_CATEGORY_6_INACTIVE = 306;
        public static int ADKE_FREE_CATEGORY_7_INACTIVE = 307;
        public static int ADKE_FREE_CATEGORY_8_INACTIVE = 308;
        public static int ADKE_FREE_CATEGORY_9_INACTIVE = 309;
        public static int ADKE_FREE_CATEGORY_10_INACTIVE = 310;
        public static int ADKE_DBTABLE_ARTICLE_PARCEL = 311;
        public static int ADKE_DBTABLE_PURCHASE_PRICE = 312;
        public static int ADKE_DBTABLE_ORDER = 313;
        public static int ADKE_DBTABLE_ORDER_ROW = 314;
        public static int ADKE_DBTABLE_OFFER = 315;
        public static int ADKE_DBTABLE_OFFER_ROW = 316;
        public static int ADKE_DBTABLE_BOOKING_ROW = 317;
        public static int ADKE_DBTABLE_FREE_CATEGORIES = 318;
        public static int ADKE_INVALID_GENDER = 319;
        public static int ADKE_MEMBER_OF_FAMILY_NOT_OWN_ADRESS = 320;
        public static int ADKE_SORTORDER_NOT_IN_ADM_VER = 321;
        public static int ADKE_EDIT_DENIED_MARKED_NOT_DONE = 322;
        public static int ADKE_INVOICE_EDIT_DENIED_CUSTOMER_NAME = 323;
        public static int ADKE_ORDER_EDIT_DENIED_ROWS_IN_LEDGER = 324;
        public static int ADKE_SWIFT_AND_BG_NECESSARY = 325;
        public static int ADKW_CHANGE_OF_CURRENCY_CODE = 326;
        public static int ADKW_CHANGE_OF_CURRENCY_RATE = 327;
        public static int ADKW_CHANGE_OF_CUSTOMER_OTHER_CURRENCY = 328;
        public static int ADKE_MEMBER_IN_FAMILY = 329;
        public static int ADKE_DATE2_ONLY_FOR_MEMBER_FEE = 330;
        public static int ADKE_MEMBER_FEE_MUST_HAVE_DATE2 = 331;
        public static int ADKE_LAST_ERROR_CODE = 331;
        
        #endregion
        
        #region +++ Public API Structs +++
        
        public struct ADKERROR
        {
            public int lRc;
            public int lDbTable;
            public int lField;
            public int lFunction;
            public int lProgramPart;
        }
        
        #endregion
        
        #region +++ Public API Enums +++
        
        public enum ADK_SORT_ORDER
        {
            // Gemensamma (Customer, Offer, Order, Invoice)
            eCustomerNr = 0,
            
            // ADK_CUSTOMER_NUMBER, ADK_OOI_HEAD_CUSTOMER_NUMBER - eChar
            eCustomerName = 1,
            
            // ADK_CUSTOMER_NAME, ADK_OOI_HEAD_CUSTOMER_NAME - eChar
            // Gemensamma (SupplierInvoice, Supplier)
            eSupplierNr = 2,
            
            // ADK_SUPPLIER_NUMBER, ADK_SUP_INV_HEAD_SUPPLIER_NUMBER - eChar
            eSupplierName = 3,
            
            // ADK_SUPPLIER_NAME, ADK_SUP_INV_HEAD_NAME - eChar
            // Customer
            eCustomerShortName = 4,
            
            // ADK_CUSTOMER_SHORT_NAME - eChar
            eCustomerPostCode = 5,
            
            // ADK_CUSTOMER_ZIPCODE - eChar
            eCustomerSortOrder = 6,
            
            // ADK_CUSTOMER_SORT_ORDER - eChar
            // Offer
            eOfferNr = 7,
            
            // ADK_OOI_HEAD_DOCUMENT_NUMBER - eDouble
            eOfferDate = 8,
            
            // ADK_OOI_HEAD_DOCUMENT_DATE1 - eDate
            // Order
            eOrderNr = 9,
            
            // ADK_OOI_HEAD_DOCUMENT_NUMBER - eDouble
            eOrderDate = 10,
            
            // ADK_OOI_HEAD_DOCUMENT_DATE1 - eDate
            eOrderDeliveryDate = 11,
            
            // ADK_OOI_HEAD_DOCUMENT_DATE2 - eDate
            // Invoice
            eInvoiceNr = 12,
            
            // ADK_OOI_HEAD_DOCUMENT_NUMBER - eDouble
            eInvoiceDate = 13,
            
            // ADK_OOI_HEAD_DOCUMENT_DATE1 - eDate
            // SupplierInvoice
            eSupplierInvoiceNr = 14,
            
            // ADK_SUP_INV_HEAD_GIVEN_NUMBER - eDouble
            eSupplierInvoiceExpireDate = 15,
            
            // ADK_SUP_INV_HEAD_DUE_DATE - eDate
            // Article
            eArticleNr = 16,
            
            // ADK_ARTICLE_NUMBER - eChar
            eArticleName = 17,
            
            // ADK_ARTICLE_NAME - eChar
            eArticleShortName = 18,
            
            // ADK_ARTICLE_SHORT_NAME - eChar
            eArticleSortOrder = 19,
            
            // ADK_ARTICLE_SORT_ORDER - eChar
            eArticleGroup = 20,
            
            // ADK_ARTICLE_GROUP - eChar
            // Account
            eAccountNr = 21,
            
            // ADK_ACCOUNT_NUMBER - eChar
            eAccountText = 22,
            
            // ADK_ACCOUNT_TEXT - eChar
            // Project
            eProjectCode = 23,
            
            // ADK_PROJECT_CODE_OF_PROJECT - eChar
            eProjectName = 24,
            
            // ADK_PROJECT_NAME - eChar
            // Supplier
            eSupplierShortName = 25,
            
            // ADK_SUPPLIER_SHORT_NAME - eChar
            eSupplierSortOrder = 26,
            
            // ADK_SUPPLIER_SORT_ORDER - eChar
            eSupplierTelephone = 27,
            
            // ADK_SUPPLIER_TELEPHONE - eChar
            // Code of Delivery
            eCodeOfTermsOfDelivery = 28,
            
            // ADK_CODE_OF_TERMS_OF_DELIVERY_CODE - eChar
            // Way of Delivery
            eCodeOfWayOfDelivery = 29,
            
            // ADK_CODE_OF_WAY_OF_DELIVERY_CODE - eChar
            // Code of Peyment Terms
            eCodeOfTermsOfPayment = 30,
            
            // ADK_CODE_OF_TERMS_OF_PAYMENT_CODE - eChar
            // Code Of Language
            eCodeOfLanguage = 31,
            
            // ADK_CODE_OF_LANGUAGE_CODE - eChar
            eCodeOfLanguageText = 32,
            
            // ADK_CODE_OF_LANGUAGE_TEXT - eChar
            // Code Of Currency
            eCodeOfCurrency = 33,
            
            // ADK_CODE_OF_CURRENCY_CODE - eChar
            // Code of Customer Category
            eCodeOfCustomerCategory = 34,
            
            // ADK_CODE_OF_CUSTOMER_CATEGORY_CODE - eChar
            // Code of District
            eCodeOfDistrict = 35,
            
            // ADK_CODE_OF_DISTRICT_CODE - eChar
            // Code of Seller
            eCodeOfSeller = 36,
            
            // ADK_CODE_OF_SELLER_SIGN - eChar
            // Discount agreement
            eDiscountAgreementNr = 37,
            
            // ADK_DISCOUNT_AGREEMENT_CODE - eChar
            eDiscountAgreementText = 38,
            
            // ADK_DISCOUNT_AGREEMENT_TEXT - eChar
            // Code of Article Group
            eCodeOfArticleGroup = 39,
            
            // ADK_CODE_OF_ARTICLE_GROUP_CODE - eChar
            // Code of Article Account
            eCodeOfArticleAccount = 40,
            
            // ADK_CODE_OF_ARTICLE_ACCOUNT_CODE - eChar
            // Code of Unit
            eCodeOfUnit = 41,
            
            // ADK_CODE_OF_UNIT_CODE - eChar
            // Code of Profit Centre
            eCodeOfProfitCentreUnit = 42,
            
            // ADK_CODE_OF_PROFIT_CENTRE_CODE - eChar
            // Code of PriceList
            eCodeOfPriceList = 43,
            
            // ADK_CODE_OF_PRICE_LIST_CODE - eChar
            // Offer
            eOfferNotOrderCustomerNr = 44,
            
            // ADK_OOI_HEAD_CUSTOMER_NUMBER - eChar
            eOfferNotPrlongedOfferNr = 45,
            
            // ADK_OOI_HEAD_DOCUMENT_NUMBER - eDouble
            eOfferNotPrlongedDate = 46,
            
            // ADK_OOI_HEAD_DOCUMENT_DATE1 - eDate
            eOfferNotPrlongedCustomerNr = 47,
            
            // ADK_OOI_HEAD_CUSTOMER_NUMBER - eChar
            eOfferNotPrlongedCustomerName = 48,
            
            // ADK_OOI_HEAD_CUSTOMER_NAME - eChar
            // Order
            eOrderNoInvoiceCustomerNr = 49,
            
            // ADK_OOI_HEAD_CUSTOMER_NUMBER - eChar
            eOrderBackorderOrderNr = 50,
            
            // ADK_OOI_HEAD_DOCUMENT_NUMBER - eDouble
            eOrderNotPrlongedOrderNr = 51,
            
            // ADK_OOI_HEAD_DOCUMENT_NUMBER - eDouble
            eOrderNotPrlongedDate = 52,
            
            // ADK_OOI_HEAD_DOCUMENT_DATE1 - eDate
            eOrderNotPrlongedCustomerNr = 53,
            
            // ADK_OOI_HEAD_CUSTOMER_NUMBER - eChar
            eOrderNotPrlongedCustomerName = 54,
            
            // ADK_OOI_HEAD_CUSTOMER_NAME - eChar
            eOrderNotPrlongedDeliveryDate = 55,
            
            // ADK_OOI_HEAD_DOCUMENT_DATE2 - eDate
            eOrderNoDeliveryNoteOrderNr = 56,
            
            // ADK_OOI_HEAD_DOCUMENT_NUMBER - eDouble
            eOrderNoDeliveryNoteDate = 57,
            
            // ADK_OOI_HEAD_DOCUMENT_DATE1 - eDate
            eOrderNoDeliveryNoteCustomerNr = 58,
            
            // ADK_OOI_HEAD_CUSTOMER_NUMBER - eChar
            eOrderNoDeliveryNoteCustomerName = 59,
            
            // ADK_OOI_HEAD_CUSTOMER_NAME - eChar
            eOrderNoDeliveryNoteDeliveryDate = 60,
            
            // ADK_OOI_HEAD_DOCUMENT_DATE2 - eDate
            // Invoice
            eInvoiceInledgerExpireDate = 61,
            
            // ADK_OOI_HEAD_DOCUMENT_DATE2 - eDate
            eInvoiceInledgerCustomerNr = 62,
            
            // ADK_OOI_HEAD_CUSTOMER_NUMBER - eChar
            eInvoiceInledgerCustomerName = 63,
            
            // ADK_OOI_HEAD_CUSTOMER_NAME - eChar
            eInvoiceInledgerInvoiceNr = 64,
            
            // ADK_OOI_HEAD_DOCUMENT_NUMBER - eDouble
            eInvoiceNotPayedCustomerNr = 65,
            
            // ADK_OOI_HEAD_CUSTOMER_NUMBER - eChar
            eInvoiceNotPayedDate = 66,
            
            // ADK_OOI_HEAD_DOCUMENT_DATE2 - eDate
            eInvoicePayedCustomerNr = 67,
            
            // ADK_OOI_HEAD_CUSTOMER_NUMBER - eChar
            eInvoiceManuellInvoiceNr = 68,
            
            // ADK_OOI_HEAD_DOCUMENT_NUMBER - eDouble
            eInvoiceNotPrlongedInvoiceNr = 69,
            
            // ADK_OOI_HEAD_DOCUMENT_NUMBER - eDouble
            eInvoiceNotPrlongedDate = 70,
            
            // ADK_OOI_HEAD_DOCUMENT_DATE1 - eDate
            eInvoiceNotPrlongedCustomerNr = 71,
            
            // ADK_OOI_HEAD_CUSTOMER_NUMBER - eChar
            eInvoiceNotPrlongedCustomerName = 72,
            
            // ADK_OOI_HEAD_CUSTOMER_NAME - eChar
            eInvoiceNolongrestInvoiceNr = 73,
            
            // ADK_OOI_HEAD_DOCUMENT_NUMBER - eDouble
            eInvoiceNolongrestCustomerNr = 74,
            
            // ADK_OOI_HEAD_CUSTOMER_NUMBER - eChar
            eInvoiceAgreementInvoiceNr = 75,
            
            // ADK_OOI_HEAD_DOCUMENT_NUMBER - eDouble
            // SupplierInvoice
            eSupplierInvoiceNotPayedInvoiceNr = 76,
            
            // ADK_SUP_INV_HEAD_GIVEN_NUMBER - eDouble
            eSupplierInvoiceNotPayedSupplierNr = 77,
            
            // ADK_SUP_INV_HEAD_SUPPLIER_NUMBER - eChar
            eSupplierInvoiceNotPayedSupplierName = 78,
            
            // ADK_SUP_INV_HEAD_SUPPLIER_NAME - eChar
            eSupplierInvoiceNotPayedExpireDate = 79,
            
            // ADK_SUP_INV_HEAD_DUE_DATE - eDate
            eSupplierInvoicePayedSupplierNr = 80,
            
            // ADK_SUP_INV_HEAD_SUPPLIER_NUMBER - eChar
            eSupplierInvoicePaymentAbroadInvoiceNr = 81,
            
            // ADK_SUP_INV_HEAD_GIVEN_NUMBER - eDouble
            eSupplierInvoicePaymentAbroadSupplierNr = 82,
            
            // ADK_SUP_INV_HEAD_SUPPLIER_NUMBER - eChar
            eSupplierInvoicePaymentAbroadSupplierName = 83,
            
            // ADK_SUP_INV_HEAD_SUPPLIER_NAME - eChar
            eSupplierInvoicePaymentAbroadExpireDate = 84,
            
            // ADK_SUP_INV_HEAD_DUE_DATE - eDate
            eSupplierInvoiceDomesticInvoiceNr = 85,
            
            // ADK_SUP_INV_HEAD_GIVEN_NUMBER - eDouble
            eSupplierInvoiceDomesticSupplierNr = 86,
            
            // ADK_SUP_INV_HEAD_SUPPLIER_NUMBER - eChar
            eSupplierInvoiceDomesticSupplierName = 87,
            
            // ADK_SUP_INV_HEAD_SUPPLIER_NAME - eChar
            eSupplierInvoiceDomesticExpireDate = 88,
            
            // ADK_SUP_INV_HEAD_DUE_DATE - eDate
            eSupplierInvoiceNotJournalInvoiceNr = 89,
            
            // ADK_SUP_INV_HEAD_GIVEN_NUMBER - eDouble
            // Article
            eArticleLackOf = 90,
            
            // ADK_ARTICLE_NUMBER - eChar
            eArticlePlaceInStock = 91,
            
            // ADK_ARTICLE_PLACE_IN_STOCK, ADK_INVENTORY_ARTICLE_ARTICLE_PLACE_IN_STOCK - eChar
            // Account
            eAccountActiveNr = 92,
            
            // ADK_ACCOUNT_NUMBER - eChar
            eAccountActiveText = 93,
            
            // ADK_ACCOUNT_TEXT - eChar
            // Project
            eProjectNotFinishedCode = 94,
            
            // ADK_PROJECT_CODE_OF_PROJECT - eChar
            eProjectNotFinishedName = 95,
            
            // ADK_PROJECT_NAME - eChar
            eProjectFinishedCode = 96,
            
            // ADK_PROJECT_CODE_OF_PROJECT - eChar
            eProjectFinishedName = 97,
            
            // ADK_PROJECT_NAME - eChar
            // ManualDeliveryIn
            eManualDeliveryIn = 98,
            
            // ADK_MANUAL_DELIVERY_IN_DOCUMENT_NUMBER - eDouble
            // ManualDeliveryOut
            eManualDeliveryOut = 99,
            
            // ADK_MANUAL_DELIVERY_OUT_DOCUMENT_NUMBER - eDouble
            // Dispatcher
            eDispatcher = 100,
            
            // ADK_DISPATCHER_ID - eChar
            // Booking
            eBookingNr = 101,
            
            // ADK_BOOKING_DOCUMENT_NUMBER - eDouble
            eBookingSupplierNumber = 102,
            
            // ADK_BOOKING_SUPPLIER_NUMBER - eChar
            eBookingSupplierName = 103,
            
            // ADK_BOOKING_SUPPLIER_NAME - eChar
            eBookingNotPrlongedBookingNr = 104,
            
            // ADK_BOOKING_DOCUMENT_NUMBER - eDouble
            eBookingNotPrlongedSupplierNumber = 105,
            
            // ADK_BOOKING_SUPPLIER_NUMBER - eChar
            eBookingNotPrlongedDeliveryDate = 106,
            
            // ADK_BOOKING_DELIVERY_DATE - eDate
            eBookingNotDeliveredBookingNr = 107,
            
            // ADK_BOOKING_DOCUMENT_NUMBER - eDouble
            eBookingNotDeliveredSupplierNumber = 108,
            
            // ADK_BOOKING_SUPPLIER_NUMBER - eChar
            eBookingNotDeliveredSupplierName = 109,
            
            // ADK_BOOKING_SUPPLIER_NAME - eChar
            eBookingNotDeliveredSupplierDeliveryDate = 110,
            
            // ADK_BOOKING_DELIVERY_DATE - eDate
            // CustomerDiscountRow
            eCustomerDiscountRowArtGrp = 111,
            
            // ADK_CODE_OF_CUSTOMER_DISCOUNT_ROW_CODE - eChar
            eCustomerDiscountRowArtNr = 112,
            
            // ADK_CODE_OF_CUSTOMER_DISCOUNT_ROW_CODE - eChar
            // ArticleParcel
            eArticleParcelRowNrParcel = 113,
            
            // ADK_CODE_OF_ARTICLE_PARCEL_NR - eChar
            eArticleParcelArticleNrParcel = 114,
            
            // ADK_CODE_OF_ARTICLE_PARCEL_NR - eChar
            eArticleParcelArticleNr = 115,
            
            // ADK_CODE_OF_ARTICLE_PARCEL_ARTICLE_NR - eChar
            // ArticleName
            eArticleNameNr = 116,
            
            // ADK_CODE_OF_ARTICLE_NAME_ARTICLE_NUMBER - eChar
            // Price
            ePriceArticleNr = 117,
            
            // ADK_PRICE_ARTICLE_NUMBER - eChar
            ePriceBaseArticleNr = 118,
            
            // ADK_PRICE_ARTICLE_NUMBER - eChar
            ePriceNotBaseArticleNr = 119,
            
            // ADK_PRICE_ARTICLE_NUMBER - eChar
            ePriceList = 120,
            
            // ADK_PRICE_PRICE_LIST - eChar
            ePriceBaseList = 121,
            
            // ADK_PRICE_PRICE_LIST - eChar
            ePriceNotBaseList = 122,
            
            // ADK_PRICE_PRICE_LIST - eChar
            // PurchasePrice
            ePurchasePriceArticleNrBase = 123,
            
            // ADK_ARTICLE_PURCHASE_PRICE_ARTICLE_NUMBER - eChar
            ePurchasePriceArticleNrStf = 124,
            
            // ADK_ARTICLE_PURCHASE_PRICE_ARTICLE_NUMBER - eChar
            ePurchasePriceArticleNrAll = 125,
            
            // ADK_ARTICLE_PURCHASE_PRICE_ARTICLE_NUMBER - eChar
            ePurchasePriceSupplierNrBase = 126,
            
            // ADK_ARTICLE_PURCHASE_PRICE_SUPPLIER_NUMBER - eChar
            ePurchasePriceSupplierNrStf = 127,
            
            // ADK_ARTICLE_PURCHASE_PRICE_SUPPLIER_NUMBER - eChar
            ePurchasePriceSupplierArticleNr = 128,
            
            // ADK_ARTICLE_PURCHASE_PRICE_SUPPLIER_NUMBER - eChar
            // WayOfPayment
            eWayOfPayment = 129,
            
            // ADK_CODE_OF_WAY_OF_PAYMENT_CODE - eChar
            // Member
            eMemberNr = 130,
            
            // ADK_MEMBER_NUMBER - eChar
            eMemberFirstName = 131,
            
            // ADK_MEMBER_FIRST_NAME - eChar
            eMemberLastName = 132,
            
            // ADK_MEMBER_LAST_NAME - eChar
            eMemberPostCode = 133,
            
            // ADK_MEMBER_ZIPCODE - eChar
            eMemberPersonalNumber = 134,
            
            // ADK_MEMBER_PERSONAL_NUMBER - eChar
            eMemberCategory = 135,
            
            // ADK_MEMBER_CATEGORY - eChar
            eMemberFreeCategory1 = 136,
            
            // ADK_MEMBER_FREE_CATEGORY1 - eChar
            eMemberFreeCategory2 = 137,
            
            // ADK_MEMBER_FREE_CATEGORY2 - eChar
            eMemberFreeCategory3 = 138,
            
            // ADK_MEMBER_FREE_CATEGORY3 - eChar
            eMemberFreeCategory4 = 139,
            
            // ADK_MEMBER_FREE_CATEGORY4 - eChar
            eMemberFreeCategory5 = 140,
            
            // ADK_MEMBER_FREE_CATEGORY5 - eChar
            eMemberFreeCategory6 = 141,
            
            // ADK_MEMBER_FREE_CATEGORY6 - eChar
            eMemberFreeCategory7 = 142,
            
            // ADK_MEMBER_FREE_CATEGORY7 - eChar
            eMemberFreeCategory8 = 143,
            
            // ADK_MEMBER_FREE_CATEGORY8 - eChar
            eMemberFreeCategory9 = 144,
            
            // ADK_MEMBER_FREE_CATEGORY9 - eChar
            eMemberFreeCategory10 = 145,
            
            // ADK_MEMBER_FREE_CATEGORY10 - eChar
            // DeliveryNote
            eDeliveryNoteNr = 146,
            
            // ADK_DELIVERY_NOTE_DOCUMENT_NUMBER - eDouble
            eDeliveryNoteSupplierNumber = 147,
            
            // ADK_DELIVERY_NOTE_SUPPLIER_NUMBER - eChar
            eDeliveryNoteSupplierName = 148,
            
            // ADK_DELIVERY_NOTE_SUPPLIER_NAME - eChar
            eDeliveryNoteInvoiceNotSentDeliveryNoteNr = 149,
            
            // ADK_DELIVERY_NOTE_DOCUMENT_NUMBER - eDouble
            eDeliveryNoteInvoiceNotSentSupplierNumber = 150,
            
            // ADK_DELIVERY_NOTE_SUPPLIER_NUMBER - eChar
            eDeliveryNoteInvoiceNotSentSupplierName = 151,
            
            // ADK_DELIVERY_NOTE_SUPPLIER_NAME - eChar
            // Package
            ePackageOrderNr = 152,
            
            // Package Import
            eImpPackageDelNoteNr = 153,
            
            // DeliveryAddress
            eDeliveryAddressCustomerNr = 154,
            
            // ADK_DELIVERY_CUSTOMER_NUMBER -eChar
            // Article
            eArticleWebShop = 155,
            
            eArticleBarCode = 156,
        }
        public enum ADK_ERROR_TEXT_TYPE
        {
            elRc = 0,
            elDbTable = 1,
            elField = 2,
            elFunction = 3,
            elProgramPart = 4,
        }
        
        public enum ADK_FIELD_TYPE
        {
            eUnused = 0,
            eBool = 1,
            eChar = 2,
            eDouble = 4,
            EDate = 5,
            eData = 6,
        }
        public enum ADK_RW
        {
            eReadOnly = 0,
            eReadWrite = 1,
        }
        // Streckkodstyper
        public enum ADK_BAR_CODE_TYPE
        {
            eEmpty = 0,
            // Tom
            eEAN_8 = 1,
            // EAN 8
            eEAN_13 = 2,
            // EAN 13
            eUPC_A = 3,
            // UPC-A
            eUPC_E = 4,
            // UPC-E
            eCode_39 = 5,
            // Code 39
            elongerleaved_2_5 = 6,
            // longerleaved 2/5
            eUS_Postnet = 7,
            // US Postnet
            eCode_128 = 8,
        }
        
        // Avgiftskod
        public enum ADK_CODE_BG_FOREIGN_FEE
        {
            //  Bank                         FB  HB  Nord    SE  Spar
            eBgSenderPays = 0,
            //  sender pays all              *   *   *       *   *
            eBgRecipPays = 1,
            //  recipiant pays all               *           *
            eBgRecipPaysExpr = 2,
            //  recipiant pays express fee                   *
            eBgRecipPaysForeign = 3,
        }
        
        // Vad ska kopieras vid Kreditfaktura?
        public enum ADK_CREDIT_INVOICE_TO_COPY
        {
            eEntireInvoice = 0,
            // The entire Invoice
            eInformation = 1,
            // Customer/Supplier-Information
            eNothing = 2,
        }
        
        // Kön (Medlemsregistret)
        public enum ADK_CODE_OF_SEX
        {
            eSexMale = 0,
            // Man
            eSexFemale = 1,
            // Kvinna
            eSexNone = 2,
        }
        
        #endregion
        
        #region +++ Public API Functions +++
        
        // Öppna företag - räkna ned användarlicenser
        [DllImport("adk.dll", EntryPoint = "_AdkOpen@8", CharSet = CharSet.Ansi)]
        public static extern ADKERROR AdkOpen(string sysPath, string ftgPath);
        
        // Stäng företag - räkna upp användarlicenser
        [DllImport("adk.dll", EntryPoint = "_AdkClose@0", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        public static extern int AdkClose();
        
        // Skapa en struktur
        [DllImport("adk.dll", EntryPoint = "_AdkCreateData@4", CharSet = CharSet.Ansi)]
        public static extern int AdkCreateData(int IDataBaseId);
        
        // Uppdatera
        [DllImport("adk.dll", EntryPoint = "_AdkUpdate@4", CharSet = CharSet.Ansi)]
        public static extern ADKERROR AdkUpdate(int pDb);
        
        // Återställ struktur
        [DllImport("adk.dll", EntryPoint = "_AdkResetStruct@4", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        public static extern ADKERROR AdkResetStruct(int pDb);
        
        // Radera struktur
        [DllImport("adk.dll", EntryPoint = "_AdkDeleteStruct@4", CharSet = CharSet.Ansi)]
        public static extern ADKERROR AdkDeleteStruct(int pDb);
        
        // Radera
        [DllImport("adk.dll", EntryPoint = "_AdkDelete@4", CharSet = CharSet.Ansi)]
        public static extern ADKERROR AdkDelete(int pDb);
        
        // Radera rad
        [DllImport("adk.dll", EntryPoint = "_AdkDeleteRow@8", ExactSpelling = true, CharSet = System.Runtime.InteropServices.CharSet.Ansi, SetLastError = true)]
        unsafe public static extern ADKERROR AdkDeleteRow(int pDb, int iIx);
        
        // Skapa en datarad
        [DllImport("adk.dll", EntryPoint = "_AdkCreateDataRow@8", CharSet = CharSet.Ansi)]
        public static extern int AdkCreateDataRow(int IDataBaseId, int iNumber);
        
        // Hämta en datarad
        [DllImport("adk.dll", EntryPoint = "_AdkGetDataRow@8", CharSet = CharSet.Ansi)]
        public static extern int AdkGetDataRow(int pDB, int iIndex);
        
        // Ställ på första post i strukturen
        [DllImport("adk.dll", EntryPoint = "_AdkFirst@4", CharSet = CharSet.Ansi)]
        public static extern ADKERROR AdkFirst(int pDb);
        
        // Nästa post
        [DllImport("adk.dll", EntryPoint = "_AdkNext@4", CharSet = CharSet.Ansi)]
        public static extern ADKERROR AdkNext(int pDb);
        
        // Föregående post
        [DllImport("adk.dll", EntryPoint = "_AdkPrevious@4", CharSet = CharSet.Ansi)]
        public static extern ADKERROR AdkPrevious(int pDb);
        
        // Ställ på sista post i strukturen
        [DllImport("adk.dll", EntryPoint = "_AdkLast@4", CharSet = CharSet.Ansi)]
        public static extern ADKERROR AdkLast(int pDb);
        
        // Sök upp en post
        [DllImport("adk.dll", EntryPoint = "_AdkFind@4", CharSet = CharSet.Ansi)]
        public static extern ADKERROR AdkFind(int pDb);
        
        // Lägg till
        [DllImport("adk.dll", EntryPoint = "_AdkAdd@4", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        public static extern ADKERROR AdkAdd(int pDb);
        
        // Hämta bool
        [DllImport("adk.dll", EntryPoint = "_AdkGetBool@12", CharSet = CharSet.Ansi)]
        public static extern ADKERROR AdkGetBool(int pDb, int iFieldID, ref int pbValue);
        
        // Hämta double
        [DllImport("adk.dll", EntryPoint = "_AdkGetDouble@12", CharSet = CharSet.Ansi)]
        public static extern ADKERROR AdkGetDouble(int pDb, int iFieldID, ref double pdValue);
        
        // Hämta sträng
        [DllImport("adk.dll", EntryPoint = "_AdkGetStr@16", CharSet = CharSet.Ansi)]
        public static extern ADKERROR AdkGetStr(int pDb, int iFieldID, ref string ppsValue, int iLen);
        
        //[DllImport("adk.dll", EntryPoint = "_AdkGetStr@16", CharSet = CharSet.Ansi)]
        //public static extern ADKERROR AdkGetStr(int pDb, int iFieldID, [MarshalAs(UnmanagedType.LPStr)] ref string val, int iLen);
        
        // Hämta datum
        [DllImport("adk.dll", EntryPoint = "_AdkGetDate@12", CharSet = CharSet.Ansi)]
        public static extern ADKERROR AdkGetDate(int pDb, int iFieldID, ref int pdaValue);
        
        // Hämta data
        [DllImport("adk.dll", EntryPoint = "_AdkGetData@16", CharSet = CharSet.Ansi)]
        public static extern ADKERROR AdkGetData(int pDb, int iFieldID, int iIndex, ref int pDbRow);
        
        // Hämta decimaler
        [DllImport("adk.dll", EntryPoint = "_AdkGetDecimals@12", CharSet = CharSet.Ansi)]
        public static extern ADKERROR AdkGetDecimals(int pDb, int iFieldID, ref int iDec);
        
        // Hämta en feltext
        [DllImport("adk.dll", EntryPoint = "_AdkGetErrorText@16", CharSet = CharSet.Ansi)]
        unsafe public static extern void AdkGetErrorText(ref ADKERROR err, int nErrorTextType, ref string achBuf, int ILen);
        
        //[DllImport("adk.dll", EntryPoint = "_AdkGetErrorText@16", CharSet = CharSet.Ansi)]
        //unsafe public static extern ADKERROR AdkGetErrorText(int err, int nErrorTextType, [MarshalAs(UnmanagedType.LPStr)]ref StringBuilder achBuf, int ILen);
        
        // Spara boolean
        
        [DllImport("adk.dll", EntryPoint = "_AdkSetBool@12", ExactSpelling = true, CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern ADKERROR AdkSetBool(int pDb, int iFieldId, int bValue);
        
        // Spara decimaler
        [DllImport("adk.dll", EntryPoint = "_AdkSetDouble@16", ExactSpelling = true, CharSet = CharSet.Ansi, SetLastError = true)]
        unsafe public static extern ADKERROR AdkSetDouble(int pDb, int iFieldId, double dValue);
        
        // Spara sträng
        [DllImport("adk.dll", EntryPoint = "_AdkSetStr@12", ExactSpelling = true, CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern ADKERROR AdkSetStr(int pDb, int iFieldId, string pValue);
        
        // Spara datum
        [DllImport("adk.dll", EntryPoint = "_AdkSetDate@12", ExactSpelling = true, CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern ADKERROR AdkSetDate(int pDb, int iFieldId, int lValue);
        
        // Spara data
        [DllImport("adk.dll", EntryPoint = "_AdkSetData@12", ExactSpelling = true, CharSet = CharSet.Ansi, SetLastError = true)]
        unsafe public static extern ADKERROR AdkSetData(int pDb, int iIx, int pDataRow);
        
        [DllImport("adk.dll", EntryPoint = "_AdkIsReadWrite@8", ExactSpelling = true, CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern bool AdkIsReadWrite(int pDb, int iFieldId);
        
        [DllImport("adk.dll", EntryPoint = "_AdkLongToDate@12", ExactSpelling = true, CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern ADKERROR AdkLongToDate(int lValue, ref string _ppsValue, int Ilen);
        
        [DllImport("adk.dll", EntryPoint = "_AdkDateToLong@8", ExactSpelling = true, CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern ADKERROR AdkDateToLong(string sValue, ref int plValue);
        
        [DllImport("adk.dll", EntryPoint = "_AdkGetType@12", ExactSpelling = true, CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern ADKERROR AdkGetType(int pDb, int iFieldId, ref ADK_FIELD_TYPE pType);
        
        [DllImport("adk.dll", EntryPoint = "_AdkGetLength@12", ExactSpelling = true, CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern ADKERROR AdkGetLength(int pDb, int iFieldId, ref int iLength);
        
        [DllImport("adk.dll", EntryPoint = "_AdkSetSortOrder@8", ExactSpelling = true, CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern ADKERROR AdkSetSortOrder(int pDb, ADK_SORT_ORDER iFieldId);
        
        [DllImport("adk.dll", EntryPoint = "_AdkGetFieldName@16", ExactSpelling = true, CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern ADKERROR AdkGetFieldName(int IDataBaseId, int iFieldId, ref string ppsValue, int Ilen);
        
        #endregion
        
        #region +++ Public Helper Functions +++
        
        public static double SPCSGetDouble(int pDb, int iFieldID)
        {
            double result = 0;
            SPCSAPI.AdkGetDouble(pDb, iFieldID, ref result);
            return result;
        }
        
        public static int SPCSDateToLong(DateTime date)
        {
            int result = 0;
            string dateString = date.ToString("yyyy-MM-dd");
            SPCSAPI.AdkDateToLong(dateString, ref result);
            return result;
        }
        
        public static DateTime SPCSGetDate(int pDb, int iFieldId)
        {
            int intDate = 0;
            SPCSAPI.ADKERROR result;
            result = SPCSAPI.AdkGetDate(pDb, iFieldId, ref intDate);
            string stringDate = new string(' ', 50);
            SPCSAPI.AdkLongToDate(intDate, ref stringDate, 50);
            if (result.lRc != 0)
                return DateTime.MinValue;
            else
                return DateTime.ParseExact(stringDate, "yyyy-MM-dd", null);
        }
        
        public static string SPCSGetString(int pDb, int iFieldId)
        {
            string resultValue = new string(' ', 256);
            SPCSAPI.ADKERROR result;
            result = SPCSAPI.AdkGetStr(pDb, iFieldId, ref resultValue, 256);
            if (result.lRc != 0)
                return null;
            else
                return resultValue;
        }
        
        public static string SPCSGetError(ADKERROR error, ADK_ERROR_TEXT_TYPE errorType)
        {
            string str = new string(' ', 256);
            SPCSAPI.AdkGetErrorText(ref error, (int)errorType, ref str, 256);
            return str;
        }
        
        public static void SPCSTry(ADKERROR error, string message)
        {
            Console.WriteLine("OK: {0}", message);
            if (error.lRc != 0)
            {
                string errorMessage = SPCSGetError(error, ADK_ERROR_TEXT_TYPE.elRc);
                throw new Exception(string.Format("SPCS: {0} => {1} ({2})", message, errorMessage, error.lRc));
            }
        }
        
        public static void SPCSWriteStruct(int pDb, int fieldId, int pValue, string message)
        {
            SPCSAPI.ADKERROR result;
            if (pValue > 0)
            {
                result = SPCSAPI.AdkSetData(pDb, fieldId, pValue);
                SPCSAPI.SPCSTry(result, message);
            }
        }
        
        public static void SPCSWriteString(int pDb, int fieldId, string value, string message)
        {
            SPCSAPI.ADKERROR result;
            if (!String.IsNullOrEmpty(value))
            {
                result = SPCSAPI.AdkSetStr(pDb, fieldId, value);
                SPCSAPI.SPCSTry(result, message);
            }
        }
        
        public static void SPCSWriteDate(int pDb, int fieldId, DateTime value, string message)
        {
            SPCSAPI.ADKERROR result;
            if (!value.Equals(DateTime.MinValue))
            {
                int longDate = SPCSAPI.SPCSDateToLong(value);
                result = SPCSAPI.AdkSetDate(pDb, fieldId, longDate);
                SPCSAPI.SPCSTry(result, message);
            }
        }
        
        public static void SPCSWriteBool(int pDb, int fieldId, bool value, string message)
        {
            SPCSAPI.ADKERROR result;
            result = SPCSAPI.AdkSetBool(pDb, fieldId, (value ? 1 : 0));
            SPCSAPI.SPCSTry(result, message);
        }
        
        public static void SPCSWriteDouble(int pDb, int fieldId, double value, string message)
        {
            SPCSAPI.ADKERROR result;
            if (!double.IsNaN(value))
            {
                result = SPCSAPI.AdkSetDouble(pDb, fieldId, value);
                SPCSAPI.SPCSTry(result, message);
            }
        }
        
        public static void SPCSAdd(int pDB, string message)
        {
            SPCSAPI.ADKERROR result;
            if (pDB > 0)
            {
                result = SPCSAPI.AdkAdd(pDB);
                SPCSAPI.SPCSTry(result, message);
            }
        }
        
        public static void SPCSDeleteStruct(int pDB, string message)
        {
            SPCSAPI.ADKERROR result;
            if (pDB > 0)
            {
                result = SPCSAPI.AdkDeleteStruct(pDB);
                SPCSAPI.SPCSTry(result, message);
            }
        }
        
        public static string PreProcessString(string value, int maxLength)
        {
            if (string.IsNullOrEmpty(value))
                return "";
                
            if (value.Length > maxLength)
                value = value.Replace(" ", "");
                
            if (value.Length > maxLength)
                value = value.Replace("-", "").Replace("/", "");
                
            if (value.Length > maxLength)
                value = value.Substring(0, maxLength);
                
            return value;
        }
        
        #endregion
    }
}

