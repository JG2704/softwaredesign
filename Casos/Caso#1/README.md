# CASO #1 - EJERCICIO #2
### **Author:** José Gabriel Marín Aguilar c.2022119819
Viernes 6 de marzo de 2026

## Problem Overview

The Documento Único Aduanero (DUA) is the official customs declaration document required for import and export operations in Costa Rica, regulated by the Ministerio de Hacienda.

Preparing a DUA requires interpreting heterogeneous documents such as invoices, packing lists, certificates of origin, transport documents, and permits. These files vary in format (Excel, Word, PDF, scanned images), structure, terminology, and quality. Manual preparation is:
- Repetitive
- Error-prone
- Highly dependent on expert knowledge
- Time-consuming

## Proposed Solution

DUA Streamliner is an AI-powered system that ingests a folder containing heterogeneous trade documents, extracts relevant customs data using semantic models, maps the information into the official DUA template, and generates a pre-filled Word document with confidence indicators.

The system does not replace the customs expert; it reduces operational workload and shifts the expert’s role toward validation and decision-making.

|Pros|Cons|
|----|-------|
|Reduces manual workload|OCR accuracy depends on document quality|
|Minimizes data entry errors|AI extraction requires continuous validation|
|Standardizes DUA preparation|Legal responsibility remains with the declarant|
|Improves processing time||
---

# 1. Frontend Design 

## 1.1 Technology Framework

- **Application type:** Web application fully responsive for tablet and mobile access.
- **Web Framework:** React 19.2
- **Runtime:** Node.js 21.x
- **Coding Language:** TypeScript 5.9.3
- **Bundler:** Vite 6.x
- **UI Framework:** MUI 6.x
- **Routing:** React Router DOM 6.25.x
- **Authentication Protocol:** OAuth2 / OpenID Connect (OIDC Client TS 3.x)
- **Unit Testing:** Jest 30.2.0
- **Data Validation:** Zod 3.x
- **Code prettier framework:** Prettier 3.x
- **Code style framework:** ESLint 9.x with @typescript-eslint 7.x
- **Integration testing tools:** Playwright 1.58.2
- **Cloud service:** Amazon Web Services (AWS)
- **Hosted services within the cloud service:**
    - AWS ECS Fargate
    - AWS Elastic Container Registry (ECR)
    - AWS Application Load Balancer (ALB)
    - AWS CloudFront
    - AWS CloudWatch
    - AWS Certificate Manager (ACM)
- **Code repositories service:** GitHub
- **Code automation task tool:** npm scripts (Node.js 21.x runtime)
- **CI CD pipelines technology:** GitHub Actions
- **Environments:**
    - Development
    - Quality Assurance
    - Stage
    - Production
- **Environment deployment tools:**
    - Docker 25.x
    - Terraform 1.8.x
    - AWS CLI 2.x
- **Observability framework:**
    - AWS CloudWatch
    - OpenTelemetry JS 1.x
    - Sentry 
---
## 1.2 UX/UI Analysis
### Core Business Process
The application allows customs operators to automatically generate a Documento Único Aduanero (DUA) from multiple source documents.

Users authenticate using their credentials and a one-time token sent to their email. Once logged in, they can either review previously generated DUAs or initiate the creation of a new one.

When generating a new DUA, the user configures the generation parameters such as accepted document formats and the template version to be used. The system then processes the uploaded documents, extracts the relevant customs information using AI models, and maps the data into the official DUA structure.

During processing, the user can monitor the progress of the extraction and generation process. Once completed, the system displays the generated DUA in a PDF viewer where the user can review and download the final document.

### Wireframes
#### **User Login**
The user logs into the system using their username, password, and a one-time authentication token received via email.
![Login](media/wireframes/wireframe_login.png)
![Login](media/wireframes/wireframe_login_2.png)

#### **Select Option**
After authentication, the user can choose between generating a new DUA or reviewing previously generated declarations.
![Select Option](media/wireframes/wireframe_options.png)

#### **DUA History**
The system displays a list of previously generated DUAs associated with the user account. Each record can later be expanded or downloaded.
![DUA History](media/wireframes/wireframe_history.png)

#### **Generator Configuration**
The user configures the generation process before uploading documents.

Configuration options include:
- Accepted document formats (PDF, Image, Word, Excel)
- DUA template version (latest from the Ministry of Finance or custom uploaded template)
- AI extraction mode (fast scan / detailed extraction)

![Generator Configuration](media/wireframes/wireframe_config.png)

#### **Upload Files**
The user uploads the commercial documents required to generate the DUA.
Files can be uploaded using drag-and-drop or manual selection.
Supported formats include:
- PDF
- DOCX
- XLSX
- Images

![Upload Files](media/wireframes/wireframe_upload_2.png)
![Upload Files2](media/wireframes/wireframe_upload.png)
![Upload Files3](media/wireframes/wireframe_upload_3.png)

#### **Processing Progress**
During the document processing stage, the user can monitor the progress of the generation pipeline. The interface displays a progress bar and indicates the current step of the process.

![Processing Progess](media/wireframes/wireframe_progress.png)

#### **DUA Result**
Once the process is completed, the generated DUA is displayed in a PDF preview interface. The user can review the document and download it as a PDF file.
![DUA Result](media/wireframes/wireframe_result.png)

---

