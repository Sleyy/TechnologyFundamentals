<?php

/* project/create.html.twig */
class __TwigTemplate_5b28dc0b3980fc0b0375522a4945ec6c68466c5df47c7b5d35b5c50bcf7c5429 extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        // line 1
        $this->parent = $this->loadTemplate("base.html.twig", "project/create.html.twig", 1);
        $this->blocks = array(
            'main' => array($this, 'block_main'),
        );
    }

    protected function doGetParent(array $context)
    {
        return "base.html.twig";
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        $__internal_d968549e6cd90848b4ca230a82a8cc93c33a4f2aea0061ce15bf7d00f62c2bae = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_d968549e6cd90848b4ca230a82a8cc93c33a4f2aea0061ce15bf7d00f62c2bae->enter($__internal_d968549e6cd90848b4ca230a82a8cc93c33a4f2aea0061ce15bf7d00f62c2bae_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "project/create.html.twig"));

        $__internal_f4a2dc0565ea2e485fccab11950d35ee47211ace91da71bc841b2036b8eaee70 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_f4a2dc0565ea2e485fccab11950d35ee47211ace91da71bc841b2036b8eaee70->enter($__internal_f4a2dc0565ea2e485fccab11950d35ee47211ace91da71bc841b2036b8eaee70_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "project/create.html.twig"));

        $this->parent->display($context, array_merge($this->blocks, $blocks));
        
        $__internal_d968549e6cd90848b4ca230a82a8cc93c33a4f2aea0061ce15bf7d00f62c2bae->leave($__internal_d968549e6cd90848b4ca230a82a8cc93c33a4f2aea0061ce15bf7d00f62c2bae_prof);

        
        $__internal_f4a2dc0565ea2e485fccab11950d35ee47211ace91da71bc841b2036b8eaee70->leave($__internal_f4a2dc0565ea2e485fccab11950d35ee47211ace91da71bc841b2036b8eaee70_prof);

    }

    // line 3
    public function block_main($context, array $blocks = array())
    {
        $__internal_9bb786288faefeb9df5e48c72c7846df5ca599ef5d7778250f254ee66bd202fd = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_9bb786288faefeb9df5e48c72c7846df5ca599ef5d7778250f254ee66bd202fd->enter($__internal_9bb786288faefeb9df5e48c72c7846df5ca599ef5d7778250f254ee66bd202fd_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "main"));

        $__internal_0e0198864ef0c2aa7c75caa152b5e39165b81cb2d60e58aefda4ee9b1910857e = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_0e0198864ef0c2aa7c75caa152b5e39165b81cb2d60e58aefda4ee9b1910857e->enter($__internal_0e0198864ef0c2aa7c75caa152b5e39165b81cb2d60e58aefda4ee9b1910857e_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "main"));

        // line 4
        echo "<div class=\"wrapper\">
    <form class=\"project-create\" method=\"post\">
        <div class=\"create-header\">
            Create Project
        </div>
        <div class=\"create-title\">
            <div class=\"create-title-label\">Title</div>
            <input class=\"create-title-content\" name=\"project[title]\" />
        </div>
        <div class=\"create-description\">
            <div class=\"create-description-label\">Description</div>
            <textarea rows=\"3\" class=\"create-description-content\" name=\"project[description]\"></textarea>
        </div>
        <div class=\"create-budget\">
            <div class=\"create-budget-label\">Budget</div>
            <input type=\"number\" min=\"0\" class=\"create-budget-content\" name=\"project[budget]\" />
        </div>
        <div class=\"create-button-holder\">
            <button type=\"submit\" class=\"submit-button\">Create Project</button>
            <a type=\"button\" href=\"/\" class=\"back-button\">Back</a>
        </div>

        ";
        // line 26
        echo $this->env->getRuntime('Symfony\Bridge\Twig\Form\TwigRenderer')->searchAndRenderBlock($this->getAttribute(($context["form"] ?? $this->getContext($context, "form")), "_token", array()), 'row');
        echo "
    </form>
</div>
";
        
        $__internal_0e0198864ef0c2aa7c75caa152b5e39165b81cb2d60e58aefda4ee9b1910857e->leave($__internal_0e0198864ef0c2aa7c75caa152b5e39165b81cb2d60e58aefda4ee9b1910857e_prof);

        
        $__internal_9bb786288faefeb9df5e48c72c7846df5ca599ef5d7778250f254ee66bd202fd->leave($__internal_9bb786288faefeb9df5e48c72c7846df5ca599ef5d7778250f254ee66bd202fd_prof);

    }

    public function getTemplateName()
    {
        return "project/create.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  73 => 26,  49 => 4,  40 => 3,  11 => 1,);
    }

    /** @deprecated since 1.27 (to be removed in 2.0). Use getSourceContext() instead */
    public function getSource()
    {
        @trigger_error('The '.__METHOD__.' method is deprecated since version 1.27 and will be removed in 2.0. Use getSourceContext() instead.', E_USER_DEPRECATED);

        return $this->getSourceContext()->getCode();
    }

    public function getSourceContext()
    {
        return new Twig_Source("{% extends \"base.html.twig\" %}

{% block main %}
<div class=\"wrapper\">
    <form class=\"project-create\" method=\"post\">
        <div class=\"create-header\">
            Create Project
        </div>
        <div class=\"create-title\">
            <div class=\"create-title-label\">Title</div>
            <input class=\"create-title-content\" name=\"project[title]\" />
        </div>
        <div class=\"create-description\">
            <div class=\"create-description-label\">Description</div>
            <textarea rows=\"3\" class=\"create-description-content\" name=\"project[description]\"></textarea>
        </div>
        <div class=\"create-budget\">
            <div class=\"create-budget-label\">Budget</div>
            <input type=\"number\" min=\"0\" class=\"create-budget-content\" name=\"project[budget]\" />
        </div>
        <div class=\"create-button-holder\">
            <button type=\"submit\" class=\"submit-button\">Create Project</button>
            <a type=\"button\" href=\"/\" class=\"back-button\">Back</a>
        </div>

        {{ form_row(form._token) }}
    </form>
</div>
{% endblock %}", "project/create.html.twig", "C:\\Projects\\PHP-Skeleton\\app\\Resources\\views\\project\\create.html.twig");
    }
}
